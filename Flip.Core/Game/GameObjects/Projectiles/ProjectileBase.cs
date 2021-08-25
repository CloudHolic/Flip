namespace Flip.Core.Game.GameObjects.Projectiles
{
    public abstract class ProjectileBase : IGameObject
    {
        public string[] Sprites { get; set; }

        private int _orientation;
        public int Orientation
        {
            get => _orientation;
            set => _orientation = value < 0 ? 0 : value > 360 ? 360 : _orientation;
        }
    }
}
