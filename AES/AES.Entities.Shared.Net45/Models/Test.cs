using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrackableEntities.Client;

namespace AES.Entities.Shared.Net45.Models
{
    [Table("Test")]

    public partial class Test : EntityBase
    {

        public Test()
        {

            Positions = new ChangeTrackingCollection<Position>();

        }


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


		public string QuestionList
		{ 
			get { return _QuestionList; }
			set
			{
				if (Equals(value, _QuestionList)) return;
				_QuestionList = value;
				NotifyPropertyChanged();
			}
		}
		private string _QuestionList;


		public int? passingScore
		{ 
			get { return _passingScore; }
			set
			{
				if (Equals(value, _passingScore)) return;
				_passingScore = value;
				NotifyPropertyChanged();
			}
		}
		private int? _passingScore;


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
