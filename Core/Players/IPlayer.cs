namespace Core.Players
{
    public interface IPlayer
    {
        Color Color { get; }
        Move MakeMove();
    }
}
