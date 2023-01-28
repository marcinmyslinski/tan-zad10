﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zad10.Models;

namespace zad10.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230118194624_ChangeFK")]
    partial class ChangeFK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("zad10.Models.Student", b =>
                {
                    b.Property<int>("IdStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdStudia")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NrIndeksu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RokStudiow")
                        .HasColumnType("int");

                    b.HasKey("IdStudent");

                    b.HasIndex("IdStudia");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("zad10.Models.Studia", b =>
                {
                    b.Property<int>("IdStudia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tryb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdStudia");

                    b.ToTable("Studias");
                });

            modelBuilder.Entity("zad10.Models.Student", b =>
                {
                    b.HasOne("zad10.Models.Studia", "Studia")
                        .WithMany("Students")
                        .HasForeignKey("IdStudia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studia");
                });

            modelBuilder.Entity("zad10.Models.Studia", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}