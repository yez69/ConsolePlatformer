using Berek.CoreClasses;
using Berek.GameObjects;
using Berek.Render;
using Berek.Data;
using Berek.Generation;

MainPlayer player = new();
//Point point = new(new Vector2(0, 0), "> ");
//Point point2 = new(new Vector2(1, 0), "$ ");
//Point point3 = new(new Vector2(2, 0), "$ ");

ProceduralTerrain.InitializeTerrain();

GameObject.StartAll();
MonoBehaviour.StartAll();

while (true)
{
	Board.Update();
	GameObject.UpdateAll();
	MonoBehaviour.UpdateAll();
}

//int[] noise = new int[20]; 

//for(int i = 0; i < 20; i++)
//{
//	noise[i] = (int)((float)Perlin.OctavePerlin(0.5, 0.5, i, 1, 1) * 10);
//}

//foreach(float ele in noise)
//{
//	Console.WriteLine(ele);
//}

