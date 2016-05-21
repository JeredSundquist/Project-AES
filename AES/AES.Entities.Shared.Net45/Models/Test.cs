namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("Test")]
    public partial class Test : EntityBase
    {
		public int TestId
		{ 
			get { return _TestId; }
			set
			{
				if (Equals(value, _TestId)) return;
				_TestId = value;
				NotifyPropertyChanged();
			}
		}
		private int _TestId;

		public string TestName
		{ 
			get { return _TestName; }
			set
			{
				if (Equals(value, _TestName)) return;
				_TestName = value;
				NotifyPropertyChanged();
			}
		}
		private string _TestName;

        public int? PositionId
		{ 
			get { return _PositionId; }
			set
			{
				if (Equals(value, _PositionId)) return;
				_PositionId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _PositionId;

		public int? QaId01
		{ 
			get { return _QaId01; }
			set
			{
				if (Equals(value, _QaId01)) return;
				_QaId01 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId01;

		public int? QaId02
		{ 
			get { return _QaId02; }
			set
			{
				if (Equals(value, _QaId02)) return;
				_QaId02 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId02;

		public int? QaId03
		{ 
			get { return _QaId03; }
			set
			{
				if (Equals(value, _QaId03)) return;
				_QaId03 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId03;

		public int? QaId04
		{ 
			get { return _QaId04; }
			set
			{
				if (Equals(value, _QaId04)) return;
				_QaId04 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId04;

		public int? QaId05
		{ 
			get { return _QaId05; }
			set
			{
				if (Equals(value, _QaId05)) return;
				_QaId05 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId05;

		public int? QaId06
		{ 
			get { return _QaId06; }
			set
			{
				if (Equals(value, _QaId06)) return;
				_QaId06 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId06;

		public int? QaId07
		{ 
			get { return _QaId07; }
			set
			{
				if (Equals(value, _QaId07)) return;
				_QaId07 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId07;

		public int? QaId08
		{ 
			get { return _QaId08; }
			set
			{
				if (Equals(value, _QaId08)) return;
				_QaId08 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId08;

		public int? QaId09
		{ 
			get { return _QaId09; }
			set
			{
				if (Equals(value, _QaId09)) return;
				_QaId09 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId09;

		public int? QaId10
		{ 
			get { return _QaId10; }
			set
			{
				if (Equals(value, _QaId10)) return;
				_QaId10 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId10;

		public int? QaId11
		{ 
			get { return _QaId11; }
			set
			{
				if (Equals(value, _QaId11)) return;
				_QaId11 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId11;

		public int? QaId12
		{ 
			get { return _QaId12; }
			set
			{
				if (Equals(value, _QaId12)) return;
				_QaId12 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId12;

		public int? QaId13
		{ 
			get { return _QaId13; }
			set
			{
				if (Equals(value, _QaId13)) return;
				_QaId13 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId13;

		public int? QaId14
		{ 
			get { return _QaId14; }
			set
			{
				if (Equals(value, _QaId14)) return;
				_QaId14 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId14;

		public int? QaId15
		{ 
			get { return _QaId15; }
			set
			{
				if (Equals(value, _QaId15)) return;
				_QaId15 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId15;

		public int? QaId16
		{ 
			get { return _QaId16; }
			set
			{
				if (Equals(value, _QaId16)) return;
				_QaId16 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId16;

		public int? QaId17
		{ 
			get { return _QaId17; }
			set
			{
				if (Equals(value, _QaId17)) return;
				_QaId17 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId17;

		public int? QaId18
		{ 
			get { return _QaId18; }
			set
			{
				if (Equals(value, _QaId18)) return;
				_QaId18 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId18;

		public int? QaId19
		{ 
			get { return _QaId19; }
			set
			{
				if (Equals(value, _QaId19)) return;
				_QaId19 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId19;

		public int? QaId20
		{ 
			get { return _QaId20; }
			set
			{
				if (Equals(value, _QaId20)) return;
				_QaId20 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId20;

		public int? QaId21
		{ 
			get { return _QaId21; }
			set
			{
				if (Equals(value, _QaId21)) return;
				_QaId21 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId21;

		public int? QaId22
		{ 
			get { return _QaId22; }
			set
			{
				if (Equals(value, _QaId22)) return;
				_QaId22 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId22;

		public int? QaId23
		{ 
			get { return _QaId23; }
			set
			{
				if (Equals(value, _QaId23)) return;
				_QaId23 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId23;

		public int? QaId24
		{ 
			get { return _QaId24; }
			set
			{
				if (Equals(value, _QaId24)) return;
				_QaId24 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId24;

		public int? QaId25
		{ 
			get { return _QaId25; }
			set
			{
				if (Equals(value, _QaId25)) return;
				_QaId25 = value;
				NotifyPropertyChanged();
			}
		}
		private int? _QaId25;

		public int PassingScore
		{ 
			get { return _PassingScore; }
			set
			{
				if (Equals(value, _PassingScore)) return;
				_PassingScore = value;
				NotifyPropertyChanged();
			}
		}
		private int _PassingScore;

		public int TotalScore
		{ 
			get { return _TotalScore; }
			set
			{
				if (Equals(value, _TotalScore)) return;
				_TotalScore = value;
				NotifyPropertyChanged();
			}
		}
		private int _TotalScore;
    }
}
