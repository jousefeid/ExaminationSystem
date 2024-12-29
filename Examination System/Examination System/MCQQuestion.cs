using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
	class MCQQuestion : Question
	{
		public override string Header => "MCQ Question ";
        public MCQQuestion()
        {
			AnswerList = new Answer[3];
        }
        public override void AddQuestion()
		{
            Console.WriteLine(Header);
            //body
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

            //Choices
            Console.WriteLine("Enter Choice");

            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answer
                {
                    AnserId = i + 1
                };
				Console.WriteLine($"Enter Choice Number {i+1}");
                AnswerList[i].AnswerText = Console.ReadLine();
			}

            //Right Answer
            int rightAnswer;
            do
            {
                Console.WriteLine("Enter Id of Right Answer");
            }
            while (!int.TryParse(Console.ReadLine(), out rightAnswer) && rightAnswer < 1 || rightAnswer > 3);
            
            RightAnswer.AnserId = rightAnswer;
            RightAnswer.AnswerText = AnswerList[rightAnswer-1].AnswerText;
            Console.Clear();

        }
	}
}
