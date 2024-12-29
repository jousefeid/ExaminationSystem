using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
	class TFQuestion : Question
	{
		public override string Header => "TF Question";
        public TFQuestion()
        {
			AnswerList = new Answer[2];
			AnswerList[0] = new Answer(1, "true");
			AnswerList[1] = new Answer(2, "false");
        }

        public override void AddQuestion()
		{
            //Header
            Console.WriteLine(Header);
			//Body
			Console.WriteLine("Enter Body of Question");
			Body = Console.ReadLine();
			//Mark
			int mark;
			do
			{
				Console.WriteLine("Enter Mark ");
			}
			while (!int.TryParse(Console.ReadLine(), out mark));
			Mark = mark;
		}

		//Right Ansewer

	}
}
