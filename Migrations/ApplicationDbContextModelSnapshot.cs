﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using recipeconfigurationservice.Data;
using System;

namespace recipeconfigurationservice.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("recipeconfigurationservice.Model.Extract", b =>
                {
                    b.Property<long>("extractId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description")
                        .HasMaxLength(200);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("extractId");

                    b.ToTable("Extracts");
                });

            modelBuilder.Entity("recipeconfigurationservice.Model.ExtractConfiguration", b =>
                {
                    b.Property<long>("extractConfigurationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("commandSQL");

                    b.Property<string>("description")
                        .HasMaxLength(200);

                    b.Property<string>("endPoint");

                    b.Property<long?>("extractId");

                    b.Property<string>("method");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("stringConection");

                    b.Property<string>("type")
                        .IsRequired();

                    b.HasKey("extractConfigurationId");

                    b.HasIndex("extractId");

                    b.ToTable("ExtractConfigurations");
                });

            modelBuilder.Entity("recipeconfigurationservice.Model.ExtractInParameter", b =>
                {
                    b.Property<long>("extractInParameterId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("extractConfigurationId");

                    b.Property<string>("path");

                    b.Property<string>("type")
                        .IsRequired();

                    b.Property<string>("value");

                    b.HasKey("extractInParameterId");

                    b.HasIndex("extractConfigurationId");

                    b.ToTable("ExtractInParameters");
                });

            modelBuilder.Entity("recipeconfigurationservice.Model.ExtractOutParameter", b =>
                {
                    b.Property<long>("extractOutParameterId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("extractConfigurationId");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("path");

                    b.Property<string>("value");

                    b.HasKey("extractOutParameterId");

                    b.HasIndex("extractConfigurationId");

                    b.ToTable("ExtractOutParameters");
                });

            modelBuilder.Entity("recipeconfigurationservice.Model.ExtractConfiguration", b =>
                {
                    b.HasOne("recipeconfigurationservice.Model.Extract")
                        .WithMany("extractConfiguration")
                        .HasForeignKey("extractId");
                });

            modelBuilder.Entity("recipeconfigurationservice.Model.ExtractInParameter", b =>
                {
                    b.HasOne("recipeconfigurationservice.Model.ExtractConfiguration")
                        .WithMany("parameterIn")
                        .HasForeignKey("extractConfigurationId");
                });

            modelBuilder.Entity("recipeconfigurationservice.Model.ExtractOutParameter", b =>
                {
                    b.HasOne("recipeconfigurationservice.Model.ExtractConfiguration")
                        .WithMany("parameterOut")
                        .HasForeignKey("extractConfigurationId");
                });
#pragma warning restore 612, 618
        }
    }
}
