namespace Pong
{
    internal class Game
    {
        private Ball _ball;
        private int _consoleHeight;
        private int _consoleWidth;
        private int _bounces;
        private int _cornerHits;
        public Game(Ball ball)
        {
            _ball = ball;
            _consoleHeight = Console.WindowHeight - 1;
            _consoleWidth = Console.WindowWidth - 1;
        }

        public void UpdateBall()
        {
            int currentBounces = 0;
            if (_ball.x == 0 || _ball.x == _consoleWidth)
            {
                _ball.HitHorizontalWall();
                currentBounces++;
            }
            if (_ball.y == 0 || _ball.y == _consoleHeight)
            {
                _ball.HitVerticalWall();
                currentBounces++;
            }
            _ball.x += _ball.xVelocity;
            _ball.y += _ball.yVelocity;
            if (currentBounces > 0) _bounces++;
            if (currentBounces == 2) _cornerHits++;
        }

        public void DrawBall()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, _consoleHeight - 5);
            Console.Write("Bounces: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(_bounces.ToString().PadLeft(9, ' '));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, _consoleHeight - 4);
            Console.Write("Corner hits: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_cornerHits.ToString().PadLeft(5, ' '));
            Console.SetCursorPosition(_ball.x, _ball.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("O");
        }

        public void UpdateDimensions()
        {
            _consoleHeight = Console.WindowHeight - 1;
            _consoleWidth = Console.WindowWidth - 1;
        }

        public void Run()
        {
            while (true)
            {
                Console.CursorVisible = false;
                UpdateDimensions();
                Console.SetCursorPosition(_ball.x, _ball.y);
                Console.Write(" ");
                UpdateBall();
                DrawBall();
                Thread.Sleep(50);
            }
        }
    }
}
