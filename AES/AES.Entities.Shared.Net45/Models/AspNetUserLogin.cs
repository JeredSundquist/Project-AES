namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    public partial class AspNetUserLogin : EntityBase
    {
        [Key]
        [Column(Order = 0)]
		public string LoginProvider
		{ 
			get { return _LoginProvider; }
			set
			{
				if (Equals(value, _LoginProvider)) return;
				_LoginProvider = value;
				NotifyPropertyChanged();
			}
		}
		private string _LoginProvider;

        [Key]
        [Column(Order = 1)]
		public string ProviderKey
		{ 
			get { return _ProviderKey; }
			set
			{
				if (Equals(value, _ProviderKey)) return;
				_ProviderKey = value;
				NotifyPropertyChanged();
			}
		}
		private string _ProviderKey;

        [Key]
        [Column(Order = 2)]
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
