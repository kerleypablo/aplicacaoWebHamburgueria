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
    [Migration("20210923204551_tabelacompras")]
    partial class tabelacompras
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication1.Models.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datacompra");

                    b.HasKey("CompraId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("WebApplication1.Models.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contato");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("FornecedorId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima", b =>
                {
                    b.Property<int>("MateriaPrimaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int?>("TipoIdId");

                    b.Property<double>("VlrUnitario");

                    b.Property<double>("quantidade");

                    b.Property<int?>("uniId");

                    b.HasKey("MateriaPrimaId");

                    b.HasIndex("TipoIdId");

                    b.HasIndex("uniId");

                    b.ToTable("MateriaPrima");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_ComprasViewModel", b =>
                {
                    b.Property<int>("MateriaPrimaId");

                    b.Property<int>("CompraId");

                    b.Property<int?>("CompraId1");

                    b.HasKey("MateriaPrimaId", "CompraId");

                    b.HasIndex("CompraId");

                    b.HasIndex("CompraId1");

                    b.ToTable("Materia_Compras");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_FornecedorViewModel", b =>
                {
                    b.Property<int>("MateriaPrimaId");

                    b.Property<int>("FornecedorId");

                    b.Property<int?>("FornecedorId1");

                    b.HasKey("MateriaPrimaId", "FornecedorId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("FornecedorId1");

                    b.ToTable("Materia_Fornecedor");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_ProdutoFormViwModel", b =>
                {
                    b.Property<int>("MateriaPrimaId");

                    b.Property<int>("ProdutoId");

                    b.Property<int?>("MateriaPrimaId1");

                    b.HasKey("MateriaPrimaId", "ProdutoId");

                    b.HasIndex("MateriaPrimaId1");

                    b.ToTable("Materia_Prooduto");
                });

            modelBuilder.Entity("WebApplication1.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Imagem");

                    b.Property<string>("nome");

                    b.Property<double>("preco");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("WebApplication1.Models.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeTipo");

                    b.HasKey("Id");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("WebApplication1.Models.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Unidade");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima", b =>
                {
                    b.HasOne("WebApplication1.Models.Tipo", "TipoId")
                        .WithMany()
                        .HasForeignKey("TipoIdId");

                    b.HasOne("WebApplication1.Models.Unidade", "uni")
                        .WithMany()
                        .HasForeignKey("uniId");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_ComprasViewModel", b =>
                {
                    b.HasOne("WebApplication1.Models.MateriaPrima", "MateriaPrima")
                        .WithMany("Compras")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Compra", "Compra")
                        .WithMany("MateriasPrimas")
                        .HasForeignKey("CompraId1");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_FornecedorViewModel", b =>
                {
                    b.HasOne("WebApplication1.Models.MateriaPrima", "MateriaPrima")
                        .WithMany("Fornecedores")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Fornecedor", "Fornecedor")
                        .WithMany("MateriasPrimas")
                        .HasForeignKey("FornecedorId1");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_ProdutoFormViwModel", b =>
                {
                    b.HasOne("WebApplication1.Models.Produto", "Produto")
                        .WithMany("MateriasPrimas")
                        .HasForeignKey("MateriaPrimaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.MateriaPrima", "MateriaPrima")
                        .WithMany("produtos")
                        .HasForeignKey("MateriaPrimaId1");
                });
#pragma warning restore 612, 618
        }
    }
}
