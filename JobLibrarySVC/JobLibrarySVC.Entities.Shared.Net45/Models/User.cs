namespace JobLibrarySVC.Entities.Shared.Net45.Models
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

		public string address
		{ 
			get { return _address; }
			set
			{
				if (Equals(value, _address)) return;
				_address = value;
				NotifyPropertyChanged();
			}
		}
		private string _address;
    }
}
