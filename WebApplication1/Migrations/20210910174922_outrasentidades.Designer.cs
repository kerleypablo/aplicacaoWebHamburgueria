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
    [Migration("20210910174922_outrasentidades")]
    partial class outrasentidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int?>("ProdutoID");

                    b.Property<double>("VlrUnitario");

                    b.Property<double>("quantidade");

                    b.Property<int>("uni");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoID");

                    b.ToTable("MateriaPrima");
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_Produto", b =>
                {
                    b.Property<int>("IdMateriaPrima");

                    b.Property<int>("IdProduto");

                    b.Property<int?>("MateriaPrimaId");

                    b.Property<int?>("ProdutoID");

                    b.HasKey("IdMateriaPrima", "IdProduto");

                    b.HasIndex("MateriaPrimaId");

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
                });

            modelBuilder.Entity("WebApplication1.Models.MateriaPrima_Produto", b =>
                {
                    b.HasOne("WebApplication1.Models.MateriaPrima", "MateriaPrima")
                        .WithMany()
                        .HasForeignKey("MateriaPrimaId");

                    b.HasOne("WebApplication1.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID");
                });
#pragma warning restore 612, 618
        }
    }
}
