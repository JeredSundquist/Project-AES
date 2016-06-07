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

        public DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<AppliedPosition> AppliedPositions { get; set; }
        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<JobHistory> JobHistories { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionRequest> PositionRequests { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.PhoneNumber)
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
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerName)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerFromDate)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerToDate)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerPosition)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerStartSalary)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MostRecentEmployerEndSalary)
                .IsUnicode(false);

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
                .Property(e => e.MiddleRecentEmployerFromDate)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerToDate)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerPosition)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerStartSalary)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.MiddleRecentEmployerEndSalary)
                .IsUnicode(false);

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
                .Property(e => e.LeastRecentEmployerFromDate)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerToDate)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerPosition)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerStartSalary)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.LeastRecentEmployerEndSalary)
                .IsUnicode(false);

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
                .Property(e => e.Reference1Phone)
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
                .Property(e => e.Reference2Phone)
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
                .Property(e => e.Reference3Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.Reference3Company)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.Reference3Title)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.HiringManagerNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Application)
                .HasForeignKey(e => e.FK_ApplicationId);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasOptional(e => e.UserPermission)
                .WithRequired(e => e.AspNetUser);

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

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.QuestionText)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.QuestionType)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.MC_AnswerText1)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.MC_AnswerText2)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.MC_AnswerText3)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.MC_AnswerText4)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.MC_AnswerText5)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.WI_Answer)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.CorrectAnswer)
                .IsUnicode(false);

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
                .Property(e => e.TestName)
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

            ModelCreating(modelBuilder);
        }

        partial void ModelCreating(DbModelBuilder modelBuilder);
    }
}
