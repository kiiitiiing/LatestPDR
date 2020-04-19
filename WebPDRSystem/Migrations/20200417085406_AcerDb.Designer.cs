﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebPDRSystem.Data;

namespace WebPDRSystem.Migrations
{
    [DbContext(typeof(WebPDRContext))]
    [Migration("20200417085406_AcerDb")]
    partial class AcerDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebPDRSystem.Models.Barangay", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("MuncityId")
                        .HasColumnType("int");

                    b.Property<int>("OldTarget")
                        .HasColumnType("int");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<int>("Target")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Barangay");
                });

            modelBuilder.Entity("WebPDRSystem.Models.ClinicalParametersQd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BluishLipsOrFingers")
                        .HasColumnType("bit");

                    b.Property<bool>("BodyMuscleJointPain")
                        .HasColumnType("bit");

                    b.Property<bool>("Breathing")
                        .HasColumnType("bit");

                    b.Property<bool>("ChestPain")
                        .HasColumnType("bit");

                    b.Property<bool>("Colds")
                        .HasColumnType("bit");

                    b.Property<bool>("Confusion")
                        .HasColumnType("bit");

                    b.Property<bool>("Cough")
                        .HasColumnType("bit");

                    b.Property<int?>("DailyMonitoringFormQdModelId")
                        .HasColumnName("DailyMonitoringFormQD_ModelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateChecked")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Fever")
                        .HasColumnType("bit");

                    b.Property<bool>("Headache")
                        .HasColumnType("bit");

                    b.Property<bool>("Maintenance")
                        .HasColumnType("bit");

                    b.Property<bool>("MedsTaken")
                        .HasColumnType("bit");

                    b.Property<bool>("MentalDistress")
                        .HasColumnType("bit");

                    b.Property<bool>("NoSymptom")
                        .HasColumnType("bit");

                    b.Property<bool?>("Temperature")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DailyMonitoringFormQdModelId");

                    b.ToTable("ClinicalParametersQD");
                });

            modelBuilder.Entity("WebPDRSystem.Models.ClinicalParametersQn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bp")
                        .IsRequired()
                        .HasColumnName("BP")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int?>("DailyMonitoringFormQnModelId")
                        .HasColumnName("DailyMonitoringFormQN_ModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateChecked")
                        .HasColumnType("datetime2");

                    b.Property<string>("Enumerate")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Hr")
                        .IsRequired()
                        .HasColumnName("HR")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Meds")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("O2sat")
                        .IsRequired()
                        .HasColumnName("O2Sat")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Rr")
                        .IsRequired()
                        .HasColumnName("RR")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("SignatureOfQn")
                        .IsRequired()
                        .HasColumnName("SignatureOfQN")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("TimeFluidChanged")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime>("TimeFluidStarter")
                        .HasColumnType("datetime2");

                    b.Property<string>("UrineOutput")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("DailyMonitoringFormQnModelId");

                    b.ToTable("ClinicalParametersQN");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Discharge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateDischarged")
                        .HasColumnType("datetime2");

                    b.Property<string>("DischargedApprovedBy")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("DischargedBy")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("GuardOnDuty")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("HealthCareBuddy")
                        .HasColumnType("int");

                    b.Property<int>("Pdrid")
                        .HasColumnName("PDRId")
                        .HasColumnType("int");

                    b.Property<string>("QuarantineDirectorOrOfficer")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("HealthCareBuddy");

                    b.HasIndex("Pdrid");

                    b.ToTable("Discharge");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Guardian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int?>("Barangay")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Lastname")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Middlename")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("Muncity")
                        .HasColumnType("int");

                    b.Property<int>("Province")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Guardian");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Muncity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Muncity");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Barangay")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Middlename")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("Muncity")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Occupation")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Picture")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("Province")
                        .HasColumnType("int");

                    b.Property<string>("Religion")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Barangay");

                    b.HasIndex("Muncity");

                    b.HasIndex("Province");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Pdr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdmissionTemperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BedNumber")
                        .HasColumnType("int");

                    b.Property<int>("CaseNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfAdmission")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOnsetSymptoms")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTesting")
                        .HasColumnType("datetime2");

                    b.Property<string>("FoodRestrictionsAllergy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Guardian")
                        .HasColumnType("int");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterviewedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maintenance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Patient")
                        .HasColumnType("int");

                    b.Property<string>("PreExistingConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuarantineFacility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferringFacility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Results")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SymptomsContactsId")
                        .HasColumnType("int");

                    b.Property<string>("TravelHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Guardian");

                    b.HasIndex("Patient");

                    b.HasIndex("SymptomsContactsId");

                    b.ToTable("PDR");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Pdrusers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Middlename")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Picture")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Schedule")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int?>("Team")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Team");

                    b.ToTable("PDRUsers");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("PhotoFilePath")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("PhotoString")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Qdform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("HealthCareBuddy")
                        .HasColumnType("int");

                    b.Property<int>("Patient")
                        .HasColumnType("int");

                    b.Property<string>("SignatureOfQd")
                        .HasColumnName("SignatureOfQD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HealthCareBuddy");

                    b.ToTable("QDForm");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Qnform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Patient")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("QNForm");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Referral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfReferral")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pdrid")
                        .HasColumnName("PDRId")
                        .HasColumnType("int");

                    b.Property<string>("PertinentFindings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferredBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferredTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferringQuarantineFacility")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Pdrid");

                    b.ToTable("Referral");
                });

            modelBuilder.Entity("WebPDRSystem.Models.SymptomsContacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CloseContacts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SymptomsOfPatient")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SymptomsContacts");
                });

            modelBuilder.Entity("WebPDRSystem.Models.TeamSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("TeamSchedule");
                });

            modelBuilder.Entity("WebPDRSystem.Models.UserTeams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("UserTeams");
                });

            modelBuilder.Entity("WebPDRSystem.Models.ClinicalParametersQd", b =>
                {
                    b.HasOne("WebPDRSystem.Models.Qdform", "DailyMonitoringFormQdModel")
                        .WithMany("ClinicalParametersQd")
                        .HasForeignKey("DailyMonitoringFormQdModelId")
                        .HasConstraintName("FK_ClinicalParametersQD_QDFormTable_DailyMonitoringFormQD_ModelId");
                });

            modelBuilder.Entity("WebPDRSystem.Models.ClinicalParametersQn", b =>
                {
                    b.HasOne("WebPDRSystem.Models.Qnform", "DailyMonitoringFormQnModel")
                        .WithMany("ClinicalParametersQn")
                        .HasForeignKey("DailyMonitoringFormQnModelId")
                        .HasConstraintName("FK_ClinicalParametersQN_QNFormTable_DailyMonitoringFormQN_ModelId");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Discharge", b =>
                {
                    b.HasOne("WebPDRSystem.Models.Pdrusers", "HealthCareBuddyNavigation")
                        .WithMany("Discharge")
                        .HasForeignKey("HealthCareBuddy")
                        .HasConstraintName("FK_DischargeTable_PDRUsers")
                        .IsRequired();

                    b.HasOne("WebPDRSystem.Models.Pdr", "Pdr")
                        .WithMany("Discharge")
                        .HasForeignKey("Pdrid")
                        .HasConstraintName("FK_DischargeTable_PDRTable")
                        .IsRequired();
                });

            modelBuilder.Entity("WebPDRSystem.Models.Patient", b =>
                {
                    b.HasOne("WebPDRSystem.Models.Barangay", "BarangayNavigation")
                        .WithMany("Patient")
                        .HasForeignKey("Barangay")
                        .HasConstraintName("FK_Patient_Barangay")
                        .IsRequired();

                    b.HasOne("WebPDRSystem.Models.Muncity", "MuncityNavigation")
                        .WithMany("Patient")
                        .HasForeignKey("Muncity")
                        .HasConstraintName("FK_Patient_Muncity")
                        .IsRequired();

                    b.HasOne("WebPDRSystem.Models.Province", "ProvinceNavigation")
                        .WithMany("Patient")
                        .HasForeignKey("Province")
                        .HasConstraintName("FK_Patient_Province")
                        .IsRequired();
                });

            modelBuilder.Entity("WebPDRSystem.Models.Pdr", b =>
                {
                    b.HasOne("WebPDRSystem.Models.Guardian", "GuardianNavigation")
                        .WithMany("Pdr")
                        .HasForeignKey("Guardian")
                        .HasConstraintName("FK_PDRTable_Guardian")
                        .IsRequired();

                    b.HasOne("WebPDRSystem.Models.Patient", "PatientNavigation")
                        .WithMany("Pdr")
                        .HasForeignKey("Patient")
                        .HasConstraintName("FK_PDR_Patient")
                        .IsRequired();

                    b.HasOne("WebPDRSystem.Models.SymptomsContacts", "SymptomsContacts")
                        .WithMany("Pdr")
                        .HasForeignKey("SymptomsContactsId")
                        .HasConstraintName("FK_PDR_SymptomsContacts");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Pdrusers", b =>
                {
                    b.HasOne("WebPDRSystem.Models.UserTeams", "TeamNavigation")
                        .WithMany("Pdrusers")
                        .HasForeignKey("Team")
                        .HasConstraintName("FK_PDRUsers_UserTeams");
                });

            modelBuilder.Entity("WebPDRSystem.Models.Qdform", b =>
                {
                    b.HasOne("WebPDRSystem.Models.Pdrusers", "HealthCareBuddyNavigation")
                        .WithMany("Qdform")
                        .HasForeignKey("HealthCareBuddy")
                        .HasConstraintName("FK_QDFormTable_PDRUsers")
                        .IsRequired();
                });

            modelBuilder.Entity("WebPDRSystem.Models.Referral", b =>
                {
                    b.HasOne("WebPDRSystem.Models.Pdr", "Pdr")
                        .WithMany("Referral")
                        .HasForeignKey("Pdrid")
                        .HasConstraintName("FK_ReferralTable_PDRTable")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
