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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

		public string Question
		{ 
			get { return _Question; }
			set
			{
				if (Equals(value, _Question)) return;
				_Question = value;
				NotifyPropertyChanged();
			}
		}
		private string _Question;

		public string MC_Possible_Answer_1
		{ 
			get { return _MC_Possible_Answer_1; }
			set
			{
				if (Equals(value, _MC_Possible_Answer_1)) return;
				_MC_Possible_Answer_1 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_Possible_Answer_1;

		public bool MC_Answer_1_Selected
		{ 
			get { return _MC_Answer_1_Selected; }
			set
			{
				if (Equals(value, _MC_Answer_1_Selected)) return;
				_MC_Answer_1_Selected = value;
				NotifyPropertyChanged();
			}
		}
		private bool _MC_Answer_1_Selected;

		public string MC_Possible_Answer_2
		{ 
			get { return _MC_Possible_Answer_2; }
			set
			{
				if (Equals(value, _MC_Possible_Answer_2)) return;
				_MC_Possible_Answer_2 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_Possible_Answer_2;

		public bool MC_Answer_2_Selected
		{ 
			get { return _MC_Answer_2_Selected; }
			set
			{
				if (Equals(value, _MC_Answer_2_Selected)) return;
				_MC_Answer_2_Selected = value;
				NotifyPropertyChanged();
			}
		}
		private bool _MC_Answer_2_Selected;

		public string MC_Possible_Answer_3
		{ 
			get { return _MC_Possible_Answer_3; }
			set
			{
				if (Equals(value, _MC_Possible_Answer_3)) return;
				_MC_Possible_Answer_3 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_Possible_Answer_3;

		public bool MC_Answer_3_Selected
		{ 
			get { return _MC_Answer_3_Selected; }
			set
			{
				if (Equals(value, _MC_Answer_3_Selected)) return;
				_MC_Answer_3_Selected = value;
				NotifyPropertyChanged();
			}
		}
		private bool _MC_Answer_3_Selected;

		public string MC_Possible_Answer_4
		{ 
			get { return _MC_Possible_Answer_4; }
			set
			{
				if (Equals(value, _MC_Possible_Answer_4)) return;
				_MC_Possible_Answer_4 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_Possible_Answer_4;

		public bool MC_Answer_4_Selected
		{ 
			get { return _MC_Answer_4_Selected; }
			set
			{
				if (Equals(value, _MC_Answer_4_Selected)) return;
				_MC_Answer_4_Selected = value;
				NotifyPropertyChanged();
			}
		}
		private bool _MC_Answer_4_Selected;

		public string MC_Possible_Answer_5
		{ 
			get { return _MC_Possible_Answer_5; }
			set
			{
				if (Equals(value, _MC_Possible_Answer_5)) return;
				_MC_Possible_Answer_5 = value;
				NotifyPropertyChanged();
			}
		}
		private string _MC_Possible_Answer_5;

		public bool MC_Answer_5_Selected
		{ 
			get { return _MC_Answer_5_Selected; }
			set
			{
				if (Equals(value, _MC_Answer_5_Selected)) return;
				_MC_Answer_5_Selected = value;
				NotifyPropertyChanged();
			}
		}
		private bool _MC_Answer_5_Selected;

		public int? MC_Answer_Num_Selected
		{ 
			get { return _MC_Answer_Num_Selected; }
			set
			{
				if (Equals(value, _MC_Answer_Num_Selected)) return;
				_MC_Answer_Num_Selected = value;
				NotifyPropertyChanged();
			}
		}
		private int? _MC_Answer_Num_Selected;

		public int? MC_Correct_Answer_Num
		{ 
			get { return _MC_Correct_Answer_Num; }
			set
			{
				if (Equals(value, _MC_Correct_Answer_Num)) return;
				_MC_Correct_Answer_Num = value;
				NotifyPropertyChanged();
			}
		}
		private int? _MC_Correct_Answer_Num;

		public bool TF_Answer
		{ 
			get { return _TF_Answer; }
			set
			{
				if (Equals(value, _TF_Answer)) return;
				_TF_Answer = value;
				NotifyPropertyChanged();
			}
		}
		private bool _TF_Answer;

        [Required]
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

		public int QuestionType
		{ 
			get { return _QuestionType; }
			set
			{
				if (Equals(value, _QuestionType)) return;
				_QuestionType = value;
				NotifyPropertyChanged();
			}
		}
		private int _QuestionType;
    }
}
