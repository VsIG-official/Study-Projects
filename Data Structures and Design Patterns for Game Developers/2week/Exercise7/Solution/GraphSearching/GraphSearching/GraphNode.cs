﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearching
{
     /// <summary>
     /// A graph node
     /// </summary>
     /// <typeparam name="T">type of value stored in node</typeparam>
    class GraphNode<T>
    {
        #region Fields

        T value;
        List<GraphNode<T>> neighbors;
        List<int> weights;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">value for the node</param>
        public GraphNode(T value)
        {
            this.value = value;
            neighbors = new List<GraphNode<T>>();
            weights = new List<int>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the value stored in the node
        /// </summary>
        public T Value
        {
            get { return value; }
        }

        /// <summary>
        /// Gets a read-only list of the neighbors of the node
        /// </summary>
        public IList<GraphNode<T>> Neighbors
        {
            get { return neighbors.AsReadOnly(); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the given node as a neighbor for this node
        /// </summary>
        /// <param name="neighbor">neighbor to add</param>
        /// <param name="weight">weight of edge being added</param>
        /// <returns>true if the neighbor was added, false otherwise</returns>
        public bool AddNeighbor(GraphNode<T> neighbor, int weight)
        {
            // don't add duplicate nodes
            if (neighbors.Contains(neighbor))
            {
                return false;
            }
            else
            {
                neighbors.Add(neighbor);
                weights.Add(weight);
                return true;
            }
        }

        /// <summary>
        /// Gets the weight of the edge from this node to
        /// the given neighbor. If the edge doesn't exist,
        /// throws an InvalidOperationException
        /// </summary>
        /// <param name="neighbor">neighbor</param>
        /// <returns>weight of edge to neighbor</returns>
        public int GetEdgeWeight(GraphNode<T> neighbor)
        {
            // make sure edge exists
            if (!neighbors.Contains(neighbor))
            {
                throw new InvalidOperationException("Trying to retrieve weight of non-existent edge");
            }
            else
            {
                int index = neighbors.IndexOf(neighbor);
                return weights[index];
            }
        }

        /// <summary>
        /// Removes the given node as a neighbor for this node
        /// </summary>
        /// <param name="neighbor">neighbor to remove</param>
        /// <returns>true if the neighbor was removed, false otherwise</returns>
        public bool RemoveNeighbor(GraphNode<T> neighbor)
        {
            // remove weight for neighbor
            int index = neighbors.IndexOf(neighbor);
            if (index == -1)
            {
                // neighbor not in list
                return false;
            }
            else
            {
                // remove neighbor and edge weight
                neighbors.RemoveAt(index);
                weights.RemoveAt(index);
                return true;
            }
        }

        /// <summary>
        /// Removes all the neighbors for the node
        /// </summary>
        /// <returns>true if the neighbors were removed, false otherwise</returns>
        public bool RemoveAllNeighbors()
        {
            for (int i = neighbors.Count - 1; i >= 0; i--)
            {
                neighbors.RemoveAt(i);
            }
            weights.Clear();
            return true;
        }

        /// <summary>
        /// Converts the node to a string
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            StringBuilder nodeString = new StringBuilder();
            nodeString.Append("[Node Value: " + value +
                " Neighbors: ");
            for (int i = 0; i < neighbors.Count; i++)
            {
                nodeString.Append(neighbors[i].Value + " " +
                    "(" + weights[i] + ") ");
            }
            nodeString.Append("]");
            return nodeString.ToString();
        }

        #endregion
    }
}
