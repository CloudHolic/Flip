namespace Flip.Core.Game.GameObjects
{
    public interface IGameObject
    {
        public string[] Sprites { get; set; }
        
        public int Orientation { get; set; }
    }
}
