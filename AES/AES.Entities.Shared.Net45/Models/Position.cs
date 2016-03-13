namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("Position")]
    public partial class Position : EntityBase
    {
        public Position()
        {
            AppliedPositions = new ChangeTrackingCollection<AppliedPosition>();
        }

        [Display(Name = "Position Id")]
        [Key]
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

        [Required]
        [Display(Name = "Position")]
        public string PositionName
		{ 
			get { return _PositionName; }
			set
			{
				if (Equals(value, _PositionName)) return;
				_PositionName = value;
				NotifyPropertyChanged();
			}
		}
		private string _PositionName;

        [Required]
        [Display(Name = "Description")]
        public string PositionDesc
		{ 
			get { return _PositionDesc; }
			set
			{
				if (Equals(value, _PositionDesc)) return;
				_PositionDesc = value;
				NotifyPropertyChanged();
			}
		}
		private string _PositionDesc;

		public int StoreId
		{ 
			get { return _StoreId; }
			set
			{
				if (Equals(value, _StoreId)) return;
				_StoreId = value;
				NotifyPropertyChanged();
			}
		}
		private int _StoreId;

		public int TestId
		{ 
			get { return _TestId; }
			set
			{
				if (Equals(value, _TestId)) return;
				_TestId = value;
				NotifyPropertyChanged();
			}
		}
		private int _TestId;

		public ChangeTrackingCollection<AppliedPosition> AppliedPositions
		{
			get { return _AppliedPositions; }
			set
			{
				if (Equals(value, _AppliedPositions)) return;
				_AppliedPositions = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<AppliedPosition> _AppliedPositions;


		public Store Store
		{
			get { return _Store; }
			set
			{
				if (Equals(value, _Store)) return;
				_Store = value;
				StoreChangeTracker = _Store == null ? null
					: new ChangeTrackingCollection<Store> { _Store };
				NotifyPropertyChanged();
			}
		}
		private Store _Store;
		private ChangeTrackingCollection<Store> StoreChangeTracker { get; set; }


		public Test Test
		{
			get { return _Test; }
			set
			{
				if (Equals(value, _Test)) return;
				_Test = value;
				TestChangeTracker = _Test == null ? null
					: new ChangeTrackingCollection<Test> { _Test };
				NotifyPropertyChanged();
			}
		}
		private Test _Test;
		private ChangeTrackingCollection<Test> TestChangeTracker { get; set; }
    }
}
