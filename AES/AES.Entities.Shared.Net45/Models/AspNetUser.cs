namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    public partial class AspNetUser : EntityBase
    {
        public AspNetUser()
        {
            AspNetUserClaims = new ChangeTrackingCollection<AspNetUserClaim>();
            AspNetUserLogins = new ChangeTrackingCollection<AspNetUserLogin>();
            AspNetRoles = new ChangeTrackingCollection<AspNetRole>();
        }

		public string Id
		{ 
			get { return _Id; }
			set
			{
				if (Equals(value, _Id)) return;
				_Id = value;
				NotifyPropertyChanged();
			}
		}
		private string _Id;

        [StringLength(256)]
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

		public bool EmailConfirmed
		{ 
			get { return _EmailConfirmed; }
			set
			{
				if (Equals(value, _EmailConfirmed)) return;
				_EmailConfirmed = value;
				NotifyPropertyChanged();
			}
		}
		private bool _EmailConfirmed;

		public string PasswordHash
		{ 
			get { return _PasswordHash; }
			set
			{
				if (Equals(value, _PasswordHash)) return;
				_PasswordHash = value;
				NotifyPropertyChanged();
			}
		}
		private string _PasswordHash;

		public string SecurityStamp
		{ 
			get { return _SecurityStamp; }
			set
			{
				if (Equals(value, _SecurityStamp)) return;
				_SecurityStamp = value;
				NotifyPropertyChanged();
			}
		}
		private string _SecurityStamp;

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

		public bool PhoneNumberConfirmed
		{ 
			get { return _PhoneNumberConfirmed; }
			set
			{
				if (Equals(value, _PhoneNumberConfirmed)) return;
				_PhoneNumberConfirmed = value;
				NotifyPropertyChanged();
			}
		}
		private bool _PhoneNumberConfirmed;

		public bool TwoFactorEnabled
		{ 
			get { return _TwoFactorEnabled; }
			set
			{
				if (Equals(value, _TwoFactorEnabled)) return;
				_TwoFactorEnabled = value;
				NotifyPropertyChanged();
			}
		}
		private bool _TwoFactorEnabled;

		public DateTime? LockoutEndDateUtc
		{ 
			get { return _LockoutEndDateUtc; }
			set
			{
				if (Equals(value, _LockoutEndDateUtc)) return;
				_LockoutEndDateUtc = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _LockoutEndDateUtc;

		public bool LockoutEnabled
		{ 
			get { return _LockoutEnabled; }
			set
			{
				if (Equals(value, _LockoutEnabled)) return;
				_LockoutEnabled = value;
				NotifyPropertyChanged();
			}
		}
		private bool _LockoutEnabled;

		public int AccessFailedCount
		{ 
			get { return _AccessFailedCount; }
			set
			{
				if (Equals(value, _AccessFailedCount)) return;
				_AccessFailedCount = value;
				NotifyPropertyChanged();
			}
		}
		private int _AccessFailedCount;

        [Required]
        [StringLength(256)]
		public string UserName
		{ 
			get { return _UserName; }
			set
			{
				if (Equals(value, _UserName)) return;
				_UserName = value;
				NotifyPropertyChanged();
			}
		}
		private string _UserName;

		public int? FK_ApplicationId
		{ 
			get { return _FK_ApplicationId; }
			set
			{
				if (Equals(value, _FK_ApplicationId)) return;
				_FK_ApplicationId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _FK_ApplicationId;

		public ChangeTrackingCollection<AspNetUserClaim> AspNetUserClaims
		{
			get { return _AspNetUserClaims; }
			set
			{
				if (Equals(value, _AspNetUserClaims)) return;
				_AspNetUserClaims = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<AspNetUserClaim> _AspNetUserClaims;

		public ChangeTrackingCollection<AspNetUserLogin> AspNetUserLogins
		{
			get { return _AspNetUserLogins; }
			set
			{
				if (Equals(value, _AspNetUserLogins)) return;
				_AspNetUserLogins = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<AspNetUserLogin> _AspNetUserLogins;


		public UserPermission UserPermission
		{
			get { return _UserPermission; }
			set
			{
				if (Equals(value, _UserPermission)) return;
				_UserPermission = value;
				UserPermissionChangeTracker = _UserPermission == null ? null
					: new ChangeTrackingCollection<UserPermission> { _UserPermission };
				NotifyPropertyChanged();
			}
		}
		private UserPermission _UserPermission;
		private ChangeTrackingCollection<UserPermission> UserPermissionChangeTracker { get; set; }

		public ChangeTrackingCollection<AspNetRole> AspNetRoles
		{
			get { return _AspNetRoles; }
			set
			{
				if (Equals(value, _AspNetRoles)) return;
				_AspNetRoles = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<AspNetRole> _AspNetRoles;
    }
}
