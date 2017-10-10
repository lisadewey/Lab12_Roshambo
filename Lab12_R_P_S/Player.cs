using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_R_P_S
{
	public abstract class Player
	{
		//public enum Roshambo { Rock, Paper, Scissors }
		public List<string> rps = new List<string>()
		{
			"Rock",
			"Paper",
			"Scissors"
		};

		public string name;
		public string value;

		public abstract void GenerateRoshambo();
	}

}
