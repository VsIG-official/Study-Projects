namespace GraphSearching
{
	/// <summary>
	/// Info about a node along a search path
	/// </summary>
	/// <typeparam name="T">type stored in graph node</typeparam>
	class PathNodeInfo<T>
	{
		#region Fields

		GraphNode<T> previous;
		float weight;

		#endregion

		#region Constructors

		/// <summary>
		/// Creates an info node with the given previous node
		/// </summary>
		/// <param name="previous">previous node in path</param>
		/// <param name="weight">weight of the edge to the previous node</param>
		public PathNodeInfo(GraphNode<T> previous, float weight)
		{
			this.previous = previous;
			this.weight = weight;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the previous graph node in the path
		/// </summary>
		public GraphNode<T> Previous
		{
			get { return previous; }
		}

		/// <summary>
		/// Gets the weight of the edge to the previous node
		/// </summary>
		public float Weight
		{
			get { return weight; }
		}

		#endregion
	}
}
