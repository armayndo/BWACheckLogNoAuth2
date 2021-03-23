﻿// <auto-generated />
using System;
using BWACheckLogNoAuth.Server.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BWACheckLogNoAuth.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210323032253_updateColResponseTime")]
    partial class updateColResponseTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BWACheckLogNoAuth.Shared.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeId");

                    b.ToTable("tblRecipe");
                });

            modelBuilder.Entity("BWACheckLogNoAuth.Shared.Models.ResponseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponseTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserResponseGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserResponseGuid");

                    b.ToTable("ResponseDetails");
                });

            modelBuilder.Entity("BWACheckLogNoAuth.Shared.Models.SurveyAnswer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NextQuestion")
                        .HasColumnType("int");

                    b.Property<int>("SurveyQuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SurveyQuestionId");

                    b.ToTable("SurveyAnswers");
                });

            modelBuilder.Entity("BWACheckLogNoAuth.Shared.Models.SurveyQuestion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveyQuestions");
                });

            modelBuilder.Entity("BWACheckLogNoAuth.Shared.Models.UserResponse", b =>
                {
                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateSubmit")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("UserResponses");
                });

            modelBuilder.Entity("BWACheckLogNoAuth.Shared.Models.ResponseDetail", b =>
                {
                    b.HasOne("BWACheckLogNoAuth.Shared.Models.UserResponse", "UserResponse")
                        .WithMany("ResponseDetails")
                        .HasForeignKey("UserResponseGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BWACheckLogNoAuth.Shared.Models.SurveyAnswer", b =>
                {
                    b.HasOne("BWACheckLogNoAuth.Shared.Models.SurveyQuestion", "SurveyQuestion")
                        .WithMany("SurveyAnswers")
                        .HasForeignKey("SurveyQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
