










namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AESEntitiesModel : DbContext
    {
        static AESEntitiesModel()
        {
            Database.SetInitializer(new NullDatabaseInitializer<AESEntitiesModel>());
        }

        public AESEntitiesModel()
            : base("name=AESEntitiesModel")
        {
            Configuration.ProxyCreationEnabled = false;
        }


        public DbSet<C__RefactorLog> C__RefactorLog { get; set; }

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

        public DbSet<UserPermission> UserPermissions { get; set; }


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
                .Property(e => e.OtherName)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Email)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.PositionsApplied)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.SalaryExpectation)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerName)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerAddress)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerSupervisor)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerPosition)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerStartSalary)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerEndSalary)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerReasonForLeaving)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerResponsibilities)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerName)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerAddress)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerSupervisor)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerPosition)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerStartSalary)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerEndSalary)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerReasonForLeaving)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerResponsibilities)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerName)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerAddress)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerSupervisor)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerPosition)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerStartSalary)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerEndSalary)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerReasonForLeaving)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerResponsibilities)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEducationName)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEducationYearsAttended)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEducationDegreeMajor)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEducationName)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEducationYearsAttended)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEducationDegreeMajor)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEducationName)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEducationYearsAttended)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEducationDegreeMajor)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Reference1Name)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Reference1Company)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Reference1Title)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Reference2Name)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Reference2Company)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Reference2Title)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Reference3Name)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Reference3Company)
                .IsUnicode(false);


            modelBuilder.Entity<Application>()
                .Property(e => e.Reference3Title)
                .IsUnicode(false);


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


            modelBuilder.Entity<Test>()
                .Property(e => e.QuestionList)
                .IsUnicode(false);


            modelBuilder.Entity<Test>()
                .Property(e => e.QuestionName)
                .IsUnicode(false);


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
                .Property(e => e.Address)
                .IsUnicode(false);


            modelBuilder.Entity<User>()
                .HasOptional(e => e.UserPermission)
                .WithRequired(e => e.User);


            ModelCreating(modelBuilder);
        }

        partial void ModelCreating(DbModelBuilder modelBuilder);
    }
}
