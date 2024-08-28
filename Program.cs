using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigradorDocumentacao.Entitys.CPE;
using MigradorDocumentacao.Entitys.GMP;
using MigradorDocumentacao.Entitys.RHF;
using MigradorDocumentacao.Entitys.TRB;

public static class GeradorDocumentacao
{
    public static string GerarDocumentacao<T>(EntityTypeBuilder<T> builder) where T : class
    {
        var entityType = builder.Metadata;
        var properties = entityType.GetProperties();

        var sb = new StringBuilder();

        sb.AppendLine($"## {entityType.GetTableName()}");
        sb.AppendLine();
        sb.AppendLine("| Campo                                         | Descrição dos Campos                                                  | Obrigatório |");
        sb.AppendLine("| --------------------------------------------- | --------------------------------------------------------------------- | ----------- |");

        foreach (var property in properties)
        {
            var columnName = property.GetColumnName();
            var descricao = "Descricao";
            var isRequired = property.IsNullable ? "Não" : "Sim";

            // Garantir que a largura das colunas esteja alinhada
            sb.AppendLine($"| {columnName,-45} | {descricao,-69} | {isRequired,-11} |");
        }

        return sb.ToString();
    }

    private static string GetDefaultValue(string dataType)
    {
        return dataType.ToLower() switch
        {
            "int" => "0",
            "string" => "\"string\"",
            "bool" => "false",
            "decimal" => "0.0",
            "float" => "0.0",
            "double" => "0.0",
            "datetime" => "\"yyyy-MM-ddTHH:mm:ss\"",
            _ => "null"
        };
    }

    private static string GetClrTypeName(Type type)
    {
        return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>)
            ? type.GetGenericArguments()[0].Name
            : type.Name;
    }
}

