namespace Pong
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ball = new Ball(25, 15, 1, 1);
            var game = new Game(ball);
            game.Run();
        }
    }
}