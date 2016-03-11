namespace JobLibrarySVC.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("Answer")]
    public partial class Answer : EntityBase
    {
        public Answer()
        {
            Questions = new ChangeTrackingCollection<Question>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int AnswerId
		{ 
			get { return _AnswerId; }
			set
			{
				if (Equals(value, _AnswerId)) return;
				_AnswerId = value;
				NotifyPropertyChanged();
			}
		}
		private int _AnswerId;

        [Required]
		public string CorrectAnswer
		{ 
			get { return _CorrectAnswer; }
			set
			{
				if (Equals(value, _CorrectAnswer)) return;
				_CorrectAnswer = value;
				NotifyPropertyChanged();
			}
		}
		private string _CorrectAnswer;

		public ChangeTrackingCollection<Question> Questions
		{
			get { return _Questions; }
			set
			{
				if (Equals(value, _Questions)) return;
				_Questions = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Question> _Questions;
    }
}
