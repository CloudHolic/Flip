namespace Flip.Core.Game.GameObjects.Objects
{
    public abstract class ObjectBase : IGameObject
    {
        public string[] Sprites { get; set; }

        private int _orientation;
        public virtual int Orientation
        {
            get => _orientation;
            set => _orientation = value < 0 ? 0 : value > 360 ? 360 : _orientation;
        }
    }
}
