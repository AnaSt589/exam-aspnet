﻿using System.Threading;
using System.Threading.Tasks;
using Exam.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam.Application.Common.Interfaces
{
    public interface IFilmsDbContext
    {
        DbSet<Actor> Actors { get; set; }
        DbSet<ActorsFilms> ActorsFilms { get; set; }
        DbSet<ActorPhoto> ActorPhotos { get; set; }
        DbSet<Film> Films { get; set; }
        DbSet<FilmsGenres> FilmsGenres { get; set; }
        DbSet<FilmPhoto> FilmPhotos { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Voting> Voting { get; set; }
        DbSet<VotingAnswer> VotingAnswers { get; set; }
        DbSet<VotingPolle> VotingPolle { get; set; }
        DbSet<VotingPolleRelation> VotingPolles { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}