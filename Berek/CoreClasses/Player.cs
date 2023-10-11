namespace Berek.CoreClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player : GameObject
{
    public static Player ActivePlayer { get; private set; }
    public static List<Player> PlayerList { get; private set; } = new List<Player>();
    public Player()
    {
        if(PlayerList.Count == 0)
        {
            ActivePlayer = this;
        }
        PlayerList.Add(this);
        IsPlayer = true;
    }
}
