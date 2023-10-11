namespace Berek.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal struct Vector2
{
    public float X { get; set; }
    public float Y { get; set; }
    public Vector2(float x, float y)
    {
        X = x;
        Y = y;
    }
    public float Magnitude { 
        get
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }
    }
    public Vector2 Normalized { 
        get 
        {
            return new Vector2(X, Y) / Magnitude;
        } 
    }
    public float LengthSquared() { return X * X + Y * Y; }
    public void Normalize() { X /= Magnitude; Y /= Magnitude; }
    public static Vector2 operator -(Vector2 v) => new Vector2(-v.X, -v.Y);
    public static Vector2 operator +(Vector2 v1, Vector2 v2) => new Vector2(v1.X + v2.X, v1.Y + v2.Y);
	public static Vector2 operator -(Vector2 v1, Vector2 v2) => new Vector2(v2.X = v2.X, v1.Y = v2.Y);
    public static Vector2 operator /(Vector2 v1, Vector2 v2) => new Vector2(v1.X / v2.X, v1.Y / v2.Y);
    public static Vector2 operator /(float v1, Vector2 v2) => new Vector2(v2.X / v1, v2.Y / v1);
	public static Vector2 operator /(Vector2 v2, float v1) => new Vector2(v2.X / v1, v2.Y / v1);
	public static bool operator ==(Vector2 v1, Vector2 v2) => v1.X == v2.X && v1.Y == v2.Y;
	public static bool operator !=(Vector2 v1, Vector2 v2) => !(v1.X == v2.X && v1.Y == v2.Y);
    public static float Dot(Vector2 v1, Vector2 v2) => v1.X * v2.X + v1.Y * v2.Y;
}
