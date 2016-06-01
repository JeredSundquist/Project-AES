namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("UserPermission")]
    public partial class UserPermission : EntityBase
    {
        [Key]
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

		public bool editPosition
		{ 
			get { return _editPosition; }
			set
			{
				if (Equals(value, _editPosition)) return;
				_editPosition = value;
				NotifyPropertyChanged();
			}
		}
		private bool _editPosition;

		public bool requestPosition
		{ 
			get { return _requestPosition; }
			set
			{
				if (Equals(value, _requestPosition)) return;
				_requestPosition = value;
				NotifyPropertyChanged();
			}
		}
		private bool _requestPosition;

		public bool viewPosition
		{ 
			get { return _viewPosition; }
			set
			{
				if (Equals(value, _viewPosition)) return;
				_viewPosition = value;
				NotifyPropertyChanged();
			}
		}
		private bool _viewPosition;

		public bool editStore
		{ 
			get { return _editStore; }
			set
			{
				if (Equals(value, _editStore)) return;
				_editStore = value;
				NotifyPropertyChanged();
			}
		}
		private bool _editStore;

		public bool viewStore
		{ 
			get { return _viewStore; }
			set
			{
				if (Equals(value, _viewStore)) return;
				_viewStore = value;
				NotifyPropertyChanged();
			}
		}
		private bool _viewStore;

		public bool editTest
		{ 
			get { return _editTest; }
			set
			{
				if (Equals(value, _editTest)) return;
				_editTest = value;
				NotifyPropertyChanged();
			}
		}
		private bool _editTest;

		public bool viewTest
		{ 
			get { return _viewTest; }
			set
			{
				if (Equals(value, _viewTest)) return;
				_viewTest = value;
				NotifyPropertyChanged();
			}
		}
		private bool _viewTest;


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
