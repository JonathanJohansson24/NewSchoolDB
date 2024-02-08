﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewSchoolDB.Data;

#nullable disable

namespace NewSchoolDB.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20240206094326_Change salary variable from int to decimal")]
    partial class Changesalaryvariablefrominttodecimal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NewSchoolDB.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Course_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("NewSchoolDB.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateOnly>("Date_Of_Employment")
                        .HasColumnType("date");

                    b.Property<string>("Emp_FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Emp_LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("NewSchoolDB.Models.EmployeeRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("RoleMeaning")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("EmployeesRole");
                });

            modelBuilder.Entity("NewSchoolDB.Models.Grade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("Grade_Date")
                        .HasColumnType("date");

                    b.Property<int?>("GradingScalesID")
                        .HasColumnType("int");

                    b.Property<int?>("StudentsID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("GradingScalesID");

                    b.HasIndex("StudentsID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("NewSchoolDB.Models.GradingScale", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Grade_Meaning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade_Points")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("GradesScale");
                });

            modelBuilder.Entity("NewSchoolDB.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Class_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stu_FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Stu_LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Stu_SocialNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("NewSchoolDB.Models.Employee", b =>
                {
                    b.HasOne("NewSchoolDB.Models.EmployeeRole", "Role")
                        .WithMany("Employee")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("NewSchoolDB.Models.Grade", b =>
                {
                    b.HasOne("NewSchoolDB.Models.Course", "Course")
                        .WithMany("Grades")
                        .HasForeignKey("CourseID");

                    b.HasOne("NewSchoolDB.Models.Employee", "Employee")
                        .WithMany("Grades")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("NewSchoolDB.Models.GradingScale", "GradingScales")
                        .WithMany("Grades")
                        .HasForeignKey("GradingScalesID");

                    b.HasOne("NewSchoolDB.Models.Student", "Students")
                        .WithMany("Grades")
                        .HasForeignKey("StudentsID");

                    b.Navigation("Course");

                    b.Navigation("Employee");

                    b.Navigation("GradingScales");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("NewSchoolDB.Models.Course", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("NewSchoolDB.Models.Employee", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("NewSchoolDB.Models.EmployeeRole", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("NewSchoolDB.Models.GradingScale", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("NewSchoolDB.Models.Student", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
