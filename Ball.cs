namespace Pong
{
    internal class Ball
    {
        public int x;
        public int y;
        public int xVelocity;
        public int yVelocity;

        public Ball(int x, int y, int xVelocity, int yVelocity)
        {
            this.x = x;
            this.y = y;
            this.xVelocity = xVelocity;
            this.yVelocity = yVelocity;
        }

        public void HitHorizontalWall()
        {
            xVelocity *= -1;
        }
        public void HitVerticalWall()
        {
            yVelocity *= -1;
        }
    }
}
