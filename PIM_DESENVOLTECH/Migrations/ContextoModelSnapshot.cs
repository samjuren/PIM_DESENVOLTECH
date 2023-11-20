﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PIM_DESENVOLTECH.Models;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.DescontosSalariais", b =>
                {
                    b.Property<int>("IdDesconto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdDesconto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDesconto"));

                    b.Property<int>("FuncionarioIdFuncionario")
                        .HasColumnType("int");

                    b.Property<double>("INSS")
                        .HasColumnType("float")
                        .HasColumnName("INSS");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int")
                        .HasColumnName("FK_IdFuncionario");

                    b.Property<double>("ImpostoDeRenda")
                        .HasColumnType("float")
                        .HasColumnName("ImpostoDeRenda");

                    b.Property<double>("ValeTransporte")
                        .HasColumnType("float")
                        .HasColumnName("ValeTransporte");

                    b.HasKey("IdDesconto");

                    b.HasIndex("FuncionarioIdFuncionario");

                    b.ToTable("descontosSalariais");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.FolhaPonto", b =>
                {
                    b.Property<int>("IdFolhaPonto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdFolhaPonto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFolhaPonto"));

                    b.Property<DateTime>("HoraPonto")
                        .HasColumnType("datetime2")
                        .HasColumnName("HoraPonto");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int")
                        .HasColumnName("IdFuncionario");

                    b.HasKey("IdFolhaPonto");

                    b.ToTable("FolhaPonto");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdFuncionario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncionario"));

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CEP");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CPF");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cidade");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Complemento");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataAdmissao");

                    b.Property<DateTime>("DataDemissao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataDemissao");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Departamento");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Estado");

                    b.Property<int?>("FolhaPontoIdFolhaPonto")
                        .HasColumnType("int");

                    b.Property<bool>("FuncionarioAtivo")
                        .HasColumnType("bit")
                        .HasColumnName("FuncionarioAtivo");

                    b.Property<int>("IdFolhaPonto")
                        .HasColumnType("int")
                        .HasColumnName("FK_IdFolhaPonto");

                    b.Property<int>("IdLogin")
                        .HasColumnType("int")
                        .HasColumnName("FK_IdLogin");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("Idade");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("Nascimento");

                    b.Property<string>("NomeCargo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeCargo");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeCompleto");

                    b.Property<string>("NomeRua")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeRua");

                    b.Property<int?>("NumeroRua")
                        .HasColumnType("int")
                        .HasColumnName("NumeroRua");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RG");

                    b.Property<string>("Salario")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Salario");

                    b.Property<int?>("loginsId")
                        .HasColumnType("int");

                    b.HasKey("IdFuncionario");

                    b.HasIndex("FolhaPontoIdFolhaPonto");

                    b.HasIndex("loginsId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAdm")
                        .HasColumnType("bit")
                        .HasColumnName("IsAdm");

                    b.Property<string>("NomeLogin")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeLogin");

                    b.Property<string>("SenhaLogin")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SenhaLogin");

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.DescontosSalariais", b =>
                {
                    b.HasOne("PIM_DESENVOLTECH.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioIdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.Funcionario", b =>
                {
                    b.HasOne("PIM_DESENVOLTECH.Models.FolhaPonto", "FolhaPonto")
                        .WithMany()
                        .HasForeignKey("FolhaPontoIdFolhaPonto");

                    b.HasOne("PIM_DESENVOLTECH.Models.Login", "logins")
                        .WithMany()
                        .HasForeignKey("loginsId");

                    b.Navigation("FolhaPonto");

                    b.Navigation("logins");
                });
#pragma warning restore 612, 618
        }
    }
}
