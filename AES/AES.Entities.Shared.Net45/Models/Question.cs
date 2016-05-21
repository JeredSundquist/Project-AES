










namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;


    [Table("Question")]

    public partial class Question : EntityBase
    {

		public int QuestionId
		{ 
			get { return _QuestionId; }
			set
			{
				if (Equals(value, _QuestionId)) return;
				_QuestionId = value;
				NotifyPropertyChanged();
			}
		}
		private int _QuestionId;


        [Column("Question")]

		public string Question1
		{ 
			get { return _Question1; }
			set
			{
				if (Equals(value, _Question1)) return;
				_Question1 = value;
				NotifyPropertyChanged();
			}
		}
		private string _Question1;


        [StringLength(10)]

		public string QuestionText
		{ 
			get { return _QuestionText; }
			set
			{
				if (Equals(value, _QuestionText)) return;
				_QuestionText = value;
				NotifyPropertyChanged();
			}
		}
		private string _QuestionText;


		public int? AnswerId
		{ 
			get { return _AnswerId; }
			set
			{
				if (Equals(value, _AnswerId)) return;
				_AnswerId = value;
				NotifyPropertyChanged();
			}
		}
		private int? _AnswerId;



		public Answer Answer
		{
			get { return _Answer; }
			set
			{
				if (Equals(value, _Answer)) return;
				_Answer = value;
				AnswerChangeTracker = _Answer == null ? null
					: new ChangeTrackingCollection<Answer> { _Answer };
				NotifyPropertyChanged();
			}
		}
		private Answer _Answer;
		private ChangeTrackingCollection<Answer> AnswerChangeTracker { get; set; }

    }
}
