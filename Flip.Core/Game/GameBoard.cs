using System.Collections.Generic;
using Flip.Core.Game.GameObjects.Objects;
using Flip.Core.Game.GameObjects.Projectiles;
using Flip.Core.Game.GameObjects.Tiles;

namespace Flip.Core.Game
{
    public class GameBoard
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public TileBase[,] TileGrid { get; set; }

        public ObjectBase[,] ObjectGrid { get; set; }

        public List<ProjectileBase> Projectiles { get; set; }

        public GameBoard(int width, int height)
        {
            Width = width;
            Height = height;

            TileGrid = new TileBase[width, height];
            ObjectGrid = new ObjectBase[width, height];
            Projectiles = new List<ProjectileBase>();
        }
    }
}
