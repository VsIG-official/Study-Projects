namespace Mazes
{
	public static class DiagonalMazeTask
	{
        private const int HeightOfReversal = 5;

        public static void MoveOut(Robot robot, int width, int height)
        {
            int horizontalMovement = (width - 2) / (height - 2);
            int verticalMovement = (height - 2) / (width - 2);

            if (width > height)
            {
                MoveTo(robot, Direction.Right, horizontalMovement);
            }
            else
            {
                MoveTo(robot, Direction.Down, verticalMovement);
            }

            //for (var i = 0; i < reversalAmount + 1; i++)
            //{
            //    MoveTo(robot, GetDirection(i), width);

            //    if (i != reversalAmount)
            //    {
            //        MoveTo(robot, Direction.Down, HeightOfReversal);
            //    }
            //}
        }

        private static Direction GetDirection(int reversalAmount)
        {
            return reversalAmount % 2 == 0 ? Direction.Right : Direction.Left;
        }

        private static void MoveTo(Robot robot, Direction dir, int mazeBounds)
        {
            for (var i = 0; i < mazeBounds; i++)
            {
                robot.MoveTo(dir);
            }
        }
    }
}
