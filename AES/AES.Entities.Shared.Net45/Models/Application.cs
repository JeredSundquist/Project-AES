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

		public bool? FullTime
		{ 
			get { return _FullTime; }
			set
			{
				if (Equals(value, _FullTime)) return;
				_FullTime = value;
				NotifyPropertyChanged();
			}
		}
		private bool? _FullTime;

		public int? MondayAvailable
		{ 
			get { return _MondayAvailable; }
			set
			{
				if (Equals(value, _MondayAvailable)) return;
				_MondayAvailable = value;
				NotifyPropertyChanged();
			}
		}
		private int? _MondayAvailable;

		public int? TuesdayAvailable
		{ 
			get { return _TuesdayAvailable; }
			set
			{
				if (Equals(value, _TuesdayAvailable)) return;
				_TuesdayAvailable = value;
				NotifyPropertyChanged();
			}
		}
		private int? _TuesdayAvailable;

		public int? WednesdayAvailable
		{ 
			get { return _WednesdayAvailable; }
			set
			{
				if (Equals(value, _WednesdayAvailable)) return;
				_WednesdayAvailable = value;
				NotifyPropertyChanged();
			}
		}
		private int? _WednesdayAvailable;

		public int? ThursdayAvailable
		{ 
			get { return _ThursdayAvailable; }
			set
			{
				if (Equals(value, _ThursdayAvailable)) return;
				_ThursdayAvailable = value;
				NotifyPropertyChanged();
			}
		}
		private int? _ThursdayAvailable;

		public int? FridayAvailable
		{ 
			get { return _FridayAvailable; }
			set
			{
				if (Equals(value, _FridayAvailable)) return;
				_FridayAvailable = value;
				NotifyPropertyChanged();
			}
		}
		private int? _FridayAvailable;

		public int? SaturdayAvailable
		{ 
			get { return _SaturdayAvailable; }
			set
			{
				if (Equals(value, _SaturdayAvailable)) return;
				_SaturdayAvailable = value;
				NotifyPropertyChanged();
			}
		}
		private int? _SaturdayAvailable;

		public int? SundayAvailable
		{ 
			get { return _SundayAvailable; }
			set
			{
				if (Equals(value, _SundayAvailable)) return;
				_SundayAvailable = value;
				NotifyPropertyChanged();
			}
		}
		private int? _SundayAvailable;

		public int? MostRecentId
		{ 
			get { return _MostRecentId; }
			set
			{
				if (Equals(value, _MostRecentId)) return;
				_MostRecentId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _MostRecentId;

		public int? MiddleRecentId
		{ 
			get { return _MiddleRecentId; }
			set
			{
				if (Equals(value, _MiddleRecentId)) return;
				_MiddleRecentId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _MiddleRecentId;

		public int? LeastRecentId
		{ 
			get { return _LeastRecentId; }
			set
			{
				if (Equals(value, _LeastRecentId)) return;
				_LeastRecentId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _LeastRecentId;

		public int? RecentEducationId
		{ 
			get { return _RecentEducationId; }
			set
			{
				if (Equals(value, _RecentEducationId)) return;
				_RecentEducationId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _RecentEducationId;

		public int? MiddleEducationId
		{ 
			get { return _MiddleEducationId; }
			set
			{
				if (Equals(value, _MiddleEducationId)) return;
				_MiddleEducationId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _MiddleEducationId;

		public int? LeastEducationId
		{ 
			get { return _LeastEducationId; }
			set
			{
				if (Equals(value, _LeastEducationId)) return;
				_LeastEducationId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _LeastEducationId;

		public int? ReferenceId
		{ 
			get { return _ReferenceId; }
			set
			{
				if (Equals(value, _ReferenceId)) return;
				_ReferenceId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _ReferenceId;

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
