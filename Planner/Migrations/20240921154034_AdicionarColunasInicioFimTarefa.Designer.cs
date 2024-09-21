﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Planner.Models;

#nullable disable

namespace Planner.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240921154034_AdicionarColunasInicioFimTarefa")]
    partial class AdicionarColunasInicioFimTarefa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("Planner.Models.Atividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaAtividade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Atividades");

                    b.HasDiscriminator().HasValue("Atividade");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Planner.Models.Lembrete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<bool>("RecorrenteSemanal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoLembrete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Lembretes");
                });

            modelBuilder.Entity("Planner.Models.Relatorio", b =>
                {
                    b.Property<string>("CategoriaMetaMaisRealizada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoriaTarefaMaisRealizada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MesesMaisProdutivos")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Periodo")
                        .HasColumnType("TEXT");

                    b.Property<double>("PorcentagemMetasCumpridas")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentagemTarefasExecutadas")
                        .HasColumnType("REAL");

                    b.Property<int>("QuantidadeMetasCumpridas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantidadeTarefasExecutadas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SemanasMaisProdutivas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TurnosMaisProdutivos")
                        .HasColumnType("INTEGER");

                    b.ToTable("Relatorios");
                });

            modelBuilder.Entity("Planner.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Planner.Models.Meta", b =>
                {
                    b.HasBaseType("Planner.Models.Atividade");

                    b.Property<DateTime>("Prazo")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusMeta")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Meta");
                });

            modelBuilder.Entity("Planner.Models.Tarefa", b =>
                {
                    b.HasBaseType("Planner.Models.Atividade");

                    b.Property<int>("BlocoDuracao")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Dia")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Fim")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Inicio")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusTarefa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Turnos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
