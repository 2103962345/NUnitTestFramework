using System;
using System.Text;

namespace Test
{
	public class Student
	{
		private string name;
		private int id;
		private int score_course1;
		private int score_course2;

		public string getName()
		{
			return name;	
		}

		public int getId()
		{
			return id;
		}
			
		// Constructor with all four variables initialized
		public Student(string init_name, int init_id, int init_s1, int init_s2)
		{
			this.name = init_name;
			this.id = init_id;
			this.score_course1 = init_s1;
			this.score_course2 = init_s2;
		}

		// Constructor with name and id initialized
		public Student(string init_name, int init_id)
		{
			this.name = init_name;
			this.id = init_id;
		}

		// Returns length of name
		public int funLength()
		{
			string input;
			input = this.name;
			return input.Length;
		}

		// returns 
		public int Total_score()
		{
			return score_course1+score_course2;
		}
	}
}

