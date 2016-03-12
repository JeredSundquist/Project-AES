namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AESEnititiesModel : DbContext
    {
        static AESEnititiesModel()
        {
            Database.SetInitializer(new NullDatabaseInitializer<AESEnititiesModel>());
        }

        public AESEnititiesModel()
            : base("name=AESEnititiesModel")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<AppliedPosition> AppliedPositions { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<JobHistory> JobHistories { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .Property(e => e.CorrectAnswer)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.PositionsApplied)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.SalaryExpectation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Education>()
                .Property(e => e.SchoolName)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.SchoolAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.DegreeMajor)
                .IsUnicode(false);

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.Employer)
                .IsUnicode(false);

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.EmpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.JobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.ReasonLeaving)
                .IsUnicode(false);

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.StartingSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.Responsibilities)
                .IsUnicode(false);

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.EndingSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Position>()
                .Property(e => e.PositionName)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.PositionDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.AppliedPositions)
                .WithRequired(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Question1)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.QuestionText)
                .IsFixedLength();

            modelBuilder.Entity<Reference>()
                .Property(e => e.ReferenceName)
                .IsUnicode(false);

            modelBuilder.Entity<Reference>()
                .Property(e => e.ReferenceCompany)
                .IsUnicode(false);

            modelBuilder.Entity<Reference>()
                .Property(e => e.ReferenceTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StoreLocation)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Positions)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.QuestionList)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Positions)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.address)
                .IsUnicode(false);

            ModelCreating(modelBuilder);
        }

        partial void ModelCreating(DbModelBuilder modelBuilder);
    }
}
