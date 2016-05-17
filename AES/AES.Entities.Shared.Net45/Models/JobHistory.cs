namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("JobHistory")]
    public partial class JobHistory : EntityBase
    {
		public int JobHistoryId
		{ 
			get { return _JobHistoryId; }
			set
			{
				if (Equals(value, _JobHistoryId)) return;
				_JobHistoryId = value;
				NotifyPropertyChanged();
			}
		}
		private int _JobHistoryId;

		public string Employer
		{ 
			get { return _Employer; }
			set
			{
				if (Equals(value, _Employer)) return;
				_Employer = value;
				NotifyPropertyChanged();
			}
		}
		private string _Employer;

		public string EmpAddress
		{ 
			get { return _EmpAddress; }
			set
			{
				if (Equals(value, _EmpAddress)) return;
				_EmpAddress = value;
				NotifyPropertyChanged();
			}
		}
		private string _EmpAddress;

		public string JobTitle
		{ 
			get { return _JobTitle; }
			set
			{
				if (Equals(value, _JobTitle)) return;
				_JobTitle = value;
				NotifyPropertyChanged();
			}
		}
		private string _JobTitle;

		public string ReasonLeaving
		{ 
			get { return _ReasonLeaving; }
			set
			{
				if (Equals(value, _ReasonLeaving)) return;
				_ReasonLeaving = value;
				NotifyPropertyChanged();
			}
		}
		private string _ReasonLeaving;

		public DateTime? DateStarted
		{ 
			get { return _DateStarted; }
			set
			{
				if (Equals(value, _DateStarted)) return;
				_DateStarted = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _DateStarted;

		public DateTime? DateEnded
		{ 
			get { return _DateEnded; }
			set
			{
				if (Equals(value, _DateEnded)) return;
				_DateEnded = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _DateEnded;

		public int? Phone
		{ 
			get { return _Phone; }
			set
			{
				if (Equals(value, _Phone)) return;
				_Phone = value;
				NotifyPropertyChanged();
			}
		}
		private int? _Phone;

		public int? Superviser
		{ 
			get { return _Superviser; }
			set
			{
				if (Equals(value, _Superviser)) return;
				_Superviser = value;
				NotifyPropertyChanged();
			}
		}
		private int? _Superviser;

		public decimal? StartingSalary
		{ 
			get { return _StartingSalary; }
			set
			{
				if (Equals(value, _StartingSalary)) return;
				_StartingSalary = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _StartingSalary;

		public string Responsibilities
		{ 
			get { return _Responsibilities; }
			set
			{
				if (Equals(value, _Responsibilities)) return;
				_Responsibilities = value;
				NotifyPropertyChanged();
			}
		}
		private string _Responsibilities;

		public decimal? EndingSalary
		{ 
			get { return _EndingSalary; }
			set
			{
				if (Equals(value, _EndingSalary)) return;
				_EndingSalary = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _EndingSalary;
    }
}
