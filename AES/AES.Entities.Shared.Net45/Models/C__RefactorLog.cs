namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("__RefactorLog")]
    public partial class C__RefactorLog : EntityBase
    {
        [Key]
		public Guid OperationKey
		{ 
			get { return _OperationKey; }
			set
			{
				if (Equals(value, _OperationKey)) return;
				_OperationKey = value;
				NotifyPropertyChanged();
			}
		}
		private Guid _OperationKey;
    }
}
