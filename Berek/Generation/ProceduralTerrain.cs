namespace Berek.Generation;

using Berek.CoreClasses;
using Berek.Data;
using Berek.Render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class ProceduralTerrain
{
    public static List<TerrainChunk> Chunks { get; set; } = new();

    public static void InitializeTerrain()
    {
        Chunks.Clear();

        Vector2 startPos = Player.ActivePlayer.Position;

        for(int i = 0; i < Board.Size.X / 2; i++)
        {
            TerrainChunk chunk = new TerrainChunk();
            Chunks.Add(chunk);

            chunk.DisplaySign = "[]";

            int height = (int)((float)Perlin.OctavePerlin(0.5, 0.5, i, 1, 1) * 10);


			chunk.Position = startPos + new Vector2(i, 0);
        }
    }
}
