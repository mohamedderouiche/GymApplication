﻿//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using GymApplication.Repository.Models;

//namespace GymApplication.Repository
//{
//    public partial class GymDbContext : DbContext
//    {
//        public GymDbContext()
//        {
//        }

//        public GymDbContext(DbContextOptions<GymDbContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Abonnement> Abonnements { get; set; } = null!;
//        public virtual DbSet<Cour> Cours { get; set; } = null!;
//        public virtual DbSet<Evenement> Evenements { get; set; } = null!;
//        public virtual DbSet<Paiement> Paiements { get; set; } = null!;
//        public virtual DbSet<Contact> Contacts { get; set; } = null!;
//        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                var connectionString = "Server=bocmacg43pnigkdh0iwj-mysql.services.clever-cloud.com;Database=bocmacg43pnigkdh0iwj;User=ukj0ay3tvltyuppg;Password=U6RKSgKTjasfZQofwREM;";
//                var serverVersion = ServerVersion.AutoDetect(connectionString); // Détection automatique de la version
//                optionsBuilder.UseMySql(connectionString, serverVersion); // Utilisation de MySQL
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Abonnement>(entity =>
//            {
//                entity.HasKey(e => e.IdAbonnement).HasName("PK__Abonnement");

//                entity.Property(e => e.CreatedAt)
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.UpdatedAt)
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
//            });

//            modelBuilder.Entity<Cour>(entity =>
//            {
//                entity.HasKey(e => e.IdCours).HasName("PK__Cours");
//            });

//            modelBuilder.Entity<Evenement>(entity =>
//            {
//                entity.HasKey(e => e.IdEvenement).HasName("PK__Evenement");

//                entity.Property(e => e.CreatedAt)
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.UpdatedAt)
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
//            });

//            modelBuilder.Entity<Paiement>(entity =>
//            {
//                entity.HasKey(e => e.IdPaiement).HasName("PK__Paiement");

//                entity.Property(e => e.CreatedAt)
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.UpdatedAt)
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//     entity.Property(p => p.Prixabonnement)
//    .HasColumnType("decimal(18,2)"); // Adjust precision and scale as necessary

//            });

//            modelBuilder.Entity<Utilisateur>(entity =>
//            {
//                entity.HasKey(e => e.IdUtilisateur).HasName("PK__Utilisateur");

//                entity.Property(e => e.CreatedAt)
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.UpdatedAt)
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}

using System;
using Microsoft.EntityFrameworkCore;
using GymApplication.Repository.Models;

namespace GymApplication.Repository
{
    public partial class GymDbContext : DbContext
    {
        public GymDbContext()
        {
        }

        public GymDbContext(DbContextOptions<GymDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abonnement> Abonnements { get; set; } = null!;
        public virtual DbSet<Cour> Cours { get; set; } = null!;
        public virtual DbSet<Evenement> Evenements { get; set; } = null!;
        public virtual DbSet<Paiement> Paiements { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=bocmacg43pnigkdh0iwj-mysql.services.clever-cloud.com;Database=bocmacg43pnigkdh0iwj;User=ukj0ay3tvltyuppg;Password=U6RKSgKTjasfZQofwREM;";
                var serverVersion = ServerVersion.AutoDetect(connectionString); // Auto-detect MySQL version
                optionsBuilder.UseMySql(connectionString, serverVersion); // Use MySQL
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abonnement>(entity =>
            {
                entity.HasKey(e => e.IdAbonnement).HasName("PK_Abonnement");

                entity.Property(e => e.CreatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Cour>(entity =>
            {
                entity.HasKey(e => e.IdCours).HasName("PK_Cours");
                // Add any other property configurations for Cour if needed
            });

            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.HasKey(e => e.IdEvenement).HasName("PK_Evenement");

                entity.Property(e => e.CreatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Paiement>(entity =>
            {
                entity.HasKey(e => e.IdPaiement).HasName("PK_Paiement");

                entity.Property(e => e.CreatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                // Setting the decimal column type for Prixabonnement
                entity.Property(p => p.Prixabonnement)
                    .HasColumnType("decimal(18,2)"); // Adjust precision and scale as necessary
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.IdUtilisateur).HasName("PK_Utilisateur");

                entity.Property(e => e.CreatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
