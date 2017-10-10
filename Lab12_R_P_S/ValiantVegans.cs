using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_R_P_S
{
	public class ValiantVegans : Player
	{
		public override void GenerateRoshambo()
		{
			int seed = (int)DateTime.Now.Ticks;
			Random random = new Random(seed);

			int num = random.Next(0, 3);
			value = rps[num];

			//if (num == 1)
			//{
			//	value = Roshambo.Rock;
			//}
			//else if (num == 2)
			//{
			//	value = Roshambo.Paper;
			//}
			//else
			//{
			//	value = Roshambo.Scissors;
			//}
		}
	}
}
