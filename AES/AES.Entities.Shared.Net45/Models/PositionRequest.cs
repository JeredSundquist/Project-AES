










namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;


    [Table("PositionRequest")]

    public partial class PositionRequest : EntityBase
    {

        [Key]

		public int RequestId
		{ 
			get { return _RequestId; }
			set
			{
				if (Equals(value, _RequestId)) return;
				_RequestId = value;
				NotifyPropertyChanged();
			}
		}
		private int _RequestId;


		public int RequestedBy
		{ 
			get { return _RequestedBy; }
			set
			{
				if (Equals(value, _RequestedBy)) return;
				_RequestedBy = value;
				NotifyPropertyChanged();
			}
		}
		private int _RequestedBy;


        [Required]

        [StringLength(50)]

		public string RequestedByName
		{ 
			get { return _RequestedByName; }
			set
			{
				if (Equals(value, _RequestedByName)) return;
				_RequestedByName = value;
				NotifyPropertyChanged();
			}
		}
		private string _RequestedByName;


        [Required]

        [StringLength(50)]

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


        [Required]

		public string RequestReason
		{ 
			get { return _RequestReason; }
			set
			{
				if (Equals(value, _RequestReason)) return;
				_RequestReason = value;
				NotifyPropertyChanged();
			}
		}
		private string _RequestReason;


		public DateTime? DateRequested
		{ 
			get { return _DateRequested; }
			set
			{
				if (Equals(value, _DateRequested)) return;
				_DateRequested = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _DateRequested;


		public bool RequestApproved
		{ 
			get { return _RequestApproved; }
			set
			{
				if (Equals(value, _RequestApproved)) return;
				_RequestApproved = value;
				NotifyPropertyChanged();
			}
		}
		private bool _RequestApproved;


		public bool RequestDenied
		{ 
			get { return _RequestDenied; }
			set
			{
				if (Equals(value, _RequestDenied)) return;
				_RequestDenied = value;
				NotifyPropertyChanged();
			}
		}
		private bool _RequestDenied;


		public int? ApproveBy
		{ 
			get { return _ApproveBy; }
			set
			{
				if (Equals(value, _ApproveBy)) return;
				_ApproveBy = value;
				NotifyPropertyChanged();
			}
		}
		private int? _ApproveBy;


        [StringLength(50)]

		public string ApprovedByName
		{ 
			get { return _ApprovedByName; }
			set
			{
				if (Equals(value, _ApprovedByName)) return;
				_ApprovedByName = value;
				NotifyPropertyChanged();
			}
		}
		private string _ApprovedByName;


        [Required]

		public string DenialReason
		{ 
			get { return _DenialReason; }
			set
			{
				if (Equals(value, _DenialReason)) return;
				_DenialReason = value;
				NotifyPropertyChanged();
			}
		}
		private string _DenialReason;


		public DateTime? DateApproved
		{ 
			get { return _DateApproved; }
			set
			{
				if (Equals(value, _DateApproved)) return;
				_DateApproved = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _DateApproved;

    }
}
