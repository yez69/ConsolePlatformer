namespace Berek.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berek.CoreClasses;
using Berek.Data;

internal class Point : GameObject
{
	public Point(Vector2 position, string display)
	{
		Position = position;
		DisplaySign = display;
	}
}
