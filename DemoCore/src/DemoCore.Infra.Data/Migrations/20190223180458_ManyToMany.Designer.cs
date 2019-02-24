﻿// <auto-generated />
using System;
using DemoCore.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoCore.Infra.Data.Migrations
{
    [DbContext(typeof(DemoCoreContext))]
    [Migration("20190223180458_ManyToMany")]
    partial class ManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("DemoCoreData")
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoCore.Domain.Models.BestWorkTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateLastUpdate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnName("LastUpdate")
                        .HasColumnType("datetime");

                    b.Property<string>("DescriptionEN")
                        .IsRequired()
                        .HasColumnName("DescriptionEN")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DescriptionPT")
                        .IsRequired()
                        .HasColumnName("DescriptionPT")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EntityState")
                        .IsRequired()
                        .HasColumnName("EntityState")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("BestWorkTime","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.Designer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateLastUpdate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnName("LastUpdate")
                        .HasColumnType("datetime");

                    b.Property<string>("DescriptionEN")
                        .IsRequired()
                        .HasColumnName("DescriptionEN")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DescriptionPT")
                        .IsRequired()
                        .HasColumnName("DescriptionPT")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EntityState")
                        .IsRequired()
                        .HasColumnName("EntityState")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("Designer","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateLastUpdate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnName("LastUpdate")
                        .HasColumnType("datetime");

                    b.Property<string>("DescriptionEN")
                        .IsRequired()
                        .HasColumnName("DescriptionEN")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DescriptionPT")
                        .IsRequired()
                        .HasColumnName("DescriptionPT")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EntityState")
                        .IsRequired()
                        .HasColumnName("EntityState")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("Developer","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.Knowledge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateLastUpdate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnName("LastUpdate")
                        .HasColumnType("datetime");

                    b.Property<string>("EntityState")
                        .IsRequired()
                        .HasColumnName("EntityState")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Other")
                        .HasColumnName("Other")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("PeopleId");

                    b.Property<string>("UrlLinkCRUD");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasAlternateKey("PeopleId");

                    b.ToTable("Knowledge","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.KnowledgeDesigner", b =>
                {
                    b.Property<int>("KnowledgeId");

                    b.Property<int>("DesignerId");

                    b.Property<int>("Value");

                    b.HasKey("KnowledgeId", "DesignerId");

                    b.HasIndex("DesignerId");

                    b.ToTable("KnowledgeDesigner","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.KnowledgeDeveloper", b =>
                {
                    b.Property<int>("KnowledgeId");

                    b.Property<int>("DeveloperId");

                    b.Property<int>("Value");

                    b.HasKey("KnowledgeId", "DeveloperId");

                    b.HasIndex("DeveloperId");

                    b.ToTable("KnowledgeDeveloper","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.Occupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime?>("DateLastUpdate");

                    b.Property<int>("EntityState");

                    b.Property<bool>("HasChanges");

                    b.Property<bool>("IsNew");

                    b.Property<int>("PeopleId");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasAlternateKey("PeopleId");

                    b.ToTable("Occupation","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.OccupationBestWorkTime", b =>
                {
                    b.Property<int>("OccupationId");

                    b.Property<int>("BestWorkTimeId");

                    b.HasKey("OccupationId", "BestWorkTimeId");

                    b.HasIndex("BestWorkTimeId");

                    b.ToTable("OccupationBestWorkTime","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.OccupationWorkAvailability", b =>
                {
                    b.Property<int>("OccupationId");

                    b.Property<int>("WorkAvailabilityId");

                    b.HasKey("OccupationId", "WorkAvailabilityId");

                    b.HasIndex("WorkAvailabilityId");

                    b.ToTable("OccupationWorkAvailability","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateLastUpdate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnName("LastUpdate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("EntityState")
                        .IsRequired()
                        .HasColumnName("EntityState")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDesigner")
                        .HasColumnName("IsDesigner");

                    b.Property<bool>("IsDeveloper")
                        .HasColumnName("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<string>("LinkedIn")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("Celular")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Portfolio")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Skype")
                        .IsRequired()
                        .HasColumnName("Skype")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("People","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.WorkAvailability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateLastUpdate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnName("LastUpdate")
                        .HasColumnType("datetime");

                    b.Property<string>("DescriptionEN")
                        .IsRequired()
                        .HasColumnName("DescriptionEN")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DescriptionPT")
                        .IsRequired()
                        .HasColumnName("DescriptionPT")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EntityState")
                        .IsRequired()
                        .HasColumnName("EntityState")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("WorkAvailability","DemoCoreData");
                });

            modelBuilder.Entity("DemoCore.Domain.Models.Knowledge", b =>
                {
                    b.HasOne("DemoCore.Domain.Models.People", "People")
                        .WithOne("Knowledge")
                        .HasForeignKey("DemoCore.Domain.Models.Knowledge", "PeopleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCore.Domain.Models.KnowledgeDesigner", b =>
                {
                    b.HasOne("DemoCore.Domain.Models.Designer", "Designer")
                        .WithMany()
                        .HasForeignKey("DesignerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCore.Domain.Models.Knowledge", "Knowledge")
                        .WithMany("KnowledgeDesigner")
                        .HasForeignKey("KnowledgeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCore.Domain.Models.KnowledgeDeveloper", b =>
                {
                    b.HasOne("DemoCore.Domain.Models.Developer", "Developer")
                        .WithMany()
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCore.Domain.Models.Knowledge", "Knowledge")
                        .WithMany("KnowledgeDeveloper")
                        .HasForeignKey("KnowledgeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCore.Domain.Models.Occupation", b =>
                {
                    b.HasOne("DemoCore.Domain.Models.People", "People")
                        .WithOne("Occupation")
                        .HasForeignKey("DemoCore.Domain.Models.Occupation", "PeopleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCore.Domain.Models.OccupationBestWorkTime", b =>
                {
                    b.HasOne("DemoCore.Domain.Models.BestWorkTime", "BestWorkTime")
                        .WithMany()
                        .HasForeignKey("BestWorkTimeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCore.Domain.Models.Occupation", "Occupation")
                        .WithMany("BestWorkTimes")
                        .HasForeignKey("OccupationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCore.Domain.Models.OccupationWorkAvailability", b =>
                {
                    b.HasOne("DemoCore.Domain.Models.Occupation", "Occupation")
                        .WithMany("WorkAvailabilities")
                        .HasForeignKey("OccupationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCore.Domain.Models.WorkAvailability", "WorkAvailability")
                        .WithMany()
                        .HasForeignKey("WorkAvailabilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
