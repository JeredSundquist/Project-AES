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

		public int? SSN
		{ 
			get { return _SSN; }
			set
			{
				if (Equals(value, _SSN)) return;
				_SSN = value;
				NotifyPropertyChanged();
			}
		}
		private int? _SSN;

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

		public int? PhoneNumber
		{ 
			get { return _PhoneNumber; }
			set
			{
				if (Equals(value, _PhoneNumber)) return;
				_PhoneNumber = value;
				NotifyPropertyChanged();
			}
		}
		private int? _PhoneNumber;

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

        [Column(TypeName = "money")]
		public decimal? SalaryExpectation
		{ 
			get { return _SalaryExpectation; }
			set
			{
				if (Equals(value, _SalaryExpectation)) return;
				_SalaryExpectation = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _SalaryExpectation;

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

        [StringLength(50)]
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

        [Column(TypeName = "date")]
		public DateTime? MostRecentEmployerFromDate
		{ 
			get { return _MostRecentEmployerFromDate; }
			set
			{
				if (Equals(value, _MostRecentEmployerFromDate)) return;
				_MostRecentEmployerFromDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _MostRecentEmployerFromDate;

        [Column(TypeName = "date")]
		public DateTime? MostRecentEmployerToDate
		{ 
			get { return _MostRecentEmployerToDate; }
			set
			{
				if (Equals(value, _MostRecentEmployerToDate)) return;
				_MostRecentEmployerToDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _MostRecentEmployerToDate;

        [StringLength(50)]
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

		public int? MostRecentEmployerPhone
		{ 
			get { return _MostRecentEmployerPhone; }
			set
			{
				if (Equals(value, _MostRecentEmployerPhone)) return;
				_MostRecentEmployerPhone = value;
				NotifyPropertyChanged();
			}
		}
		private int? _MostRecentEmployerPhone;

        [StringLength(15)]
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

        [Column(TypeName = "money")]
		public decimal? MostRecentEmployerStartSalary
		{ 
			get { return _MostRecentEmployerStartSalary; }
			set
			{
				if (Equals(value, _MostRecentEmployerStartSalary)) return;
				_MostRecentEmployerStartSalary = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _MostRecentEmployerStartSalary;

        [Column(TypeName = "money")]
		public decimal? MostRecentEmployerEndSalary
		{ 
			get { return _MostRecentEmployerEndSalary; }
			set
			{
				if (Equals(value, _MostRecentEmployerEndSalary)) return;
				_MostRecentEmployerEndSalary = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _MostRecentEmployerEndSalary;

        [StringLength(80)]
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

        [StringLength(50)]
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

        [Column(TypeName = "date")]
		public DateTime? MiddleRecentEmployerFromDate
		{ 
			get { return _MiddleRecentEmployerFromDate; }
			set
			{
				if (Equals(value, _MiddleRecentEmployerFromDate)) return;
				_MiddleRecentEmployerFromDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _MiddleRecentEmployerFromDate;

        [Column(TypeName = "date")]
		public DateTime? MiddleRecentEmployerToDate
		{ 
			get { return _MiddleRecentEmployerToDate; }
			set
			{
				if (Equals(value, _MiddleRecentEmployerToDate)) return;
				_MiddleRecentEmployerToDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _MiddleRecentEmployerToDate;

        [StringLength(50)]
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

		public int? MiddleRecentEmployerPhone
		{ 
			get { return _MiddleRecentEmployerPhone; }
			set
			{
				if (Equals(value, _MiddleRecentEmployerPhone)) return;
				_MiddleRecentEmployerPhone = value;
				NotifyPropertyChanged();
			}
		}
		private int? _MiddleRecentEmployerPhone;

        [StringLength(15)]
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

        [Column(TypeName = "money")]
		public decimal? MiddleRecentEmployerStartSalary
		{ 
			get { return _MiddleRecentEmployerStartSalary; }
			set
			{
				if (Equals(value, _MiddleRecentEmployerStartSalary)) return;
				_MiddleRecentEmployerStartSalary = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _MiddleRecentEmployerStartSalary;

        [Column(TypeName = "money")]
		public decimal? MiddleRecentEmployerEndSalary
		{ 
			get { return _MiddleRecentEmployerEndSalary; }
			set
			{
				if (Equals(value, _MiddleRecentEmployerEndSalary)) return;
				_MiddleRecentEmployerEndSalary = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _MiddleRecentEmployerEndSalary;

        [StringLength(50)]
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

        [Column(TypeName = "date")]
		public DateTime? LeastRecentEmployerFromDate
		{ 
			get { return _LeastRecentEmployerFromDate; }
			set
			{
				if (Equals(value, _LeastRecentEmployerFromDate)) return;
				_LeastRecentEmployerFromDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _LeastRecentEmployerFromDate;

        [Column(TypeName = "date")]
		public DateTime? LeastRecentEmployerToDate
		{ 
			get { return _LeastRecentEmployerToDate; }
			set
			{
				if (Equals(value, _LeastRecentEmployerToDate)) return;
				_LeastRecentEmployerToDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _LeastRecentEmployerToDate;

        [StringLength(50)]
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

		public int? LeastRecentEmployerPhone
		{ 
			get { return _LeastRecentEmployerPhone; }
			set
			{
				if (Equals(value, _LeastRecentEmployerPhone)) return;
				_LeastRecentEmployerPhone = value;
				NotifyPropertyChanged();
			}
		}
		private int? _LeastRecentEmployerPhone;

        [StringLength(15)]
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

        [Column(TypeName = "money")]
		public decimal? LeastRecentEmployerStartSalary
		{ 
			get { return _LeastRecentEmployerStartSalary; }
			set
			{
				if (Equals(value, _LeastRecentEmployerStartSalary)) return;
				_LeastRecentEmployerStartSalary = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _LeastRecentEmployerStartSalary;

        [Column(TypeName = "money")]
		public decimal? LeastRecentEmployerEndSalary
		{ 
			get { return _LeastRecentEmployerEndSalary; }
			set
			{
				if (Equals(value, _LeastRecentEmployerEndSalary)) return;
				_LeastRecentEmployerEndSalary = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _LeastRecentEmployerEndSalary;

        [StringLength(50)]
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

        [StringLength(40)]
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

        [StringLength(40)]
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

		public int? Reference1Phone
		{ 
			get { return _Reference1Phone; }
			set
			{
				if (Equals(value, _Reference1Phone)) return;
				_Reference1Phone = value;
				NotifyPropertyChanged();
			}
		}
		private int? _Reference1Phone;

        [StringLength(15)]
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

		public int? Reference2Phone
		{ 
			get { return _Reference2Phone; }
			set
			{
				if (Equals(value, _Reference2Phone)) return;
				_Reference2Phone = value;
				NotifyPropertyChanged();
			}
		}
		private int? _Reference2Phone;

        [StringLength(15)]
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

        [StringLength(15)]
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

		public int? Reference3Phone
		{ 
			get { return _Reference3Phone; }
			set
			{
				if (Equals(value, _Reference3Phone)) return;
				_Reference3Phone = value;
				NotifyPropertyChanged();
			}
		}
		private int? _Reference3Phone;

        [StringLength(15)]
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

        [StringLength(15)]
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
    }
}
