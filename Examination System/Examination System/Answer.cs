using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Answer
    {
        public int AnserId { get; set; }
        public string AnswerText { get; set; }
        public Answer(int _id , string _text)
        {
            AnserId = _id ;
            AnswerText = _text ;
        }
        public Answer() 
        {

        }
		public override string ToString()
		{
			return $"{AnserId} - {AnswerText}";
		}
	}
}
