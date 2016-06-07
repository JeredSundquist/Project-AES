namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("__MigrationHistory")]
    public partial class C__MigrationHistory : EntityBase
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
		public string MigrationId
		{ 
			get { return _MigrationId; }
			set
			{
				if (Equals(value, _MigrationId)) return;
				_MigrationId = value;
				NotifyPropertyChanged();
			}
		}
		private string _MigrationId;

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
		public string ContextKey
		{ 
			get { return _ContextKey; }
			set
			{
				if (Equals(value, _ContextKey)) return;
				_ContextKey = value;
				NotifyPropertyChanged();
			}
		}
		private string _ContextKey;

        [Required]
		public byte[] Model
		{ 
			get { return _Model; }
			set
			{
				if (Equals(value, _Model)) return;
				_Model = value;
				NotifyPropertyChanged();
			}
		}
		private byte[] _Model;

        [Required]
        [StringLength(32)]
		public string ProductVersion
		{ 
			get { return _ProductVersion; }
			set
			{
				if (Equals(value, _ProductVersion)) return;
				_ProductVersion = value;
				NotifyPropertyChanged();
			}
		}
		private string _ProductVersion;
    }
}
