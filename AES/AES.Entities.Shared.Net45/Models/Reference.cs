










namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;


    [Table("Reference")]

    public partial class Reference : EntityBase
    {

		public int ReferenceId
		{ 
			get { return _ReferenceId; }
			set
			{
				if (Equals(value, _ReferenceId)) return;
				_ReferenceId = value;
				NotifyPropertyChanged();
			}
		}
		private int _ReferenceId;


		public string ReferenceName
		{ 
			get { return _ReferenceName; }
			set
			{
				if (Equals(value, _ReferenceName)) return;
				_ReferenceName = value;
				NotifyPropertyChanged();
			}
		}
		private string _ReferenceName;


		public int? ReferencePhone
		{ 
			get { return _ReferencePhone; }
			set
			{
				if (Equals(value, _ReferencePhone)) return;
				_ReferencePhone = value;
				NotifyPropertyChanged();
			}
		}
		private int? _ReferencePhone;


		public string ReferenceCompany
		{ 
			get { return _ReferenceCompany; }
			set
			{
				if (Equals(value, _ReferenceCompany)) return;
				_ReferenceCompany = value;
				NotifyPropertyChanged();
			}
		}
		private string _ReferenceCompany;


		public string ReferenceTitle
		{ 
			get { return _ReferenceTitle; }
			set
			{
				if (Equals(value, _ReferenceTitle)) return;
				_ReferenceTitle = value;
				NotifyPropertyChanged();
			}
		}
		private string _ReferenceTitle;

    }
}
