namespace JobLibrarySVC.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("Education")]
    public partial class Education : EntityBase
    {
		public int EducationId
		{ 
			get { return _EducationId; }
			set
			{
				if (Equals(value, _EducationId)) return;
				_EducationId = value;
				NotifyPropertyChanged();
			}
		}
		private int _EducationId;

		public string SchoolName
		{ 
			get { return _SchoolName; }
			set
			{
				if (Equals(value, _SchoolName)) return;
				_SchoolName = value;
				NotifyPropertyChanged();
			}
		}
		private string _SchoolName;

		public string SchoolAddress
		{ 
			get { return _SchoolAddress; }
			set
			{
				if (Equals(value, _SchoolAddress)) return;
				_SchoolAddress = value;
				NotifyPropertyChanged();
			}
		}
		private string _SchoolAddress;

		public DateTime? TimeAttended
		{ 
			get { return _TimeAttended; }
			set
			{
				if (Equals(value, _TimeAttended)) return;
				_TimeAttended = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _TimeAttended;

		public DateTime? TimeLeft
		{ 
			get { return _TimeLeft; }
			set
			{
				if (Equals(value, _TimeLeft)) return;
				_TimeLeft = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _TimeLeft;

		public bool? Graduated
		{ 
			get { return _Graduated; }
			set
			{
				if (Equals(value, _Graduated)) return;
				_Graduated = value;
				NotifyPropertyChanged();
			}
		}
		private bool? _Graduated;

		public string DegreeMajor
		{ 
			get { return _DegreeMajor; }
			set
			{
				if (Equals(value, _DegreeMajor)) return;
				_DegreeMajor = value;
				NotifyPropertyChanged();
			}
		}
		private string _DegreeMajor;
    }
}
