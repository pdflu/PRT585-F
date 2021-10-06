﻿// <auto-generated />
using System;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211006041330_InitDatabase")]
    partial class InitDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DAL.Entities.Applicant", b =>
                {
                    b.Property<long>("Applicant_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("applicant_id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Applicant_BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("applicant_birthdate");

                    b.Property<DateTime>("Applicant_CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 10, 6, 4, 13, 30, 517, DateTimeKind.Utc).AddTicks(1909))
                        .HasColumnName("applicant_creationdate");

                    b.Property<DateTime>("Applicant_ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                        .HasColumnName("applicant_modifieddate");

                    b.Property<string>("Applicant_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("applicant_name");

                    b.Property<string>("Applicant_Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("applicant_surname");

                    b.Property<string>("Contact_Email")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("contact_email");

                    b.Property<string>("Contact_Number")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("contact_number");

                    b.HasKey("Applicant_ID");

                    b.ToTable("applicant");
                });

            modelBuilder.Entity("DAL.Entities.Application", b =>
                {
                    b.Property<long>("Application_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("application_id")
                        .UseIdentityColumn();

                    b.Property<long>("Applicant_ID")
                        .HasColumnType("bigint")
                        .HasColumnName("applicant_id");

                    b.Property<long>("ApplicationStatus_ID")
                        .HasColumnType("bigint")
                        .HasColumnName("application_status_id");

                    b.Property<DateTime>("Application_CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 10, 6, 4, 13, 30, 538, DateTimeKind.Utc).AddTicks(2287))
                        .HasColumnName("application_creationdate");

                    b.Property<DateTime>("Application_ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                        .HasColumnName("application_modifieddate");

                    b.Property<long>("Grade_ID")
                        .HasColumnType("bigint")
                        .HasColumnName("grade_id");

                    b.Property<int>("SchoolYear")
                        .HasColumnType("int")
                        .HasColumnName("application_schoolyear");

                    b.HasKey("Application_ID");

                    b.HasIndex("Applicant_ID");

                    b.HasIndex("ApplicationStatus_ID");

                    b.HasIndex("Grade_ID");

                    b.ToTable("application");
                });

            modelBuilder.Entity("DAL.Entities.ApplicationStatus", b =>
                {
                    b.Property<long>("ApplicationStatus_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("application_status_id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ApplicationStatus_CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 10, 6, 4, 13, 30, 535, DateTimeKind.Utc).AddTicks(5897))
                        .HasColumnName("application_status_creationdate");

                    b.Property<string>("ApplicationStatus_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("application_status_name");

                    b.Property<DateTime>("ApplicationtStatus_ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                        .HasColumnName("application_status_modifieddate");

                    b.HasKey("ApplicationStatus_ID");

                    b.HasIndex("ApplicationStatus_Name")
                        .IsUnique();

                    b.ToTable("application_status");
                });

            modelBuilder.Entity("DAL.Entities.Grade", b =>
                {
                    b.Property<long>("Grade_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("grade_id")
                        .UseIdentityColumn();

                    b.Property<int>("Grade_Capacity")
                        .HasColumnType("int")
                        .HasColumnName("grade_capacity");

                    b.Property<DateTime>("Grade_CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 10, 6, 4, 13, 30, 537, DateTimeKind.Utc).AddTicks(4413))
                        .HasColumnName("grade_creationdate");

                    b.Property<DateTime>("Grade_ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                        .HasColumnName("grade_modifieddate");

                    b.Property<string>("Grade_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("grade_name");

                    b.Property<int>("Grade_Number")
                        .HasColumnType("int")
                        .HasColumnName("grade_number");

                    b.HasKey("Grade_ID");

                    b.HasIndex("Grade_Name")
                        .IsUnique();

                    b.HasIndex("Grade_Number")
                        .IsUnique();

                    b.ToTable("grade");
                });

            modelBuilder.Entity("DAL.Entities.Application", b =>
                {
                    b.HasOne("DAL.Entities.Applicant", "Applicant")
                        .WithMany("Applications")
                        .HasForeignKey("Applicant_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Entities.ApplicationStatus", "ApplicationStatus")
                        .WithMany("Applications")
                        .HasForeignKey("ApplicationStatus_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Grade", "Grade")
                        .WithMany("Applications")
                        .HasForeignKey("Grade_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Applicant");

                    b.Navigation("ApplicationStatus");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("DAL.Entities.Applicant", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("DAL.Entities.ApplicationStatus", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("DAL.Entities.Grade", b =>
                {
                    b.Navigation("Applications");
                });
#pragma warning restore 612, 618
        }
    }
}
