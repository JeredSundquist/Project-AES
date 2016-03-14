using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrackableEntities.Client;

namespace AES.Entities.Shared.Net45.Models
{
    [Table("Store")]

    public partial class Store : EntityBase
    {

        public Store()
        {

            Positions = new ChangeTrackingCollection<Position>();

        }


		public int StoreId
		{ 
			get { return _StoreId; }
			set
			{
				if (Equals(value, _StoreId)) return;
				_StoreId = value;
				NotifyPropertyChanged();
			}
		}
		private int _StoreId;


		public string StoreLocation
		{ 
			get { return _StoreLocation; }
			set
			{
				if (Equals(value, _StoreLocation)) return;
				_StoreLocation = value;
				NotifyPropertyChanged();
			}
		}
		private string _StoreLocation;


		public string StoreName
		{ 
			get { return _StoreName; }
			set
			{
				if (Equals(value, _StoreName)) return;
				_StoreName = value;
				NotifyPropertyChanged();
			}
		}
		private string _StoreName;


		public ChangeTrackingCollection<Position> Positions
		{
			get { return _Positions; }
			set
			{
				if (Equals(value, _Positions)) return;
				_Positions = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Position> _Positions;

    }
}
