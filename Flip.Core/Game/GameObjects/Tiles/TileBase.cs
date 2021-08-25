namespace Flip.Core.Game.GameObjects.Tiles
{
    public abstract class TileBase : IGameObject
    {
        public string[] Sprites { get; set; }

        private int _orientation;
        public int Orientation 
        {
            get => _orientation;
            set => _orientation = value < 0 ? 0 : value > 270 ? 270 : (_orientation + 45) / 90 * 90;
        }
    }
}
