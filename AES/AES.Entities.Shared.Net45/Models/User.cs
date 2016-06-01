namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("User")]
    public partial class User : EntityBase
    {
		public int UserId
		{ 
			get { return _UserId; }
			set
			{
				if (Equals(value, _UserId)) return;
				_UserId = value;
				NotifyPropertyChanged();
			}
		}
		private int _UserId;

        [Required]
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

        [Required]
		public string password
		{ 
			get { return _password; }
			set
			{
				if (Equals(value, _password)) return;
				_password = value;
				NotifyPropertyChanged();
			}
		}
		private string _password;

        [Required]
		public string email
		{ 
			get { return _email; }
			set
			{
				if (Equals(value, _email)) return;
				_email = value;
				NotifyPropertyChanged();
			}
		}
		private string _email;

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


		public Application Application
		{
			get { return _Application; }
			set
			{
				if (Equals(value, _Application)) return;
				_Application = value;
				ApplicationChangeTracker = _Application == null ? null
					: new ChangeTrackingCollection<Application> { _Application };
				NotifyPropertyChanged();
			}
		}
		private Application _Application;
		private ChangeTrackingCollection<Application> ApplicationChangeTracker { get; set; }
    }
}
