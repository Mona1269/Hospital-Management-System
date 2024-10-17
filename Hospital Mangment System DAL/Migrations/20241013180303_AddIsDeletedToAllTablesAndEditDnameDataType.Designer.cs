﻿// <auto-generated />
using System;
using Hospital_Mangment_System_DAL.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital_Mangment_System_DAL.Migrations
{
    [DbContext(typeof(ApplicationDBcontext))]
    [Migration("20241013180303_AddIsDeletedToAllTablesAndEditDnameDataType")]
    partial class AddIsDeletedToAllTablesAndEditDnameDataType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Addmission", b =>
                {
                    b.Property<int>("Addmission_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Addmission_Id"));

                    b.Property<DateOnly>("Addmission_Date")
                        .HasColumnType("date");

                    b.Property<DateOnly>("Date_discharge")
                        .HasColumnType("date");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<int>("room_number")
                        .HasColumnType("int");

                    b.HasKey("Addmission_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("addmissions");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Appointment", b =>
                {
                    b.Property<int>("Appointment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Appointment_Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Reason_Of_Visit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("patient_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("timeOftheappointment")
                        .HasColumnType("datetime2");

                    b.HasKey("Appointment_Id");

                    b.HasIndex("patient_id");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Bill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfIssue")
                        .HasColumnType("date");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("patientId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("patientId");

                    b.ToTable("bills");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Department", b =>
                {
                    b.Property<int>("Dnum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dnum"));

                    b.Property<string>("Dname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dr_Id")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("Dnum");

                    b.HasIndex("ManagerId")
                        .IsUnique()
                        .HasFilter("[ManagerId] IS NOT NULL");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Doctor", b =>
                {
                    b.Property<int>("DrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrId"));

                    b.Property<int>("Dnum")
                        .HasColumnType("int");

                    b.Property<string>("DrName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrId");

                    b.HasIndex("Dnum");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Lap_test", b =>
                {
                    b.Property<int>("Test_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Test_ID"));

                    b.Property<int>("Dr_id")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Patient_ID")
                        .HasColumnType("int");

                    b.Property<string>("Test_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("doctorDrId")
                        .HasColumnType("int");

                    b.HasKey("Test_ID");

                    b.HasIndex("Patient_ID");

                    b.HasIndex("doctorDrId");

                    b.ToTable("lap_Tests");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Medical_equipment", b =>
                {
                    b.Property<int>("Equipment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Equipment_Id"));

                    b.Property<int>("Dnum")
                        .HasColumnType("int");

                    b.Property<string>("Equip_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Maintence_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Equipment_Id");

                    b.HasIndex("Dnum");

                    b.ToTable("medical_Equipment");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Nurse", b =>
                {
                    b.Property<int>("NurseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NurseID"));

                    b.Property<int>("Dnum")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NurseID");

                    b.HasIndex("Dnum");

                    b.ToTable("nurses");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("birthday")
                        .HasColumnType("date");

                    b.Property<int>("phone1")
                        .HasColumnType("int");

                    b.Property<int?>("phone2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Addmission", b =>
                {
                    b.HasOne("Hospital_Mangment_System_DAL.Entites.Patient", "patient")
                        .WithMany("Addmissions")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Appointment", b =>
                {
                    b.HasOne("Hospital_Mangment_System_DAL.Entites.Patient", "patient")
                        .WithMany("Appointments")
                        .HasForeignKey("patient_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Bill", b =>
                {
                    b.HasOne("Hospital_Mangment_System_DAL.Entites.Patient", "patient")
                        .WithMany("Bills")
                        .HasForeignKey("patientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Department", b =>
                {
                    b.HasOne("Hospital_Mangment_System_DAL.Entites.Doctor", "Manager")
                        .WithOne("ManagedDepartment")
                        .HasForeignKey("Hospital_Mangment_System_DAL.Entites.Department", "ManagerId");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Doctor", b =>
                {
                    b.HasOne("Hospital_Mangment_System_DAL.Entites.Department", "department")
                        .WithMany("Doctors")
                        .HasForeignKey("Dnum")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Lap_test", b =>
                {
                    b.HasOne("Hospital_Mangment_System_DAL.Entites.Patient", "patient")
                        .WithMany("lap_Tests")
                        .HasForeignKey("Patient_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Hospital_Mangment_System_DAL.Entites.Doctor", "doctor")
                        .WithMany("lap_Tests")
                        .HasForeignKey("doctorDrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Medical_equipment", b =>
                {
                    b.HasOne("Hospital_Mangment_System_DAL.Entites.Department", "Department")
                        .WithMany("medical_Equipments")
                        .HasForeignKey("Dnum")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Nurse", b =>
                {
                    b.HasOne("Hospital_Mangment_System_DAL.Entites.Department", "Department")
                        .WithMany("nurses")
                        .HasForeignKey("Dnum")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Department", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("medical_Equipments");

                    b.Navigation("nurses");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Doctor", b =>
                {
                    b.Navigation("ManagedDepartment")
                        .IsRequired();

                    b.Navigation("lap_Tests");
                });

            modelBuilder.Entity("Hospital_Mangment_System_DAL.Entites.Patient", b =>
                {
                    b.Navigation("Addmissions");

                    b.Navigation("Appointments");

                    b.Navigation("Bills");

                    b.Navigation("lap_Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
