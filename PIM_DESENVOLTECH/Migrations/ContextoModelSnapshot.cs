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

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int")
                        .HasColumnName("FuncionarioId");

                    b.Property<double>("INSS")
                        .HasColumnType("float")
                        .HasColumnName("INSS");

                    b.Property<double>("ImpostoDeRenda")
                        .HasColumnType("float")
                        .HasColumnName("ImpostoDeRenda");

                    b.Property<double>("ValeTransporte")
                        .HasColumnType("float")
                        .HasColumnName("ValeTransporte");

                    b.HasKey("IdDesconto");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("descontosSalariais");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.FolhaPonto", b =>
                {
                    b.Property<int>("IdFolhaPonto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdFolhaPonto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFolhaPonto"));

                    b.Property<int>("FK_Funcionario")
                        .HasColumnType("int")
                        .HasColumnName("FK_IdFuncionario");

                    b.Property<int?>("FuncionarioIdFuncionario")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraPonto")
                        .HasColumnType("datetime2")
                        .HasColumnName("HoraPonto");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int")
                        .HasColumnName("IdFuncionario");

                    b.HasKey("IdFolhaPonto");

                    b.HasIndex("FuncionarioIdFuncionario");

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
                        .IsRequired()
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Estado");

                    b.Property<bool>("FuncionarioAtivo")
                        .HasColumnType("bit")
                        .HasColumnName("FuncionarioAtivo");

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
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RG");

                    b.Property<double>("Salario")
                        .HasColumnType("float")
                        .HasColumnName("Salario");

                    b.Property<int?>("loginsId")
                        .HasColumnType("int");

                    b.HasKey("IdFuncionario");

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

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.RelacaoFerias", b =>
                {
                    b.Property<int>("IdFerias")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdFerias");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFerias"));

                    b.Property<DateTime>("FeriasFim")
                        .HasColumnType("datetime2")
                        .HasColumnName("FeriasFim");

                    b.Property<DateTime>("FeriasInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("FeriasInicio");

                    b.Property<int?>("FuncionarioIdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int")
                        .HasColumnName("FK_IdFuncionario");

                    b.HasKey("IdFerias");

                    b.HasIndex("FuncionarioIdFuncionario");

                    b.ToTable("RelacaoFerias");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.DescontosSalariais", b =>
                {
                    b.HasOne("PIM_DESENVOLTECH.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.FolhaPonto", b =>
                {
                    b.HasOne("PIM_DESENVOLTECH.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioIdFuncionario");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.Funcionario", b =>
                {
                    b.HasOne("PIM_DESENVOLTECH.Models.Login", "logins")
                        .WithMany()
                        .HasForeignKey("loginsId");

                    b.Navigation("logins");
                });

            modelBuilder.Entity("PIM_DESENVOLTECH.Models.RelacaoFerias", b =>
                {
                    b.HasOne("PIM_DESENVOLTECH.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioIdFuncionario");

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
