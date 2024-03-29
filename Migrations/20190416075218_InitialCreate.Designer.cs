﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace carichini.alessandro._5i.Corsi.Migrations
{
    [DbContext(typeof(corsiContex))]
    [Migration("20190416075218_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Ambito", b =>
                {
                    b.Property<int>("AmbitoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descrizione");

                    b.HasKey("AmbitoId");

                    b.ToTable("ambiti");
                });

            modelBuilder.Entity("Corso", b =>
                {
                    b.Property<int>("CorsoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descrizione");

                    b.Property<string>("GiornoSettimana");

                    b.Property<int>("NumeroLezioni");

                    b.Property<int>("NumeroMaxPartecipanti");

                    b.Property<DateTime>("OraFine");

                    b.Property<DateTime>("OraInizio");

                    b.Property<double>("Prezzo");

                    b.HasKey("CorsoId");

                    b.ToTable("corsi");
                });

            modelBuilder.Entity("Docente", b =>
                {
                    b.Property<int>("DocenteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cognome");

                    b.Property<DateTime>("DataNascita");

                    b.Property<string>("Nome");

                    b.HasKey("DocenteId");

                    b.ToTable("docenti");
                });
#pragma warning restore 612, 618
        }
    }
}
