﻿// <auto-generated />
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
    [Migration("20220402201943_PopularUsersERoles")]
    partial class PopularUsersERoles
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
                            Id = "5f2dcdc6-a0da-4a21-aff6-cf7bc5985dfa",
                            ConcurrencyStamp = "2ff528fa-8e70-4b64-a305-499f9547333b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "72c195ff-79e5-4840-864a-ba1abc9dac33",
                            ConcurrencyStamp = "1f007696-00ad-47e7-bd95-c49f5f501d02",
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
                            Id = "71029eae-eaae-410f-bda2-09cf95943e2f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0e7b76b0-2f9b-467e-b76c-792012d58c3a",
                            Email = "sysadmin@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SYSADMIN@LOCALHOST.COM",
                            NormalizedUserName = "SYSADMIN",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c9a00d5b-3b1d-442e-bbc8-c8c31aaf3906",
                            TwoFactorEnabled = false,
                            UserName = "sysadmin"
                        },
                        new
                        {
                            Id = "b2ad36f2-a35d-4820-b650-2d47cd096715",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "038ebbde-dd34-429a-a9c5-14a9aefbbb2d",
                            Email = "sysmember@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SYSMEMBER@LOCALHOST.COM",
                            NormalizedUserName = "SYSMEMBER",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "94ddbadd-cc72-4d2f-aa5b-961ff42e689b",
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
                            UserId = "71029eae-eaae-410f-bda2-09cf95943e2f",
                            RoleId = "5f2dcdc6-a0da-4a21-aff6-cf7bc5985dfa"
                        },
                        new
                        {
                            UserId = "b2ad36f2-a35d-4820-b650-2d47cd096715",
                            RoleId = "72c195ff-79e5-4840-864a-ba1abc9dac33"
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
