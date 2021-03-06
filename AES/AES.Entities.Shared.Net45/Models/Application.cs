namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TrackableEntities.Client;

    [Table("Application")]
    public partial class Application : EntityBase
    {
        public Application()
        {
            Users = new ChangeTrackingCollection<User>();
        }

        public int ApplicationId
        {
            get { return _ApplicationId; }
            set
            {
                if (Equals(value, _ApplicationId)) return;
                _ApplicationId = value;
                NotifyPropertyChanged();
            }
        }
        private int _ApplicationId;

        [StringLength(50)]
        public string Name
        {
            get { return _Name; }
            set
            {
                if (Equals(value, _Name)) return;
                _Name = value;
                NotifyPropertyChanged();
            }
        }
        private string _Name;

        [StringLength(13)]
        [Required(ErrorMessage = "SSN is Required")]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        public string SSN
        {
            get { return _SSN; }
            set
            {
                if (Equals(value, _SSN)) return;
                _SSN = value;
                NotifyPropertyChanged();
            }
        }
        private string _SSN;

        [StringLength(50)]
        public string Address
        {
            get { return _Address; }
            set
            {
                if (Equals(value, _Address)) return;
                _Address = value;
                NotifyPropertyChanged();
            }
        }
        private string _Address;

        [StringLength(16)]
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set
            {
                if (Equals(value, _PhoneNumber)) return;
                _PhoneNumber = value;
                NotifyPropertyChanged();
            }
        }
        private string _PhoneNumber;

        [StringLength(50)]
        public string OtherName
        {
            get { return _OtherName; }
            set
            {
                if (Equals(value, _OtherName)) return;
                _OtherName = value;
                NotifyPropertyChanged();
            }
        }
        private string _OtherName;

        [StringLength(50)]
        [Required(ErrorMessage = "Your must provide an Email Address")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email
        {
            get { return _Email; }
            set
            {
                if (Equals(value, _Email)) return;
                _Email = value;
                NotifyPropertyChanged();
            }
        }
        private string _Email;

        [StringLength(50)]
        public string PositionsApplied
        {
            get { return _PositionsApplied; }
            set
            {
                if (Equals(value, _PositionsApplied)) return;
                _PositionsApplied = value;
                NotifyPropertyChanged();
            }
        }
        private string _PositionsApplied;

        public int PositionId
        {
            get { return _PositionId; }
            set
            {
                if (Equals(value, _PositionId)) return;
                _PositionId = value;
                NotifyPropertyChanged();
            }
        }
        private int _PositionId;

        [StringLength(16)]
        [Display(Name="Salary Expectation")]
        public string SalaryExpectation
        {
            get { return _SalaryExpectation; }
            set
            {
                if (Equals(value, _SalaryExpectation)) return;
                _SalaryExpectation = value;
                NotifyPropertyChanged();
            }
        }
        private string _SalaryExpectation;

        public bool FullTime
        {
            get { return _FullTime; }
            set
            {
                if (Equals(value, _FullTime)) return;
                _FullTime = value;
                NotifyPropertyChanged();
            }
        }
        private bool _FullTime;

        public bool PartTime
        {
            get { return _PartTime; }
            set
            {
                if (Equals(value, _PartTime)) return;
                _PartTime = value;
                NotifyPropertyChanged();
            }
        }
        private bool _PartTime;

        public bool Days
        {
            get { return _Days; }
            set
            {
                if (Equals(value, _Days)) return;
                _Days = value;
                NotifyPropertyChanged();
            }
        }
        private bool _Days;

        public bool Evenings
        {
            get { return _Evenings; }
            set
            {
                if (Equals(value, _Evenings)) return;
                _Evenings = value;
                NotifyPropertyChanged();
            }
        }
        private bool _Evenings;

        public bool Weekends
        {
            get { return _Weekends; }
            set
            {
                if (Equals(value, _Weekends)) return;
                _Weekends = value;
                NotifyPropertyChanged();
            }
        }
        private bool _Weekends;

        [Display(Name = "Monday")]
        public bool MondayAvailable
        {
            get { return _MondayAvailable; }
            set
            {
                if (Equals(value, _MondayAvailable)) return;
                _MondayAvailable = value;
                NotifyPropertyChanged();
            }
        }
        private bool _MondayAvailable;

        [Display(Name = "Tuesday")]
        public bool TuesdayAvailable
        {
            get { return _TuesdayAvailable; }
            set
            {
                if (Equals(value, _TuesdayAvailable)) return;
                _TuesdayAvailable = value;
                NotifyPropertyChanged();
            }
        }
        private bool _TuesdayAvailable;

        [Display(Name = "Wednesday")]
        public bool WednesdayAvailable
        {
            get { return _WednesdayAvailable; }
            set
            {
                if (Equals(value, _WednesdayAvailable)) return;
                _WednesdayAvailable = value;
                NotifyPropertyChanged();
            }
        }      
        private bool _WednesdayAvailable;

        [Display(Name = "Thursday")]
        public bool ThursdayAvailable
        {
            get { return _ThursdayAvailable; }
            set
            {
                if (Equals(value, _ThursdayAvailable)) return;
                _ThursdayAvailable = value;
                NotifyPropertyChanged();
            }
        }
        private bool _ThursdayAvailable;

        [Display(Name = "Friday")]
        public bool FridayAvailable
        {
            get { return _FridayAvailable; }
            set
            {
                if (Equals(value, _FridayAvailable)) return;
                _FridayAvailable = value;
                NotifyPropertyChanged();
            }
        }
        private bool _FridayAvailable;

        [Display(Name = "Saturday")]
        public bool SaturdayAvailable
        {
            get { return _SaturdayAvailable; }
            set
            {
                if (Equals(value, _SaturdayAvailable)) return;
                _SaturdayAvailable = value;
                NotifyPropertyChanged();
            }
        }
        private bool _SaturdayAvailable;

        [Display(Name = "Sunday")]
        public bool SundayAvailable
        {
            get { return _SundayAvailable; }
            set
            {
                if (Equals(value, _SundayAvailable)) return;
                _SundayAvailable = value;
                NotifyPropertyChanged();
            }
        }
        private bool _SundayAvailable;
        // Recent Employer
        [StringLength(50)]
        [Display(Name = "Employer Name")]
        public string MostRecentEmployerName
        {
            get { return _MostRecentEmployerName; }
            set
            {
                if (Equals(value, _MostRecentEmployerName)) return;
                _MostRecentEmployerName = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerName;

        [StringLength(16)]
        [Display(Name = "Date from: ")]
        public string MostRecentEmployerFromDate
        {
            get { return _MostRecentEmployerFromDate; }
            set
            {
                if (Equals(value, _MostRecentEmployerFromDate)) return;
                _MostRecentEmployerFromDate = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerFromDate;

        [StringLength(16)]
        [Display(Name = "Date to: ")]
        public string MostRecentEmployerToDate
        {
            get { return _MostRecentEmployerToDate; }
            set
            {
                if (Equals(value, _MostRecentEmployerToDate)) return;
                _MostRecentEmployerToDate = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerToDate;

        [StringLength(50)]
        [Display(Name = "Employer Address")]
        public string MostRecentEmployerAddress
        {
            get { return _MostRecentEmployerAddress; }
            set
            {
                if (Equals(value, _MostRecentEmployerAddress)) return;
                _MostRecentEmployerAddress = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerAddress;

        [StringLength(16)]
        [Display(Name = "Employer Phone")]
        public string MostRecentEmployerPhone
        {
            get { return _MostRecentEmployerPhone; }
            set
            {
                if (Equals(value, _MostRecentEmployerPhone)) return;
                _MostRecentEmployerPhone = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerPhone;

        [StringLength(15)]
        [Display(Name = "Supervisor Name")]
        public string MostRecentEmployerSupervisor
        {
            get { return _MostRecentEmployerSupervisor; }
            set
            {
                if (Equals(value, _MostRecentEmployerSupervisor)) return;
                _MostRecentEmployerSupervisor = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerSupervisor;

        [StringLength(50)]
        [Display(Name = "Title")]
        public string MostRecentEmployerPosition
        {
            get { return _MostRecentEmployerPosition; }
            set
            {
                if (Equals(value, _MostRecentEmployerPosition)) return;
                _MostRecentEmployerPosition = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerPosition;

        [StringLength(16)]
        [Display(Name = "Starting Salary")]
        public string MostRecentEmployerStartSalary
        {
            get { return _MostRecentEmployerStartSalary; }
            set
            {
                if (Equals(value, _MostRecentEmployerStartSalary)) return;
                _MostRecentEmployerStartSalary = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerStartSalary;

        [StringLength(16)]
        [Display(Name = "End Salary")]
        public string MostRecentEmployerEndSalary
        {
            get { return _MostRecentEmployerEndSalary; }
            set
            {
                if (Equals(value, _MostRecentEmployerEndSalary)) return;
                _MostRecentEmployerEndSalary = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerEndSalary;

        [StringLength(80)]
        [Display(Name = "Reason for Leaving")]
        public string MostRecentEmployerReasonForLeaving
        {
            get { return _MostRecentEmployerReasonForLeaving; }
            set
            {
                if (Equals(value, _MostRecentEmployerReasonForLeaving)) return;
                _MostRecentEmployerReasonForLeaving = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerReasonForLeaving;

        [Display(Name = "Responsibilities")]
        public string MostRecentEmployerResponsibilities
        {
            get { return _MostRecentEmployerResponsibilities; }
            set
            {
                if (Equals(value, _MostRecentEmployerResponsibilities)) return;
                _MostRecentEmployerResponsibilities = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEmployerResponsibilities;
        // middle employer
        [StringLength(50)]
        [Display(Name = "Employer Name")]
        public string MiddleRecentEmployerName
        {
            get { return _MiddleRecentEmployerName; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerName)) return;
                _MiddleRecentEmployerName = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerName;

        [StringLength(16)]
        [Display(Name = "Date from: ")]
        public string MiddleRecentEmployerFromDate
        {
            get { return _MiddleRecentEmployerFromDate; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerFromDate)) return;
                _MiddleRecentEmployerFromDate = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerFromDate;

        [StringLength(16)]
        [Display(Name = "Date to: ")]
        public string MiddleRecentEmployerToDate
        {
            get { return _MiddleRecentEmployerToDate; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerToDate)) return;
                _MiddleRecentEmployerToDate = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerToDate;

        [StringLength(50)]
        [Display(Name = "Employer Address")]
        public string MiddleRecentEmployerAddress
        {
            get { return _MiddleRecentEmployerAddress; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerAddress)) return;
                _MiddleRecentEmployerAddress = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerAddress;

        [StringLength(16)]
        [Display(Name = "Employer Phone")]
        public string MiddleRecentEmployerPhone
        {
            get { return _MiddleRecentEmployerPhone; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerPhone)) return;
                _MiddleRecentEmployerPhone = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerPhone;

        [StringLength(20)]
        [Display(Name = "Supervisor Name")]
        public string MiddleRecentEmployerSupervisor
        {
            get { return _MiddleRecentEmployerSupervisor; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerSupervisor)) return;
                _MiddleRecentEmployerSupervisor = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerSupervisor;

        [StringLength(50)]
        [Display(Name = "Your Title")]
        public string MiddleRecentEmployerPosition
        {
            get { return _MiddleRecentEmployerPosition; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerPosition)) return;
                _MiddleRecentEmployerPosition = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerPosition;

        [StringLength(16)]
        [Display(Name = "Starting Salary")]
        public string MiddleRecentEmployerStartSalary
        {
            get { return _MiddleRecentEmployerStartSalary; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerStartSalary)) return;
                _MiddleRecentEmployerStartSalary = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerStartSalary;

        [StringLength(16)]
        [Display(Name = "Ending Salary")]
        public string MiddleRecentEmployerEndSalary
        {
            get { return _MiddleRecentEmployerEndSalary; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerEndSalary)) return;
                _MiddleRecentEmployerEndSalary = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerEndSalary;

        [StringLength(50)]
        [Display(Name = "Reason for leaving")]
        public string MiddleRecentEmployerReasonForLeaving
        {
            get { return _MiddleRecentEmployerReasonForLeaving; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerReasonForLeaving)) return;
                _MiddleRecentEmployerReasonForLeaving = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerReasonForLeaving;

        [Display(Name = "Responsibilities")]
        public string MiddleRecentEmployerResponsibilities
        {
            get { return _MiddleRecentEmployerResponsibilities; }
            set
            {
                if (Equals(value, _MiddleRecentEmployerResponsibilities)) return;
                _MiddleRecentEmployerResponsibilities = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEmployerResponsibilities;

        [StringLength(50)]
        [Display(Name = "Employer Name")]
        public string LeastRecentEmployerName
        {
            get { return _LeastRecentEmployerName; }
            set
            {
                if (Equals(value, _LeastRecentEmployerName)) return;
                _LeastRecentEmployerName = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerName;

        [StringLength(16)]
        [Display(Name = "Date from: ")]
        public string LeastRecentEmployerFromDate
        {
            get { return _LeastRecentEmployerFromDate; }
            set
            {
                if (Equals(value, _LeastRecentEmployerFromDate)) return;
                _LeastRecentEmployerFromDate = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerFromDate;

        [StringLength(16)]
        [Display(Name = "Date to: ")]
        public string LeastRecentEmployerToDate
        {
            get { return _LeastRecentEmployerToDate; }
            set
            {
                if (Equals(value, _LeastRecentEmployerToDate)) return;
                _LeastRecentEmployerToDate = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerToDate;

        [StringLength(50)]
        [Display(Name = "Employer Address")]
        public string LeastRecentEmployerAddress
        {
            get { return _LeastRecentEmployerAddress; }
            set
            {
                if (Equals(value, _LeastRecentEmployerAddress)) return;
                _LeastRecentEmployerAddress = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerAddress;

        [StringLength(16)]
        [Display(Name = "Employer Phone")]
        public string LeastRecentEmployerPhone
        {
            get { return _LeastRecentEmployerPhone; }
            set
            {
                if (Equals(value, _LeastRecentEmployerPhone)) return;
                _LeastRecentEmployerPhone = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerPhone;

        [StringLength(20)]
        [Display(Name = "Supervisor")]
        public string LeastRecentEmployerSupervisor
        {
            get { return _LeastRecentEmployerSupervisor; }
            set
            {
                if (Equals(value, _LeastRecentEmployerSupervisor)) return;
                _LeastRecentEmployerSupervisor = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerSupervisor;

        [StringLength(50)]
        [Display(Name = "Your Title")]
        public string LeastRecentEmployerPosition
        {
            get { return _LeastRecentEmployerPosition; }
            set
            {
                if (Equals(value, _LeastRecentEmployerPosition)) return;
                _LeastRecentEmployerPosition = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerPosition;

        [StringLength(16)]
        [Display(Name = "Start Salary")]
        public string LeastRecentEmployerStartSalary
        {
            get { return _LeastRecentEmployerStartSalary; }
            set
            {
                if (Equals(value, _LeastRecentEmployerStartSalary)) return;
                _LeastRecentEmployerStartSalary = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerStartSalary;

        [StringLength(16)]
        [Display(Name = "End Salary")]
        public string LeastRecentEmployerEndSalary
        {
            get { return _LeastRecentEmployerEndSalary; }
            set
            {
                if (Equals(value, _LeastRecentEmployerEndSalary)) return;
                _LeastRecentEmployerEndSalary = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerEndSalary;

        [StringLength(50)]
        [Display(Name = "Reason for Leaving")]
        public string LeastRecentEmployerReasonForLeaving
        {
            get { return _LeastRecentEmployerReasonForLeaving; }
            set
            {
                if (Equals(value, _LeastRecentEmployerReasonForLeaving)) return;
                _LeastRecentEmployerReasonForLeaving = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerReasonForLeaving;

        [Display(Name = "Responsibilities")]
        public string LeastRecentEmployerResponsibilities
        {
            get { return _LeastRecentEmployerResponsibilities; }
            set
            {
                if (Equals(value, _LeastRecentEmployerResponsibilities)) return;
                _LeastRecentEmployerResponsibilities = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEmployerResponsibilities;
        // Education
        [StringLength(40)]
        [Display(Name = "Institution Name")]
        public string MostRecentEducationName
        {
            get { return _MostRecentEducationName; }
            set
            {
                if (Equals(value, _MostRecentEducationName)) return;
                _MostRecentEducationName = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEducationName;

        [StringLength(10)]
        [Display(Name = "Dates Attended")]
        public string MostRecentEducationYearsAttended
        {
            get { return _MostRecentEducationYearsAttended; }
            set
            {
                if (Equals(value, _MostRecentEducationYearsAttended)) return;
                _MostRecentEducationYearsAttended = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEducationYearsAttended;

        [Display(Name = "Graduated")]
        public bool MostRecentEducationGraduated
        {
            get { return _MostRecentEducationGraduated; }
            set
            {
                if (Equals(value, _MostRecentEducationGraduated)) return;
                _MostRecentEducationGraduated = value;
                NotifyPropertyChanged();
            }
        }
        private bool _MostRecentEducationGraduated;

        [StringLength(30)]
        [Display(Name = "Degree/Major")]
        public string MostRecentEducationDegreeMajor
        {
            get { return _MostRecentEducationDegreeMajor; }
            set
            {
                if (Equals(value, _MostRecentEducationDegreeMajor)) return;
                _MostRecentEducationDegreeMajor = value;
                NotifyPropertyChanged();
            }
        }
        private string _MostRecentEducationDegreeMajor;

        [StringLength(40)]
        [Display(Name = "Institution Name")]
        public string MiddleRecentEducationName
        {
            get { return _MiddleRecentEducationName; }
            set
            {
                if (Equals(value, _MiddleRecentEducationName)) return;
                _MiddleRecentEducationName = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEducationName;

        [StringLength(10)]
        [Display(Name = "Dates Attended")]
        public string MiddleRecentEducationYearsAttended
        {
            get { return _MiddleRecentEducationYearsAttended; }
            set
            {
                if (Equals(value, _MiddleRecentEducationYearsAttended)) return;
                _MiddleRecentEducationYearsAttended = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEducationYearsAttended;

        [Display(Name = "Graduated")]
        public bool MiddleRecentEducationGraduated
        {
            get { return _MiddleRecentEducationGraduated; }
            set
            {
                if (Equals(value, _MiddleRecentEducationGraduated)) return;
                _MiddleRecentEducationGraduated = value;
                NotifyPropertyChanged();
            }
        }
        private bool _MiddleRecentEducationGraduated;

        [StringLength(30)]
        [Display(Name = "Degree/Major")]
        public string MiddleRecentEducationDegreeMajor
        {
            get { return _MiddleRecentEducationDegreeMajor; }
            set
            {
                if (Equals(value, _MiddleRecentEducationDegreeMajor)) return;
                _MiddleRecentEducationDegreeMajor = value;
                NotifyPropertyChanged();
            }
        }
        private string _MiddleRecentEducationDegreeMajor;

        [StringLength(40)]
        [Display(Name = "Institution Name")]
        public string LeastRecentEducationName
        {
            get { return _LeastRecentEducationName; }
            set
            {
                if (Equals(value, _LeastRecentEducationName)) return;
                _LeastRecentEducationName = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEducationName;

        [StringLength(10)]
        [Display(Name = "Dates Attended")]
        public string LeastRecentEducationYearsAttended
        {
            get { return _LeastRecentEducationYearsAttended; }
            set
            {
                if (Equals(value, _LeastRecentEducationYearsAttended)) return;
                _LeastRecentEducationYearsAttended = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEducationYearsAttended;

        [Display(Name = "Graduated")]
        public bool LeastRecentEducationGraduated
        {
            get { return _LeastRecentEducationGraduated; }
            set
            {
                if (Equals(value, _LeastRecentEducationGraduated)) return;
                _LeastRecentEducationGraduated = value;
                NotifyPropertyChanged();
            }
        }
        private bool _LeastRecentEducationGraduated;

        [StringLength(30)]
        [Display(Name = "Degree/Major")]
        public string LeastRecentEducationDegreeMajor
        {
            get { return _LeastRecentEducationDegreeMajor; }
            set
            {
                if (Equals(value, _LeastRecentEducationDegreeMajor)) return;
                _LeastRecentEducationDegreeMajor = value;
                NotifyPropertyChanged();
            }
        }
        private string _LeastRecentEducationDegreeMajor;
        // references
        [StringLength(40)]
        [Display(Name = "Reference Name")]
        public string Reference1Name
        {
            get { return _Reference1Name; }
            set
            {
                if (Equals(value, _Reference1Name)) return;
                _Reference1Name = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference1Name;

        [StringLength(16)]
        [Display(Name = "Contact Number")]
        public string Reference1Phone
        {
            get { return _Reference1Phone; }
            set
            {
                if (Equals(value, _Reference1Phone)) return;
                _Reference1Phone = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference1Phone;

        [StringLength(20)]
        [Display(Name = "Company Name")]
        public string Reference1Company
        {
            get { return _Reference1Company; }
            set
            {
                if (Equals(value, _Reference1Company)) return;
                _Reference1Company = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference1Company;

        [StringLength(15)]
        [Display(Name = "Title")]
        public string Reference1Title
        {
            get { return _Reference1Title; }
            set
            {
                if (Equals(value, _Reference1Title)) return;
                _Reference1Title = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference1Title;

        [StringLength(40)]
        [Display(Name = "Reference Name")]
        public string Reference2Name
        {
            get { return _Reference2Name; }
            set
            {
                if (Equals(value, _Reference2Name)) return;
                _Reference2Name = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference2Name;

        [StringLength(16)]
        [Display(Name = "Contact Number")]
        public string Reference2Phone
        {
            get { return _Reference2Phone; }
            set
            {
                if (Equals(value, _Reference2Phone)) return;
                _Reference2Phone = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference2Phone;

        [StringLength(20)]
        [Display(Name = "Company")]
        public string Reference2Company
        {
            get { return _Reference2Company; }
            set
            {
                if (Equals(value, _Reference2Company)) return;
                _Reference2Company = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference2Company;

        [StringLength(20)]
        [Display(Name = "Title")]
        public string Reference2Title
        {
            get { return _Reference2Title; }
            set
            {
                if (Equals(value, _Reference2Title)) return;
                _Reference2Title = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference2Title;

        [StringLength(40)]
        [Display(Name = "Reference Name")]
        public string Reference3Name
        {
            get { return _Reference3Name; }
            set
            {
                if (Equals(value, _Reference3Name)) return;
                _Reference3Name = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference3Name;

        [StringLength(16)]
        [Display(Name = "Contact Number")]
        public string Reference3Phone
        {
            get { return _Reference3Phone; }
            set
            {
                if (Equals(value, _Reference3Phone)) return;
                _Reference3Phone = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference3Phone;

        [StringLength(20)]
        [Display(Name = "Company")]
        public string Reference3Company
        {
            get { return _Reference3Company; }
            set
            {
                if (Equals(value, _Reference3Company)) return;
                _Reference3Company = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference3Company;

        [StringLength(20)]
        [Display(Name = "Title")]
        public string Reference3Title
        {
            get { return _Reference3Title; }
            set
            {
                if (Equals(value, _Reference3Title)) return;
                _Reference3Title = value;
                NotifyPropertyChanged();
            }
        }
        private string _Reference3Title;

        [Display(Name = "Hiring Notes")]
        public string HiringManagerNotes
        {
            get { return _HiringManagerNotes; }
            set
            {
                if (Equals(value, _HiringManagerNotes)) return;
                _HiringManagerNotes = value;
                NotifyPropertyChanged();
            }
        }
        private string _HiringManagerNotes;
        
        public DateTime? ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                if (Equals(value, _ApplicationDate)) return;
                _ApplicationDate = value;
                NotifyPropertyChanged();
            }
        }
        private DateTime? _ApplicationDate;

        public ChangeTrackingCollection<User> Users
        {
            get { return _Users; }
            set
            {
                if (Equals(value, _Users)) return;
                _Users = value;
                NotifyPropertyChanged();
            }
        }
        private ChangeTrackingCollection<User> _Users;
    }
}
