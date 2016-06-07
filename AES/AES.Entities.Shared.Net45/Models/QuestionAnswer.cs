namespace AES.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
	using TrackableEntities.Client;

    [Table("QuestionAnswer")]
    public partial class QuestionAnswer : EntityBase
    {
		public int QuestionAnswerId
		{ 
			get { return _QuestionAnswerId; }
			set
			{
				if (Equals(value, _QuestionAnswerId)) return;
				_QuestionAnswerId = value;
				NotifyPropertyChanged();
			}
		}
		private int _QuestionAnswerId;

        [Required]
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

        [Required]
        [StringLength(1)]
		public string QuestionType
		{ 
			get { return _QuestionType; }
			set
			{
				if (Equals(value, _QuestionType)) return;
				_QuestionType = value;
				NotifyPropertyChanged();
			}
		}
		private string _QuestionType;

		public string MC_AnswerText1
		{ 
			get { return _MC_AnswerText1; }
			set
			{
				if (Equals(value, _MC_AnswerText1)) return;
				_MC_AnswerText1 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_AnswerText1;

		public string MC_AnswerText2
		{ 
			get { return _MC_AnswerText2; }
			set
			{
				if (Equals(value, _MC_AnswerText2)) return;
				_MC_AnswerText2 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_AnswerText2;

		public string MC_AnswerText3
		{ 
			get { return _MC_AnswerText3; }
			set
			{
				if (Equals(value, _MC_AnswerText3)) return;
				_MC_AnswerText3 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_AnswerText3;

		public string MC_AnswerText4
		{ 
			get { return _MC_AnswerText4; }
			set
			{
				if (Equals(value, _MC_AnswerText4)) return;
				_MC_AnswerText4 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_AnswerText4;

		public string MC_AnswerText5
		{ 
			get { return _MC_AnswerText5; }
			set
			{
				if (Equals(value, _MC_AnswerText5)) return;
				_MC_AnswerText5 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_AnswerText5;

		public string WI_Answer
		{ 
			get { return _WI_Answer; }
			set
			{
				if (Equals(value, _WI_Answer)) return;
				_WI_Answer = value;
				NotifyPropertyChanged();
			}
		}
		private string _WI_Answer;

		public bool? TrueFalse
		{ 
			get { return _TrueFalse; }
			set
			{
				if (Equals(value, _TrueFalse)) return;
				_TrueFalse = value;
				NotifyPropertyChanged();
			}
		}
		private bool? _TrueFalse;

        [StringLength(1)]
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
    }
}
