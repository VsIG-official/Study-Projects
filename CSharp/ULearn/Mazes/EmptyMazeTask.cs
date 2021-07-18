namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            MoveBottom(robot, height);
            MoveRight(robot, width);
        }

        private static void MoveBottom(Robot robot, int mazeHeight)
        {
            for (var i = 0; i < mazeHeight - 3; i++)
            {
                robot.MoveTo(Direction.Down);
            }
        }

        private static void MoveRight(Robot robot, int mazeWidth)
        {
            for (var i = 0; i < mazeWidth - 3; i++)
            {
                robot.MoveTo(Direction.Right);
            }
        }
    }
}
