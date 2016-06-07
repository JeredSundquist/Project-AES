namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    public partial class AspNetUserClaim : EntityBase
    {
		public int Id
		{ 
			get { return _Id; }
			set
			{
				if (Equals(value, _Id)) return;
				_Id = value;
				NotifyPropertyChanged();
			}
		}
		private int _Id;

        [Required]
        [StringLength(128)]
		public string UserId
		{ 
			get { return _UserId; }
			set
			{
				if (Equals(value, _UserId)) return;
				_UserId = value;
				NotifyPropertyChanged();
			}
		}
		private string _UserId;

		public string ClaimType
		{ 
			get { return _ClaimType; }
			set
			{
				if (Equals(value, _ClaimType)) return;
				_ClaimType = value;
				NotifyPropertyChanged();
			}
		}
		private string _ClaimType;

		public string ClaimValue
		{ 
			get { return _ClaimValue; }
			set
			{
				if (Equals(value, _ClaimValue)) return;
				_ClaimValue = value;
				NotifyPropertyChanged();
			}
		}
		private string _ClaimValue;


		public AspNetUser AspNetUser
		{
			get { return _AspNetUser; }
			set
			{
				if (Equals(value, _AspNetUser)) return;
				_AspNetUser = value;
				AspNetUserChangeTracker = _AspNetUser == null ? null
					: new ChangeTrackingCollection<AspNetUser> { _AspNetUser };
				NotifyPropertyChanged();
			}
		}
		private AspNetUser _AspNetUser;
		private ChangeTrackingCollection<AspNetUser> AspNetUserChangeTracker { get; set; }
    }
}
