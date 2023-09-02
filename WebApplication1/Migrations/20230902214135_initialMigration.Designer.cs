﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230902214135_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("entrega1.shared.entitys.investigador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("afiliacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("especializacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firtname")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("firtname")
                        .IsUnique();

                    b.ToTable("proyectos");
                });

            modelBuilder.Entity("entrega1.shared.entitys.proyecto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("areaInvestigacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechafin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechainicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("name")
                        .IsUnique();

                    b.ToTable("proyecto");
                });
#pragma warning restore 612, 618
        }
    }
}
