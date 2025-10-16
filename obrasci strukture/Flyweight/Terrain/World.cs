using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Terrain
{
    public class World
    {
        TerrainTile[,] worldTiles;
        private World(TerrainTile[,] worldTiles)
        {
            this.worldTiles = worldTiles;
        }
        public override string ToString()
        {
            int rows = worldTiles.GetLength(0);
            int cols = worldTiles.GetLength(1);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    builder.Append(worldTiles[i, j].ToString());
                }
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }
        public TerrainTile GetTile(int i, int j) { return worldTiles[i, j]; }
        public static World Generate(int width, int height, ITerrainRepository repository)
        {
            TerrainTile[,] tiles = new TerrainTile[width, height];
            for (int i = 0; i < width;i++)
            {
                for (int j = 0; j < height;j++)
                {
                    tiles[i, j] = new TerrainTile(i, j, repository.GetRandomTerrain());
                }
            }
            return new World(tiles);
        }
    }
}
