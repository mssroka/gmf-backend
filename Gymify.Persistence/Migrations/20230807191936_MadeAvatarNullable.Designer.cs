﻿// <auto-generated />
using System;
using Gymify.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gymify.Persistence.Migrations
{
    [DbContext(typeof(GymifyDbContext))]
    [Migration("20230807191936_MadeAvatarNullable")]
    partial class MadeAvatarNullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientGroupSession", b =>
                {
                    b.Property<Guid>("IdGroupSession")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdClient")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdGroupSession", "IdClient")
                        .HasName("ClientGroupSession_pk");

                    b.HasIndex("IdClient");

                    b.ToTable("ClientGroupSession", (string)null);
                });

            modelBuilder.Entity("CoachType", b =>
                {
                    b.Property<Guid>("IdCoachCategory")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCoach")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdCoachCategory", "IdCoach")
                        .HasName("CoachType_pk");

                    b.HasIndex("IdCoach");

                    b.ToTable("CoachType", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.AspNetUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("RefreshTokenExpiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.BodyPart", b =>
                {
                    b.Property<Guid>("BodyPartUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BodyPartName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.HasKey("BodyPartUid")
                        .HasName("BodyPart_pk");

                    b.ToTable("BodyPart", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Client", b =>
                {
                    b.Property<Guid>("ClientUid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClientUid")
                        .HasName("Client_pk");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Coach", b =>
                {
                    b.Property<Guid>("CoachUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.HasKey("CoachUid")
                        .HasName("Coach_pk");

                    b.ToTable("Coach", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.CoachCategory", b =>
                {
                    b.Property<Guid>("CoachCategoryUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CoachCategoryName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)");

                    b.HasKey("CoachCategoryUid")
                        .HasName("CoachCategory_pk");

                    b.ToTable("CoachCategory", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.CoachHour", b =>
                {
                    b.Property<Guid>("CoachHourUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClientUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoachUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.HasKey("CoachHourUid")
                        .HasName("CoachHour_pk");

                    b.HasIndex("ClientUid");

                    b.HasIndex("CoachUid");

                    b.ToTable("CoachHour", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.DifficultyLevel", b =>
                {
                    b.Property<Guid>("DifficultyLevelUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DifficultyLevelName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)");

                    b.HasKey("DifficultyLevelUid")
                        .HasName("DifficultyLevel_pk");

                    b.ToTable("DifficultyLevel", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Equipment", b =>
                {
                    b.Property<Guid>("EquipmentUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EquipmentName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.HasKey("EquipmentUid")
                        .HasName("Equipment_pk");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Exercise", b =>
                {
                    b.Property<Guid>("ExerciseUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BodyPartUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EquipmentUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("GifUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<Guid>("TargetUid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExerciseUid")
                        .HasName("Exercise_pk");

                    b.HasIndex("BodyPartUid");

                    b.HasIndex("EquipmentUid");

                    b.HasIndex("TargetUid");

                    b.ToTable("Exercise", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.FavouriteCoach", b =>
                {
                    b.Property<Guid>("FavouriteCoachUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoachUid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FavouriteCoachUid", "ClientUid", "CoachUid")
                        .HasName("FavouriteCoach_pk");

                    b.HasIndex("ClientUid");

                    b.HasIndex("CoachUid");

                    b.ToTable("FavouriteCoach", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.FavouriteExercise", b =>
                {
                    b.Property<Guid>("FavouriteExerciseUid")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FavouriteExercise");

                    b.Property<Guid>("UserUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExerciseUid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FavouriteExerciseUid", "UserUid", "ExerciseUid")
                        .HasName("FavouriteExercise_pk");

                    b.HasIndex("ExerciseUid");

                    b.HasIndex("UserUid");

                    b.ToTable("FavouriteExercise", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.GroupSession", b =>
                {
                    b.Property<Guid>("GroupSessionUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoachUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<Guid>("PlaceUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SessionEndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("SessionName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("SessionStartDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Slots")
                        .HasColumnType("int");

                    b.HasKey("GroupSessionUid")
                        .HasName("GroupSession_pk");

                    b.HasIndex("CoachUid");

                    b.HasIndex("PlaceUid");

                    b.ToTable("GroupSession", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Place", b =>
                {
                    b.Property<Guid>("PlaceUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("PlaceName");

                    b.HasKey("PlaceUid")
                        .HasName("Place_pk");

                    b.ToTable("Place", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Target", b =>
                {
                    b.Property<Guid>("TargetUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TargetName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.HasKey("TargetUid")
                        .HasName("Target_pk");

                    b.ToTable("Target", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Template", b =>
                {
                    b.Property<Guid>("TemplateUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DifficultyLevelUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("EstimatedTime")
                        .HasColumnType("numeric(3, 0)");

                    b.Property<bool>("IsShared")
                        .HasColumnType("bit");

                    b.Property<string>("TemplateName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.HasKey("TemplateUid")
                        .HasName("Template_pk");

                    b.HasIndex("DifficultyLevelUid");

                    b.ToTable("Template", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.TemplateExercise", b =>
                {
                    b.Property<Guid>("TemplateExerciseUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExerciseUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TemplateUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("NumberOfReps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfSets")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TemplateExerciseUid", "ExerciseUid", "TemplateUid")
                        .HasName("TemplateExercise_pk");

                    b.HasIndex("ExerciseUid");

                    b.HasIndex("TemplateUid");

                    b.ToTable("TemplateExercise", (string)null);
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Training", b =>
                {
                    b.Property<Guid>("TrainingUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TemplateUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TrainingDate")
                        .HasColumnType("date");

                    b.Property<string>("TrainingName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.HasKey("TrainingUid")
                        .HasName("Training_pk");

                    b.HasIndex("TemplateUid");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.UserTraining", b =>
                {
                    b.Property<Guid>("UserTrainingUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TrainingUid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserTrainingUid", "UserUid", "TrainingUid")
                        .HasName("UserTraining_pk");

                    b.HasIndex("TrainingUid");

                    b.HasIndex("UserUid");

                    b.ToTable("UserTraining", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ClientGroupSession", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.Client", null)
                        .WithMany()
                        .HasForeignKey("IdClient")
                        .IsRequired()
                        .HasConstraintName("ClientGroupSession_Client");

                    b.HasOne("Gymify.Domain.Entities.GroupSession", null)
                        .WithMany()
                        .HasForeignKey("IdGroupSession")
                        .IsRequired()
                        .HasConstraintName("ClientGroupSession_GroupSession");
                });

            modelBuilder.Entity("CoachType", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.Coach", null)
                        .WithMany()
                        .HasForeignKey("IdCoach")
                        .IsRequired()
                        .HasConstraintName("CoachType_Coach");

                    b.HasOne("Gymify.Domain.Entities.CoachCategory", null)
                        .WithMany()
                        .HasForeignKey("IdCoachCategory")
                        .IsRequired()
                        .HasConstraintName("CoachType_CoachCategory");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Client", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.AspNetUser", "User")
                        .WithOne("Client")
                        .HasForeignKey("Gymify.Domain.Entities.Client", "ClientUid")
                        .IsRequired()
                        .HasConstraintName("Client_AspNetUsers");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Coach", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.AspNetUser", "User")
                        .WithOne("Coach")
                        .HasForeignKey("Gymify.Domain.Entities.Coach", "CoachUid")
                        .IsRequired()
                        .HasConstraintName("Coach_AspNetUsers");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.CoachHour", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.Client", "Client")
                        .WithMany("CoachHours")
                        .HasForeignKey("ClientUid")
                        .HasConstraintName("CoachHour_Client");

                    b.HasOne("Gymify.Domain.Entities.Coach", "Coach")
                        .WithMany("CoachHours")
                        .HasForeignKey("CoachUid")
                        .IsRequired()
                        .HasConstraintName("CoachHour_Coach");

                    b.Navigation("Client");

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Exercise", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.BodyPart", "BodyPart")
                        .WithMany("Exercises")
                        .HasForeignKey("BodyPartUid")
                        .IsRequired()
                        .HasConstraintName("Exercise_BodyPart");

                    b.HasOne("Gymify.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Exercises")
                        .HasForeignKey("EquipmentUid")
                        .IsRequired()
                        .HasConstraintName("Exercise_Equipment");

                    b.HasOne("Gymify.Domain.Entities.Target", "Target")
                        .WithMany("Exercises")
                        .HasForeignKey("TargetUid")
                        .IsRequired()
                        .HasConstraintName("Exercise_Target");

                    b.Navigation("BodyPart");

                    b.Navigation("Equipment");

                    b.Navigation("Target");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.FavouriteCoach", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.Client", "Client")
                        .WithMany("FavouriteCoaches")
                        .HasForeignKey("ClientUid")
                        .IsRequired()
                        .HasConstraintName("FavouriteCoach_Client");

                    b.HasOne("Gymify.Domain.Entities.Coach", "Coach")
                        .WithMany("FavouriteCoaches")
                        .HasForeignKey("CoachUid")
                        .IsRequired()
                        .HasConstraintName("FavouriteCoach_Coach");

                    b.Navigation("Client");

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.FavouriteExercise", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.Exercise", "Exercise")
                        .WithMany("FavouriteExercises")
                        .HasForeignKey("ExerciseUid")
                        .IsRequired()
                        .HasConstraintName("UserExercise_Exercise");

                    b.HasOne("Gymify.Domain.Entities.AspNetUser", "User")
                        .WithMany("FavouriteExercises")
                        .HasForeignKey("UserUid")
                        .IsRequired()
                        .HasConstraintName("FavouriteExercise_AspNetUsers");

                    b.Navigation("Exercise");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.GroupSession", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.Coach", "Coach")
                        .WithMany("GroupSessions")
                        .HasForeignKey("CoachUid")
                        .IsRequired()
                        .HasConstraintName("GroupSession_Coach");

                    b.HasOne("Gymify.Domain.Entities.Place", "Place")
                        .WithMany("GroupSessions")
                        .HasForeignKey("PlaceUid")
                        .IsRequired()
                        .HasConstraintName("GroupSession_Place");

                    b.Navigation("Coach");

                    b.Navigation("Place");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Template", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.DifficultyLevel", "DifficultyLevel")
                        .WithMany("Templates")
                        .HasForeignKey("DifficultyLevelUid")
                        .IsRequired()
                        .HasConstraintName("Template_DifficultyLevel");

                    b.Navigation("DifficultyLevel");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.TemplateExercise", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.Exercise", "Exercise")
                        .WithMany("TemplateExercises")
                        .HasForeignKey("ExerciseUid")
                        .IsRequired()
                        .HasConstraintName("TemplateExercise_Exercise");

                    b.HasOne("Gymify.Domain.Entities.Template", "Template")
                        .WithMany("TemplateExercises")
                        .HasForeignKey("TemplateUid")
                        .IsRequired()
                        .HasConstraintName("TemplateExercise_Template");

                    b.Navigation("Exercise");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Training", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.Template", "Template")
                        .WithMany("Training")
                        .HasForeignKey("TemplateUid")
                        .IsRequired()
                        .HasConstraintName("Training_Template");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.UserTraining", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.Training", "Training")
                        .WithMany("UserTrainings")
                        .HasForeignKey("TrainingUid")
                        .IsRequired()
                        .HasConstraintName("UserTraining_Training");

                    b.HasOne("Gymify.Domain.Entities.AspNetUser", "User")
                        .WithMany("UserTrainings")
                        .HasForeignKey("UserUid")
                        .IsRequired()
                        .HasConstraintName("UserTraining_AspNetUsers");

                    b.Navigation("Training");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gymify.Domain.Entities.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Gymify.Domain.Entities.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gymify.Domain.Entities.AspNetUser", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("Coach");

                    b.Navigation("FavouriteExercises");

                    b.Navigation("UserTrainings");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.BodyPart", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Client", b =>
                {
                    b.Navigation("CoachHours");

                    b.Navigation("FavouriteCoaches");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Coach", b =>
                {
                    b.Navigation("CoachHours");

                    b.Navigation("FavouriteCoaches");

                    b.Navigation("GroupSessions");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.DifficultyLevel", b =>
                {
                    b.Navigation("Templates");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Equipment", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Exercise", b =>
                {
                    b.Navigation("FavouriteExercises");

                    b.Navigation("TemplateExercises");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Place", b =>
                {
                    b.Navigation("GroupSessions");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Target", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Template", b =>
                {
                    b.Navigation("TemplateExercises");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("Gymify.Domain.Entities.Training", b =>
                {
                    b.Navigation("UserTrainings");
                });
#pragma warning restore 612, 618
        }
    }
}
