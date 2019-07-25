﻿// <auto-generated />
using Filmotheque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Filmotheque.Migrations
{
    [DbContext(typeof(FilmothequeContext))]
    [Migration("20190724201721_init_user")]
    partial class init_user
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Filmotheque.Models.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age")
                        .HasMaxLength(110);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("f_User");
                });
#pragma warning restore 612, 618
        }
    }
}
