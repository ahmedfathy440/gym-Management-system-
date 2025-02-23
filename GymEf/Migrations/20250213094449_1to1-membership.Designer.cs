﻿// <auto-generated />
using System;
using GymEf.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymEf.Migrations
{
    [DbContext(typeof(GymContext))]
    [Migration("20250213094449_1to1-membership")]
    partial class _1to1membership
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GymEf.Models.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassID"));

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.HasKey("ClassID");

                    b.HasIndex("TrainerID");

                    b.ToTable("classes");
                });

            modelBuilder.Entity("GymEf.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MembershipTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberID");

                    b.HasIndex("MembershipTypeID")
                        .IsUnique();

                    b.ToTable("Members");
                });

            modelBuilder.Entity("GymEf.Models.MembershipType", b =>
                {
                    b.Property<int>("MembershipTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MembershipTypeID"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MembershipTypeID");

                    b.ToTable("membershipTypes");
                });

            modelBuilder.Entity("GymEf.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("memberId")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("memberId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("GymEf.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerID");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("GymEf.Models.Class", b =>
                {
                    b.HasOne("GymEf.Models.Trainer", "Trainer")
                        .WithMany("Classes")
                        .HasForeignKey("TrainerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("GymEf.Models.Member", b =>
                {
                    b.HasOne("GymEf.Models.MembershipType", "MembershipType")
                        .WithOne("members")
                        .HasForeignKey("GymEf.Models.Member", "MembershipTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipType");
                });

            modelBuilder.Entity("GymEf.Models.Payment", b =>
                {
                    b.HasOne("GymEf.Models.Member", "member")
                        .WithMany()
                        .HasForeignKey("memberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("member");
                });

            modelBuilder.Entity("GymEf.Models.MembershipType", b =>
                {
                    b.Navigation("members")
                        .IsRequired();
                });

            modelBuilder.Entity("GymEf.Models.Trainer", b =>
                {
                    b.Navigation("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}
