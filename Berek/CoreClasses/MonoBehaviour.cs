namespace Berek.CoreClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class MonoBehaviour
{
    private static readonly List<MonoBehaviour> monoBehaviours = new();
    public MonoBehaviour()
    {
        monoBehaviours.Add(this);
    }
    public static void StartAll()
    {
        foreach (var monoBehaviour in monoBehaviours)
        {
            monoBehaviour.Start();
        }
    }
    public static void UpdateAll()
    {
        foreach(var monoBehaviour in monoBehaviours)
        {
            monoBehaviour.Update();
        }
    }
    protected virtual void Start() { }
	protected virtual void Update() { }
}
