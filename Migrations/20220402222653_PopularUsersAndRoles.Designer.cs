// <auto-generated />
using System;
using LanchesMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LanchesMVC.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220402222653_PopularUsersAndRoles")]
    partial class PopularUsersAndRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LanchesMVC.Models.CarrinhoCompraItem", b =>
                {
                    b.Property<int>("CarrinhoCompraItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CarrinhoCompraItemId"));

                    b.Property<string>("CarrinhoCompraId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int?>("LancheId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.HasKey("CarrinhoCompraItemId");

                    b.HasIndex("LancheId");

                    b.ToTable("carrinhocompraitens", "lanches");
                });

            modelBuilder.Entity("LanchesMVC.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("categoria", "lanches");
                });

            modelBuilder.Entity("LanchesMVC.Models.Lanche", b =>
                {
                    b.Property<int>("LancheId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LancheId"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("integer")
                        .HasColumnName("categoriaid");

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricaocurta");

                    b.Property<string>("DescricaoDetalhada")
                        .HasColumnType("text")
                        .HasColumnName("descricaodetalhada");

                    b.Property<bool>("EmEstoque")
                        .HasColumnType("boolean")
                        .HasColumnName("emestoque");

                    b.Property<string>("ImagemThumbnailUrl")
                        .HasColumnType("text")
                        .HasColumnName("imagemthumbnailurl");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("text")
                        .HasColumnName("imagemurl");

                    b.Property<bool>("IsLanchePreferido")
                        .HasColumnType("boolean")
                        .HasColumnName("islanchepreferido");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("preco");

                    b.HasKey("LancheId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("lanches", "lanches");
                });

            modelBuilder.Entity("LanchesMVC.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PedidoId"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("complemento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("endereco");

                    b.Property<string>("Estado")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("sobrenome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("telefone");

                    b.Property<string>("dataEnvio")
                        .HasColumnType("text")
                        .HasColumnName("dataenvio");

                    b.Property<string>("dataPedido")
                        .HasColumnType("text")
                        .HasColumnName("datapedido");

                    b.Property<int>("totalItensPedido")
                        .HasColumnType("integer");

                    b.Property<decimal>("totalPedido")
                        .HasColumnType("numeric(18,2)");

                    b.HasKey("PedidoId");

                    b.ToTable("lanches", "pedidos");
                });

            modelBuilder.Entity("LanchesMVC.Models.PedidoDetalhe", b =>
                {
                    b.Property<int>("PedidoDetalheId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PedidoDetalheId"));

                    b.Property<int>("LancheId")
                        .HasColumnType("integer");

                    b.Property<int>("PedidoId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric(18,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.HasKey("PedidoDetalheId");

                    b.HasIndex("LancheId");

                    b.HasIndex("PedidoId");

                    b.ToTable("lanches", "pedidosdetalhes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "af626e9d-106b-4f5a-bd53-40947faf73e1",
                            ConcurrencyStamp = "77375756-cdf6-4c49-9c3f-7bf321bbbc5b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2d709469-c2fa-413e-b240-c1c77389e2d5",
                            ConcurrencyStamp = "5701d617-bd5a-4719-8f5a-2638a0022aec",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "672f3b13-7717-4b7b-aa71-a56c094535e1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "27446710-1b19-43ce-b495-69ee2e988c73",
                            Email = "sysadmin@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SYSADMIN@LOCALHOST.COM",
                            NormalizedUserName = "SYSADMIN",
                            PasswordHash = "7fmvQUWGAQQJTZb3rsYK9jBodY6ZXd/CP6oXvj5y7Jo=",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "296f61b2-7df7-42c2-8101-14e7b05a08e8",
                            TwoFactorEnabled = false,
                            UserName = "sysadmin"
                        },
                        new
                        {
                            Id = "1970fd9c-2f80-4a0b-99ff-378a013f2d5d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9ad4fe7d-c0b3-4d1e-91d4-f26d99c41f10",
                            Email = "sysmember@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SYSMEMBER@LOCALHOST.COM",
                            NormalizedUserName = "SYSMEMBER",
                            PasswordHash = "KUQtJcxLbPgxjPty4CM6ARiTLu0A+3ncojtUqfZThUQ=",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "11ef2984-a4f3-4d84-818a-b7e48b43873a",
                            TwoFactorEnabled = false,
                            UserName = "sysmember"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "672f3b13-7717-4b7b-aa71-a56c094535e1",
                            RoleId = "af626e9d-106b-4f5a-bd53-40947faf73e1"
                        },
                        new
                        {
                            UserId = "1970fd9c-2f80-4a0b-99ff-378a013f2d5d",
                            RoleId = "2d709469-c2fa-413e-b240-c1c77389e2d5"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LanchesMVC.Models.CarrinhoCompraItem", b =>
                {
                    b.HasOne("LanchesMVC.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId");

                    b.Navigation("Lanche");
                });

            modelBuilder.Entity("LanchesMVC.Models.Lanche", b =>
                {
                    b.HasOne("LanchesMVC.Models.Categoria", "Categoria")
                        .WithMany("Lanches")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("LanchesMVC.Models.PedidoDetalhe", b =>
                {
                    b.HasOne("LanchesMVC.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanchesMVC.Models.Pedido", "Pedido")
                        .WithMany("PeditoItens")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lanche");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LanchesMVC.Models.Categoria", b =>
                {
                    b.Navigation("Lanches");
                });

            modelBuilder.Entity("LanchesMVC.Models.Pedido", b =>
                {
                    b.Navigation("PeditoItens");
                });
#pragma warning restore 612, 618
        }
    }
}
