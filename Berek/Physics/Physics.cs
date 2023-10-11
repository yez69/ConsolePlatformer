using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek.Physics
{
	internal class Physics
	{
		private static readonly List<Physics> physics = new();
		public const int gravity = 1;
		public Physics()
		{
			physics.Add(this);
		}
		public static void Update() 
		{
			
		}
	}
}
