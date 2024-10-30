﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Translate.AspNetCore.Mvc.Entities;

#nullable disable

namespace Translate.AspNetCore.Mvc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241030161716_UpdateWordBookAndUser")]
    partial class UpdateWordBookAndUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Translate.AspNetCore.Mvc.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Translate.AspNetCore.Mvc.Models.WordBookModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WordId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WordId");

                    b.ToTable("WordBooks");
                });

            modelBuilder.Entity("Translate.AspNetCore.Mvc.Models.WordLevelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WordLevels");
                });

            modelBuilder.Entity("Translate.AspNetCore.Mvc.Models.WordModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("English")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Turkish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WordLevelId")
                        .HasColumnType("int");

                    b.Property<int>("WordTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WordLevelId");

                    b.HasIndex("WordTypeId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("Translate.AspNetCore.Mvc.Models.WordTypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WordTypes");
                });

            modelBuilder.Entity("Translate.AspNetCore.Mvc.Models.WordBookModel", b =>
                {
                    b.HasOne("Translate.AspNetCore.Mvc.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Translate.AspNetCore.Mvc.Models.WordModel", "Word")
                        .WithMany()
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Word");
                });

            modelBuilder.Entity("Translate.AspNetCore.Mvc.Models.WordModel", b =>
                {
                    b.HasOne("Translate.AspNetCore.Mvc.Models.WordLevelModel", "WordLevel")
                        .WithMany("Words")
                        .HasForeignKey("WordLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Translate.AspNetCore.Mvc.Models.WordTypeModel", "WordType")
                        .WithMany("Words")
                        .HasForeignKey("WordTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WordLevel");

                    b.Navigation("WordType");
                });

            modelBuilder.Entity("Translate.AspNetCore.Mvc.Models.WordLevelModel", b =>
                {
                    b.Navigation("Words");
                });

            modelBuilder.Entity("Translate.AspNetCore.Mvc.Models.WordTypeModel", b =>
                {
                    b.Navigation("Words");
                });
#pragma warning restore 612, 618
        }
    }
}
