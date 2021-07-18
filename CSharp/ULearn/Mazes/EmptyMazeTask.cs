namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            MoveTo(robot, Direction.Down, height);
            MoveTo(robot, Direction.Right, width);
        }

        private static void MoveTo(Robot robot, Direction dir, int mazeBounds)
        {
            for (var i = 0; i < mazeBounds - 3; i++)
            {
                robot.MoveTo(dir);
            }
        }

        //private static void MoveBottom(Robot robot, int mazeHeight)
        //{
        //    for (var i = 0; i < mazeHeight - 3; i++)
        //    {
        //        robot.MoveTo(Direction.Down);
        //    }
        //}

        //private static void MoveRight(Robot robot, int mazeWidth)
        //{
        //    for (var i = 0; i < mazeWidth - 3; i++)
        //    {
        //        robot.MoveTo(Direction.Right);
        //    }
        //}
    }
}
