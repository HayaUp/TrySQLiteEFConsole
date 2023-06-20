﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrySQLiteEFConsole;

namespace TrySQLiteEFConsole.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("TrySQLiteEFConsole.Prefecture", b =>
                {
                    b.Property<int>("PrefectureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PrefectureId1")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrefectureId");

                    b.HasIndex("PrefectureId1");

                    b.ToTable("Prefectures");
                });

            modelBuilder.Entity("TrySQLiteEFConsole.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TrySQLiteEFConsole.Prefecture", b =>
                {
                    b.HasOne("TrySQLiteEFConsole.Prefecture", null)
                        .WithMany("Prefectures")
                        .HasForeignKey("PrefectureId1");
                });

            modelBuilder.Entity("TrySQLiteEFConsole.Prefecture", b =>
                {
                    b.Navigation("Prefectures");
                });
#pragma warning restore 612, 618
        }
    }
}
