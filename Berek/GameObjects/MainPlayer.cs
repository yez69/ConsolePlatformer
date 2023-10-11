namespace Berek.GameObjects;

using Berek.CoreClasses;
using Berek.Input;
using Berek.Data;

internal class MainPlayer : Player
{
	public int Step { get; private set; }
	public int JumpHeight { get; private set; }
	public MainPlayer()
	{
		Position = new Vector2(2, 0);
		DisplaySign = "* ";
		Step = 1;
		JumpHeight = 2;
	}
	protected override void Update()
	{ 
		switch (Console.ReadKey().KeyChar)
		{
			case 'w':
				Position += new Vector2(-Step, 0);
				break;
			case 's':
				Position += new Vector2(Step, 0);
				break;
			case 'd':
				Position += new Vector2(0, Step);
				break;
			case 'a':
				Position += new Vector2(0, -Step);
				break;
		}

		Console.Clear();
	}
}
