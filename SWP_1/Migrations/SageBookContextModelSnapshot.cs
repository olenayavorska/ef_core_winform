﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SWP_1;

namespace SWP_1.Migrations
{
    [DbContext(typeof(SageBookContext))]
    partial class SageBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SWP_1.Book", b =>
                {
                    b.Property<int>("IdBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBook");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("SWP_1.Sage", b =>
                {
                    b.Property<int>("IdSage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("photo")
                        .HasColumnType("int");

                    b.HasKey("IdSage");

                    b.ToTable("Sages");
                });

            modelBuilder.Entity("SWP_1.SageBook", b =>
                {
                    b.Property<int>("idSage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookIdBook")
                        .HasColumnType("int");

                    b.Property<int>("IdBook")
                        .HasColumnType("int");

                    b.Property<int?>("SageIdSage")
                        .HasColumnType("int");

                    b.HasKey("idSage");

                    b.HasIndex("BookIdBook");

                    b.HasIndex("SageIdSage");

                    b.ToTable("SageBooks");
                });

            modelBuilder.Entity("SWP_1.SageBook", b =>
                {
                    b.HasOne("SWP_1.Book", "Book")
                        .WithMany("SageBooks")
                        .HasForeignKey("BookIdBook");

                    b.HasOne("SWP_1.Sage", "Sage")
                        .WithMany("SageBooks")
                        .HasForeignKey("SageIdSage");

                    b.Navigation("Book");

                    b.Navigation("Sage");
                });

            modelBuilder.Entity("SWP_1.Book", b =>
                {
                    b.Navigation("SageBooks");
                });

            modelBuilder.Entity("SWP_1.Sage", b =>
                {
                    b.Navigation("SageBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
