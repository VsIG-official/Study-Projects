namespace Mazes
{
	public static class SnakeMazeTask
	{
        private const int HeightOfReversal =5;

        public static void MoveOut(Robot robot, int width, int height)
		{
            int reversalAmount = (height - 2) / 2;

            for (var i = 0; i < reversalAmount + 1; i++)
            {
                MoveTo(robot, GetDirection(i), width);

                if (i != reversalAmount)
                {
                    MoveTo(robot, Direction.Down, HeightOfReversal);
                }
            }
        }

        private static Direction GetDirection(int reversalAmount)
        {
            return reversalAmount % 2 == 0 ? Direction.Right : Direction.Left;
        }

        private static void MoveTo(Robot robot, Direction dir, int mazeBounds)
        {
            for (var i = 0; i < mazeBounds - 3; i++)
            {
                robot.MoveTo(dir);
            }
        }
    }
}
