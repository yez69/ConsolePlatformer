namespace Berek.Render;

using Berek.CoreClasses;
using Berek.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class Board
{
    public static Vector2 Size { get; private set; } = new Vector2(40, 40);
    public static string[,] BoardArray { get; private set; } = new string[(int)Size.Y + 2, (int)Size.X + 2];
    private static readonly Vector2 PlayerDisplayPosition = new Vector2((int)Size.Y / 2 + 1, (int)Size.X / 2 + 1);
    public static void Update()
    {
        for(int y = 0; y < Size.Y + 2; y++)
        {
            for (int x = 0; x < Size.X + 2; x++)
            {
                List<GameObject> gos = GameObject.GameObjects.Where(go => go.Position == new Vector2(x + Player.ActivePlayer.Position.Y - PlayerDisplayPosition.X,
                    y + Player.ActivePlayer.Position.X - PlayerDisplayPosition.Y) && !go.IsPlayer).ToList();
                
				if (gos.Count == 0)
                {
                    BoardArray[y, x] = "  ";
                }

                if (gos.Count > 1) 
                {
                    BoardArray[y, x] = gos.Count.ToString();
                }

                foreach (GameObject go in gos)
                {
                    BoardArray[y, x] = go.DisplaySign;
                }

                //if(Player.ActivePlayer.Position == new Vector2(y, x))
                //{
                //    BoardArray[y, x] = Player.ActivePlayer.DisplaySign;
                //}
                BoardArray[(int)PlayerDisplayPosition.Y, (int)PlayerDisplayPosition.X] = Player.ActivePlayer.DisplaySign;

                if (y == 0 || y == Size.Y + 1)
                {
                    BoardArray[y, x] = "--";
                }

				if (x == 0 || x == Size.X + 1)
				{
					BoardArray[y, x] = "|";
				}

				Console.Write(BoardArray[y, x]);
            }
            Console.WriteLine();
        }
    }
}
