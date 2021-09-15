﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(WebApplication1Context))]
    [Migration("20210915141616_TabelaFornecedores")]
    partial class TabelaFornecedores
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication1.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contato");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int?>("ProdutoID");

                    b.Property<double>("VlrUnitario");

                    b.Property<int?>("fornecedorIdId");

                    b.Property<double>("quantidade");

                    b.Property<int>("uni");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoID");

                    b.HasIndex("fornecedorIdId");

                    b.ToTable("MateriaPrima");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_Produto", b =>
                {
                    b.Property<int>("MateriaPrimaID");

                    b.Property<int>("ProdutoID");

                    b.HasKey("MateriaPrimaID", "ProdutoID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("MateriaPrima_Produto");
                });

            modelBuilder.Entity("WebApplication1.Models.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Imagem");

                    b.Property<string>("nome");

                    b.Property<double>("preco");

                    b.HasKey("ID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima", b =>
                {
                    b.HasOne("WebApplication1.Models.Produto")
                        .WithMany("MateriasPrima")
                        .HasForeignKey("ProdutoID");

                    b.HasOne("WebApplication1.Models.Fornecedor", "fornecedorId")
                        .WithMany()
                        .HasForeignKey("fornecedorIdId");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_Produto", b =>
                {
                    b.HasOne("WebApplication1.Models.MateriaPrima", "MateriaPrima")
                        .WithMany()
                        .HasForeignKey("MateriaPrimaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}