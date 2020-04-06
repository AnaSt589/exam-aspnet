﻿// <auto-generated />
using System;
using Exam.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exam.Persistence.Migrations
{
    [DbContext(typeof(FilmsDbContext))]
    [Migration("20200406140610_Voting")]
    partial class Voting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exam.Domain.Entities.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(54)")
                        .HasMaxLength(54);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(54)")
                        .HasMaxLength(54);

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Exam.Domain.Entities.ActorPhoto", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.HasKey("PhotoId");

                    b.HasIndex("ActorId");

                    b.HasIndex("Path")
                        .IsUnique()
                        .HasName("UNQ_ActorsPhotos_Path");

                    b.ToTable("ActorPhotos");
                });

            modelBuilder.Entity("Exam.Domain.Entities.ActorsFilms", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("ActorsFilms");
                });

            modelBuilder.Entity("Exam.Domain.Entities.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<DateTime>("PublishYear")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("FilmId");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasName("UNQ_Films_Title");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Exam.Domain.Entities.FilmPhoto", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.HasKey("PhotoId");

                    b.HasIndex("FilmId");

                    b.HasIndex("Path")
                        .IsUnique()
                        .HasName("UNQ_FilmsPhotos_Path");

                    b.ToTable("FilmPhotos");
                });

            modelBuilder.Entity("Exam.Domain.Entities.FilmsGenres", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("FilmId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("FilmsGenres");
                });

            modelBuilder.Entity("Exam.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("GenreId");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasName("UNQ_Genres_Title")
                        .HasFilter("[Title] IS NOT NULL");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Exam.Domain.Entities.Voting", b =>
                {
                    b.Property<int>("VotingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.HasKey("VotingId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UNQ_Voting_Name");

                    b.ToTable("Voting");
                });

            modelBuilder.Entity("Exam.Domain.Entities.VotingAnswers", b =>
                {
                    b.Property<int>("VotingAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<int>("VotingId")
                        .HasColumnType("int");

                    b.HasKey("VotingAnswerId");

                    b.HasIndex("VotingId");

                    b.ToTable("VotingAnswers");
                });

            modelBuilder.Entity("Exam.Domain.Entities.VotingPolle", b =>
                {
                    b.Property<int>("VotingPolleId")
                        .HasColumnType("int");

                    b.HasKey("VotingPolleId");

                    b.ToTable("VotingPolle");
                });

            modelBuilder.Entity("Exam.Domain.Entities.VotingPolles", b =>
                {
                    b.Property<int>("VotingPolleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PolleId")
                        .HasColumnType("int");

                    b.Property<int>("VotingAnswerId")
                        .HasColumnType("int");

                    b.Property<int>("VotingId")
                        .HasColumnType("int");

                    b.HasKey("VotingPolleId");

                    b.HasIndex("PolleId");

                    b.HasIndex("VotingAnswerId");

                    b.HasIndex("VotingId");

                    b.ToTable("VotingPolles");
                });

            modelBuilder.Entity("Exam.Domain.Entities.ActorPhoto", b =>
                {
                    b.HasOne("Exam.Domain.Entities.Actor", "Actor")
                        .WithMany("ActorsPhotos")
                        .HasForeignKey("ActorId")
                        .HasConstraintName("FK_ActorsPhotos_ActorId")
                        .IsRequired();
                });

            modelBuilder.Entity("Exam.Domain.Entities.ActorsFilms", b =>
                {
                    b.HasOne("Exam.Domain.Entities.Actor", "Actor")
                        .WithMany("ActorsFilms")
                        .HasForeignKey("ActorId")
                        .HasConstraintName("FK_ActorsFilms_ActorId")
                        .IsRequired();

                    b.HasOne("Exam.Domain.Entities.Film", "Film")
                        .WithMany("ActorFilms")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK_ActorsFilms_FilmId")
                        .IsRequired();
                });

            modelBuilder.Entity("Exam.Domain.Entities.FilmPhoto", b =>
                {
                    b.HasOne("Exam.Domain.Entities.Film", "Film")
                        .WithMany("FilmsPhotos")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK_FilmsPhotos_FilmId")
                        .IsRequired();
                });

            modelBuilder.Entity("Exam.Domain.Entities.FilmsGenres", b =>
                {
                    b.HasOne("Exam.Domain.Entities.Film", "Film")
                        .WithMany("FilmGenres")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK_FilmsGenres_FilmId")
                        .IsRequired();

                    b.HasOne("Exam.Domain.Entities.Genre", "Genre")
                        .WithMany("FilmsGenres")
                        .HasForeignKey("GenreId")
                        .HasConstraintName("FK_FilmsGenres_GenreId")
                        .IsRequired();
                });

            modelBuilder.Entity("Exam.Domain.Entities.VotingAnswers", b =>
                {
                    b.HasOne("Exam.Domain.Entities.Voting", "Voting")
                        .WithMany("VotingAnswers")
                        .HasForeignKey("VotingId")
                        .HasConstraintName("FK_VotingAnswers_VotingId")
                        .IsRequired();
                });

            modelBuilder.Entity("Exam.Domain.Entities.VotingPolles", b =>
                {
                    b.HasOne("Exam.Domain.Entities.VotingPolle", "Polle")
                        .WithMany("VotingPolles")
                        .HasForeignKey("PolleId")
                        .HasConstraintName("FK_VotingPolles_PolleId")
                        .IsRequired();

                    b.HasOne("Exam.Domain.Entities.VotingAnswers", "VotingAnswer")
                        .WithMany("VotingPolles")
                        .HasForeignKey("VotingAnswerId")
                        .HasConstraintName("FK_VotingPolles_VotingAnswerId")
                        .IsRequired();

                    b.HasOne("Exam.Domain.Entities.Voting", "Voting")
                        .WithMany("VotingPolles")
                        .HasForeignKey("VotingId")
                        .HasConstraintName("FK_VotingPolles_VotingId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
