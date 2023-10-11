namespace Berek.CoreClasses;

using Berek.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class GameObject
{
	public static List<GameObject> GameObjects { get; private set; } = new();
	public Vector2 Position { get; set; }
    public Vector2 Scale { get; set; }
    public string DisplaySign { get; set; }
	public bool IsPlayer { get; protected set; }
    public GameObject()
	{
		GameObjects.Add(this);
		DisplaySign = "  ";
	}
	public static void StartAll()
	{
		foreach(GameObject gameObject in GameObjects)
		{
			gameObject.OriginStart();
			gameObject.Start();
		}
	}
	public static void UpdateAll()
	{
		foreach(GameObject gameObject in GameObjects)
		{
			gameObject.Update();
		}
	}
	private void OriginStart()
	{

	}
	protected virtual void Start() { }
	protected virtual void Update() { }
}
