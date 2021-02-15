﻿// <auto-generated />
using System;
using BlazorAppServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorAppServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorAppServer.Models.Classe", b =>
                {
                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Numero");

                    b.HasIndex("SectionId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("BlazorAppServer.Models.Eleve", b =>
                {
                    b.Property<string>("Matricule")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClasseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateDeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("LieuDeNaissance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postnom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexe")
                        .HasColumnType("int");

                    b.HasKey("Matricule");

                    b.HasIndex("ClasseId");

                    b.ToTable("Eleves");
                });

            modelBuilder.Entity("BlazorAppServer.Models.Inscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnneeScolaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateInscription")
                        .HasColumnType("datetime2");

                    b.Property<string>("Matricule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumClasse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inscriptions");
                });

            modelBuilder.Entity("BlazorAppServer.Models.Section", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("BlazorAppServer.Models.Classe", b =>
                {
                    b.HasOne("BlazorAppServer.Models.Section", "Section")
                        .WithMany("Classes")
                        .HasForeignKey("SectionId");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("BlazorAppServer.Models.Eleve", b =>
                {
                    b.HasOne("BlazorAppServer.Models.Classe", "Classe")
                        .WithMany("Eleves")
                        .HasForeignKey("ClasseId");

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("BlazorAppServer.Models.Classe", b =>
                {
                    b.Navigation("Eleves");
                });

            modelBuilder.Entity("BlazorAppServer.Models.Section", b =>
                {
                    b.Navigation("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}