public class ServidorConfiguration : IEntityTypeConfiguration<Servidor>
{
    public void Configure(EntityTypeBuilder<Servidor> builder)
    {
        const string tabela = "vw_fl_portal_agape";

        builder.ToView(tabela);

        builder.HasNoKey();

        builder.Property(e => e.PortalId)
          .HasColumnName("id_portal")
          .IsRequired(false);

        builder.Property(e => e.HashCliente)
          .HasColumnName("hash_cliente")
          .IsRequired(false);

        builder.Property(e => e.IdFuncionarioContrato)
          .HasColumnName("id_funcionario_contrato")
          .IsRequired(false);

        builder.Property(e => e.IdFolhaPagamento)
          .HasColumnName("id_folha_pagamento")
          .IsRequired(false);

        builder.Property(e => e.IdCompetenciaPgto)
          .HasColumnName("id_competencia_pgto")
          .IsRequired(false);

        builder.Property(e => e.IdCliente)
          .HasColumnName("id_cliente")
          .IsRequired(false);

        builder.Property(e => e.Competencia)
          .HasColumnName("competencia")
          .IsRequired(false);

        builder.Property(e => e.Ano)
          .HasColumnName("ano")
          .IsRequired(false);

        builder.Property(e => e.Mes)
          .HasColumnName("mes")
          .IsRequired(false);

        builder.Property(e => e.Matricula)
          .HasColumnName("matricula")
          .IsRequired(false);

        builder.Property(e => e.NomeFuncionario)
          .HasColumnName("nome_funcionario")
          .IsRequired(false);

        builder.Property(e => e.Cpf)
          .HasColumnName("cpf")
          .IsRequired(false);

        builder.Property(e => e.DataNascimento)
          .HasColumnName("data_nascimento")
          .IsRequired(false);

        builder.Property(e => e.GrauInstrucao)
          .HasColumnName("grau_instrucao")
          .IsRequired(false);

        builder.Property(e => e.Situacao)
          .HasColumnName("situacao")
          .IsRequired(false);

        builder.Property(e => e.DataAdmissao)
          .HasColumnName("data_admissao")
          .IsRequired(false);

        builder.Property(e => e.DataDemissao)
          .HasColumnName("data_demissao")
          .IsRequired(false);

        builder.Property(e => e.Nacionalidade)
          .HasColumnName("nacionalidade")
          .IsRequired(false);

        builder.Property(e => e.Cargo)
          .HasColumnName("cargo")
          .IsRequired(false);

        builder.Property(e => e.NomeCargo)
          .HasColumnName("nome_cargo")
          .IsRequired(false);

        builder.Property(e => e.VagasPrevistaCargo)
          .HasColumnName("vagas_prevista_cargo")
          .IsRequired(false);

        builder.Property(e => e.VagasOculpadasCargo)
          .HasColumnName("vagas_oculpadas_cargo")
          .IsRequired(false);

        builder.Property(e => e.VagasLivreCargos)
          .HasColumnName("vagas_livre_cargo")
          .IsRequired(false);

        builder.Property(e => e.SalarioCargo)
          .HasColumnName("salario_cargo")
          .IsRequired(false);

        builder.Property(e => e.PadraoCargo)
          .HasColumnName("padrao_cargo")
          .IsRequired(false);

        builder.Property(e => e.Profissao)
          .HasColumnName("profissao")
          .IsRequired(false);

        builder.Property(e => e.NomeProfissao)
          .HasColumnName("nome_profissao")
          .IsRequired(false);

        builder.Property(e => e.SalarioProfissao)
          .HasColumnName("salario_profissao")
          .IsRequired(false);

        builder.Property(e => e.CodigoRegime)
          .HasColumnName("codigo_regime")
          .IsRequired(false);

        builder.Property(e => e.NomeRegime)
          .HasColumnName("nome_regime")
          .IsRequired(false);

        builder.Property(e => e.Lotacao)
          .HasColumnName("lotacao")
          .IsRequired(false);

        builder.Property(e => e.DataAtoNomeacao)
          .HasColumnName("data_ato_nomeacao")
          .IsRequired(false);

        builder.Property(e => e.NumeroAtoDemissao)
          .HasColumnName("numero_ato_demissao")
          .IsRequired(false);

        builder.Property(e => e.DataAtoDemissao)
          .HasColumnName("data_ato_demissao")
          .IsRequired(false);

        builder.Property(e => e.NumeroConcurso)
          .HasColumnName("numero_concurso")
          .IsRequired(false);

        builder.Property(e => e.DataInicioFerias)
          .HasColumnName("data_inicio_ferias")
          .IsRequired(false);

        builder.Property(e => e.DataRetornoFerias)
          .HasColumnName("data_retorno_ferias")
          .IsRequired(false);

        builder.Property(e => e.TotalRendimentos)
          .HasColumnName("total_rendimentos")
          .IsRequired(false);

        builder.Property(e => e.Salario)
          .HasColumnName("salario")
          .IsRequired(false);

        builder.Property(e => e.Gratificacoes)
          .HasColumnName("gratificacoes")
          .IsRequired(false);

        builder.Property(e => e.VerbasRescisorias)
          .HasColumnName("verbas_rescisorias")
          .IsRequired(false);

        builder.Property(e => e.Ferias)
          .HasColumnName("ferias")
          .IsRequired(false);

        builder.Property(e => e.DecimoTerceiro)
          .HasColumnName("decimo_terceiro")
          .IsRequired(false);

        builder.Property(e => e.DescontoIrrf)
          .HasColumnName("desconto_irrf")
          .IsRequired(false);

        builder.Property(e => e.PrevidenciaSocial)
          .HasColumnName("previdencia_social")
          .IsRequired(false);

        builder.Property(e => e.OutrosDescontos)
          .HasColumnName("outros_descontos")
          .IsRequired(false);

        builder.Property(e => e.HorasExtras)
          .HasColumnName("horas_extras")
          .IsRequired(false);

        builder.Property(e => e.Substituicao)
          .HasColumnName("substituicao")
          .IsRequired(false);

        builder.Property(e => e.ExtensaoJornada)
          .HasColumnName("extensao_jornada")
          .IsRequired(false);

        builder.Property(e => e.AbateTeto)
          .HasColumnName("abate_teto")
          .IsRequired(false);

        builder.Property(e => e.PrimeiraParcela)
          .HasColumnName("primeira_parcela")
          .IsRequired(false);

        builder.Property(e => e.ValeAlimentacao)
          .HasColumnName("vale_alimentacao")
          .IsRequired(false);

        builder.Property(e => e.Diarias)
          .HasColumnName("diarias")
          .IsRequired(false);

        builder.Property(e => e.UmTercoFerias)
          .HasColumnName("um_terco_ferias")
          .IsRequired(false);

        builder.Property(e => e.BolsaEstagio)
          .HasColumnName("bolsa_estagio")
          .IsRequired(false);

        builder.Property(e => e.VantagensPessoais)
          .HasColumnName("vantagens_pessoais")
          .IsRequired(false);

        builder.Property(e => e.PrevidenciaPatronal)
          .HasColumnName("previdencia_patronal")
          .IsRequired(false);

        builder.Property(e => e.TetoSalarial)
          .HasColumnName("teto_salarial")
          .IsRequired(false);

        builder.Property(e => e.DiferencasSalariais)
          .HasColumnName("diferencas_salariais")
          .IsRequired(false);

        builder.Property(e => e.Subsidio)
          .HasColumnName("subsidio")
          .IsRequired(false);

        builder.Property(e => e.VantagensEventuais)
          .HasColumnName("vantagens_eventuais")
          .IsRequired(false);

        builder.Property(e => e.Indenizacoes)
          .HasColumnName("indenizacoes")
          .IsRequired(false);

        builder.Property(e => e.Produtividade)
          .HasColumnName("produtividade")
          .IsRequired(false);

        builder.Property(e => e.OutrosRendimentos)
          .HasColumnName("outros_rendimentos")
          .IsRequired(false);

        builder.Property(e => e.Vinculo)
          .HasColumnName("vinculo")
          .IsRequired(false);

        builder.Property(e => e.Local)
          .HasColumnName("local")
          .IsRequired(false);

        builder.Property(e => e.Custeio)
          .HasColumnName("custeio")
          .IsRequired(false);

        builder.Property(e => e.Enquadramento)
          .HasColumnName("enquadramento")
          .IsRequired(false);

        builder.Property(e => e.CodigoVerba)
          .HasColumnName("codigo_verba")
          .IsRequired(false);

        builder.Property(e => e.NomeVerba)
          .HasColumnName("nome_verba")
          .IsRequired(false);

        builder.Property(e => e.Tipo)
          .HasColumnName("tipo")
          .IsRequired(false);

        builder.Property(e => e.Grupo)
          .HasColumnName("grupo")
          .IsRequired(false);

        builder.Property(e => e.Valor)
          .HasColumnName("valor")
          .IsRequired(false);

        builder.Property(e => e.Beneficios)
          .HasColumnName("beneficios")
          .IsRequired(false);

        builder.Property(e => e.BeneficioMaternidade)
          .HasColumnName("beneficio_maternidade")
          .IsRequired(false);

        builder.Property(e => e.Abonos)
          .HasColumnName("abonos")
          .IsRequired(false);

        builder.Property(e => e.PadraoProfissao)
          .HasColumnName("padrao_profissao")
          .IsRequired(false);

        builder.Property(e => e.JornadaTrabalho)
          .HasColumnName("jornada_trabalho")
          .IsRequired(false);

        builder.Property(e => e.Secretaria)
          .HasColumnName("secretaria")
          .IsRequired(false);

        builder.Property(e => e.NomeSecretaria)
          .HasColumnName("nome_secretaria")
          .IsRequired(false);

        builder.Property(e => e.SiglaSecretaria)
          .HasColumnName("sigla_secretaria")
          .IsRequired(false);

        builder.Property(e => e.NumeroAtoNomeacao)
          .HasColumnName("numero_ato_nomeacao")
          .IsRequired(false);

        builder.Property(e => e.TotalDescontos)
          .HasColumnName("total_descontos")
          .IsRequired(false);

        // Gere a documentação usando o builder fornecido pelo Entity Framework
        var documentacao = GeradorDocumentacao.GerarDocumentacao(builder);
        Console.WriteLine(documentacao);
    }
}


public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    //public DbSet<Transferencia> Transferencias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var transferenciasConfiguration = new ServidorConfiguration();
        transferenciasConfiguration.Configure(modelBuilder.Entity<Servidor>());
    }
}

class Program
{
    static void Main(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();

        // Certifique-se de que você adicionou o pacote Microsoft.EntityFrameworkCore.InMemory ao seu projeto
        optionsBuilder.UseInMemoryDatabase("TestDB");

        using var context = new MyDbContext(optionsBuilder.Options);

        // Garante que o banco de dados em memória está criado
        context.Database.EnsureCreated();

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
