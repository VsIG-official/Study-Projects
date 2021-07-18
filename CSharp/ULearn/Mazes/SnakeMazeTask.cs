namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            int timesToTurn = (height - 2) / 2;

            for (int i = 0; i < timesToTurn + 1; i++)
            {
                if (i % 2 == 0)
                {
                    MoveTo(robot, Direction.Right, width);
                }
                else
                {
                    MoveTo(robot, Direction.Left, width);
                }

                if (i != timesToTurn)
                {
                    MoveTo(robot, Direction.Down, 5);
                }
            }
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
