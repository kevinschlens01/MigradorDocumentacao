using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigradorDocumentacao.Entitys;

public static class GeradorDocumentacao
{
    public static string GerarDocumentacao<T>(EntityTypeBuilder<T> builder) where T : class
    {
        var entityType = builder.Metadata;
        var properties = entityType.GetProperties();

        var sb = new StringBuilder();

        sb.AppendLine($"## {entityType.GetTableName()}");
        sb.AppendLine();
        sb.AppendLine("| Campo | Obrigatório |");
        sb.AppendLine("| ----- | ----------- |");

        foreach (var property in properties)
        {
            var columnName = property.GetColumnName();
            var isRequired = property.IsNullable ? "Não" : "Sim";

            // Garantir que a largura das colunas esteja alinhada
            sb.AppendLine($"| {columnName,-20} | {isRequired,-11} |");
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

public class TransferenciasConfiguration : IEntityTypeConfiguration<Transferencia>
{
    public void Configure(EntityTypeBuilder<Transferencia> builder)
    {
        const string tabela = "vw_portal_cpe_convenio";

        builder.ToTable(tabela);

        builder.Property(e => e.Id)
            .HasColumnName("id")
            .IsRequired();

        builder.HasKey(e => e.Id)
         .HasName($"pk_{tabela}");

        builder.Property(e => e.PortalId)
          .HasColumnName("portal_id")
          .IsRequired();

        builder.Property(e => e.HashRegistro)
          .HasColumnName("hash_registro")
          .IsRequired(false);

        builder.Property(e => e.HashCliente)
          .HasColumnName("hash_cliente")
          .IsRequired();

        builder.Property(e => e.NomEmpresa)
          .HasColumnName("nom_empresa")
          .IsRequired(false);

        builder.Property(e => e.NroEmpresaCnpj)
          .HasColumnName("nro_empresa_cnpj")
          .IsRequired(false);

        builder.Property(e => e.NomFilial)
          .HasColumnName("nom_filial")
          .IsRequired(false);

        builder.Property(e => e.NroFilialCnpj)
          .HasColumnName("nro_filial_cnpj")
          .IsRequired(false);

        builder.Property(e => e.AnoConvenio)
          .HasColumnName("ano_convenio")
          .IsRequired(false);

        builder.Property(e => e.NrdConvenio)
          .HasColumnName("nrd_convenio")
          .IsRequired(false);

        builder.Property(e => e.NomConvenio)
          .HasColumnName("nom_convenio")
          .IsRequired(false);

        builder.Property(e => e.DatConvenio)
          .HasColumnName("dat_convenio")
          .IsRequired(false);

        builder.Property(e => e.MesConvenio)
          .HasColumnName("mes_convenio")
          .IsRequired(false);

        builder.Property(e => e.AnoProcesso)
          .HasColumnName("ano_processo")
          .IsRequired(false);

        builder.Property(e => e.NrdProcesso)
          .HasColumnName("nrd_processo")
          .IsRequired(false);

        builder.Property(e => e.SblPessoaParticipanteTipo)
          .HasColumnName("sbl_pessoa_participante_tipo")
          .IsRequired(false);

        builder.Property(e => e.NomPessoaParticipanteTipo)
          .HasColumnName("nom_pessoa_participante_tipo")
          .IsRequired(false);

        builder.Property(e => e.NomPessoaParticipante)
          .HasColumnName("nom_pessoa_participante")
          .IsRequired(false);

        builder.Property(e => e.NroPessoaParticipanteCpfCnpj)
          .HasColumnName("nro_pessoa_participante_cpf_cnpj")
          .IsRequired(false);

        builder.Property(e => e.HstConvenio)
          .HasColumnName("hst_convenio")
          .IsRequired(false);

        builder.Property(e => e.VlrConvenio)
          .HasColumnName("vlr_convenio")
          .IsRequired(false);

        builder.Property(e => e.Anexo)
          .HasColumnName("anexo")
          .IsRequired(false);

        builder.Property(e => e.HashRegistroCpe)
          .HasColumnName("hash_registro_cpe")
          .IsRequired(false);

        builder.Property(e => e.ControleCpe)
          .HasColumnName("controle_cpe")
          .IsRequired(false);

        builder.Property(e => e.SblTipoConvenio)
          .HasColumnName("sbl_convenio_tipo")
          .IsRequired(false);

        // Gere a documentação usando o builder fornecido pelo Entity Framework
        var documentacao = GeradorDocumentacao.GerarDocumentacao(builder);
        Console.WriteLine(documentacao);
    }
}

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<Transferencia> Transferencias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var transferenciasConfiguration = new TransferenciasConfiguration();
        transferenciasConfiguration.Configure(modelBuilder.Entity<Transferencia>());
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
