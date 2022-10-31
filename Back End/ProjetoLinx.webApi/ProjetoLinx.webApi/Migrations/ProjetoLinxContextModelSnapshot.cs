﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoLinx.webApi.Data;

namespace ProjetoLinx.webApi.Migrations
{
    [DbContext(typeof(ProjetoLinxContext))]
    partial class ProjetoLinxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Anexo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Caminho")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("ReuniaoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReuniaoId");

                    b.ToTable("Anexos");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Anuncio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Anuncios");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.PropostaParaAnuncio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnuncioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<Guid?>("FornecedorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnuncioId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Propostas");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Reuniao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("DataReuniao")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("FornecedorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Local")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<Guid>("LojistaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TituloAnuncio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("LojistaId");

                    b.ToTable("Reunioes");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Topico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ReuniaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ReuniaoId");

                    b.ToTable("Topicos");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Celular")
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(115)
                        .HasColumnType("varchar(115)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Anexo", b =>
                {
                    b.HasOne("ProjetoLinx.webApi.Domains.Reuniao", "Reuniao")
                        .WithMany("Anexos")
                        .HasForeignKey("ReuniaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reuniao");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Anuncio", b =>
                {
                    b.HasOne("ProjetoLinx.webApi.Domains.Usuario", "Usuario")
                        .WithMany("Anuncios")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.PropostaParaAnuncio", b =>
                {
                    b.HasOne("ProjetoLinx.webApi.Domains.Anuncio", "Anuncio")
                        .WithMany("Propostas")
                        .HasForeignKey("AnuncioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoLinx.webApi.Domains.Usuario", "Usuario")
                        .WithMany("Propostas")
                        .HasForeignKey("FornecedorId");

                    b.Navigation("Anuncio");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Reuniao", b =>
                {
                    b.HasOne("ProjetoLinx.webApi.Domains.Usuario", "Fornecedor")
                        .WithMany("ReunioesFornecedores")
                        .HasForeignKey("FornecedorId");

                    b.HasOne("ProjetoLinx.webApi.Domains.Usuario", "Lojista")
                        .WithMany("ReunioesLojistas")
                        .HasForeignKey("LojistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");

                    b.Navigation("Lojista");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Topico", b =>
                {
                    b.HasOne("ProjetoLinx.webApi.Domains.Reuniao", "Reuniao")
                        .WithMany("Topicos")
                        .HasForeignKey("ReuniaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reuniao");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Anuncio", b =>
                {
                    b.Navigation("Propostas");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Reuniao", b =>
                {
                    b.Navigation("Anexos");

                    b.Navigation("Topicos");
                });

            modelBuilder.Entity("ProjetoLinx.webApi.Domains.Usuario", b =>
                {
                    b.Navigation("Anuncios");

                    b.Navigation("Propostas");

                    b.Navigation("ReunioesFornecedores");

                    b.Navigation("ReunioesLojistas");
                });
#pragma warning restore 612, 618
        }
    }
}
