using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_R_P_S
{
	public class RoshamboPlayer : Player
	{
		public override void GenerateRoshambo()
		{
			//value = Roshambo.Scissors;
			value = rps[2];
		}
	}
}
