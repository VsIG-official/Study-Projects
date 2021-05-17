using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// A traveler
/// </summary>
public class Traveler : MonoBehaviour
{
	#region Fields
	
    // needed for the PathLength property
    float pathLength = 0;
	
    // events fired by class
    PathFoundEvent pathFoundEvent = new PathFoundEvent();
    PathTraversalCompleteEvent pathTraversalCompleteEvent = new PathTraversalCompleteEvent();

	#endregion

	#region Constructor

	// Uncomment the code below after you copy this class into the console
	// app for the automated grader. DON'T uncomment it now; it won't
	// compile in a Unity project

	/// <summary>
	/// Constructor
	/// 
	/// Note: The Traveler class in the Unity solution doesn't 
	/// use a constructor; this constructor is to support automated grading
	/// </summary>
	/// <param name="gameObject">the game object the script is attached to</param>
	//public Traveler(GameObject gameObject) :
	//    base(gameObject)
	//{
	//}

	#endregion
	
    #region Properties

    /// <summary>
    /// Gets the length of the final path
    /// 
    /// NOTE: This property should only be accessed after the
    /// Start method has been called (which is always the case
    /// in Unity)
    /// </summary>
    public float PathLength
    {
        get { return pathLength; }
    }

    #endregion
	
	#region Unity methods

	/// <summary>
	/// Use this for initialization
	/// 
	/// Note: Leave this method public to support automated grading
	/// </summary>
	public void Start()
	{
		
	}
	
	#endregion
	
	#region Public methods
	
    /// <summary>
    /// Adds the given listener for the PathFoundEvent
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddPathFoundListener(UnityAction<float> listener)
    {
        pathFoundEvent.AddListener(listener);
    }

    /// <summary>
    /// Adds the given listener for the PathTraversalCompleteEvent
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddPathTraversalCompleteListener(UnityAction listener)
    {
        pathTraversalCompleteEvent.AddListener(listener);
    }

	/// <summary>
	/// Does a search for a path from start to end on
	/// graph
	/// 
	/// Note: Leave this method public to support automated grading
	/// </summary>
	/// <param name="start">start value</param>
	/// <param name="finish">finish value</param>
	/// <param name="graph">graph to search</param>
	/// <returns>string for path or empty string if there is no path</returns>
	public LinkedList<Waypoint> Search(Waypoint start, Waypoint end,
        Graph<Waypoint> graph)
    {
		// Create a search list (a sorted linked list) of search nodes 
		// (I provided a SearchNode class, which you should instantiate 
		// with Waypoint. I also provided a SortedLinkedList class)

			
		// Create a dictionary of search nodes keyed by the corresponding 
		// graph node. This dictionary gives us a very fast way to determine 
		// if the search node corresponding to a graph node is still in the 
		// search list


        // Save references to the start and end graph nodes in variables


        // for each graph node in the graph

			// Create a search node for the graph node (the constructor I 
			// provided in the SearchNode class initializes distance to the max
			// float value and previous to null)

			
			// If the graph node is the start node

				// Set the distance for the search node to 0

			
			// Add the search node to the search list 

			
			// Add the search node to the dictionary keyed by the graph node


        // While the search list isn't empty

			// Save a reference to the current search node (the first search 
			// node in the search list) in a variable. We do this because the
			// front of the search list has the smallest distance

			
			// Remove the first search node from the search list

			
			// Save a reference to the current graph node for the current search
			// node in a variable

            
			// Remove the search node from the dictionary (because it's no 
			// longer in the search list)

			
            // If the current graph node is the end node

				// Display the distance for the current search node as the path 
				// length in the scene (Hint: I used the HUD and the event 
				// system to do this)
				
				// Return a linked list of the waypoints from the start node to 
				// the end node. Uncomment the line of code below, replacing
				// the argument with the name of your current search node
				// variable; you MUST do this for the autograder to work
				// return BuildWaypointPath(currentSearchNode);

				
            // For each of the current graph node's neighbors


				// If the neighbor is still in the search list (use the 
				// dictionary to check this)


					// Save the distance for the current graph node + the weight 
					// of the edge from the current graph node to the current 
					// neighbor in a variable

					
					// Retrieve the neighor search node from the dictionary
					// using the neighbor graph node

					
					// If the distance you just calculated is less than the 
					// current distance for the neighbor search node

					
						// Set the distance for the neighbor search node to 
						// the new distance

						
						// Set the previous node for the neighbor search node 
						// to the current search node

						
						// Tell the search list to Reposition the neighbor 
						// search node. We need to do this because the change 
						// to the distance for the neighbor search node could 
						// have moved it forward in the search list
			

        // didn't find a path from start to end nodes
        return null;
    }

	#endregion
	
	#region Private methods
	
    /// <summary>
    /// Builds a waypoint path from the start node to the given end node
    /// Side Effect: sets the pathLength field
    /// 
    /// CAUTION: Do NOT change this method; if you do, you'll break the autograder
    /// </summary>
    /// <returns>waypoint path</returns>
    /// <param name="endNode">end node</param>
    LinkedList<Waypoint> BuildWaypointPath(SearchNode<Waypoint> endNode)
    {
        LinkedList<Waypoint> path = new LinkedList<Waypoint>();
        path.AddFirst(endNode.GraphNode.Value);
        pathLength = endNode.Distance;
        SearchNode<Waypoint> previous = endNode.Previous;
        while (previous != null)
        {
            path.AddFirst(previous.GraphNode.Value);
            previous = previous.Previous;
        }

        return path;
    }
	
	#endregion
}
