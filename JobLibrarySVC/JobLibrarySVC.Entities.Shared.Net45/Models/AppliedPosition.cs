namespace JobLibrarySVC.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("AppliedPosition")]
    public partial class AppliedPosition : EntityBase
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int PositionId
		{ 
			get { return _PositionId; }
			set
			{
				if (Equals(value, _PositionId)) return;
				_PositionId = value;
				NotifyPropertyChanged();
			}
		}
		private int _PositionId;


		public Position Position
		{
			get { return _Position; }
			set
			{
				if (Equals(value, _Position)) return;
				_Position = value;
				PositionChangeTracker = _Position == null ? null
					: new ChangeTrackingCollection<Position> { _Position };
				NotifyPropertyChanged();
			}
		}
		private Position _Position;
		private ChangeTrackingCollection<Position> PositionChangeTracker { get; set; }
    }
}
