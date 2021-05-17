using System;
using System.Collections.Generic;

/// <summary>
/// A sorted list
/// </summary>
[Serializable]
public class SortedList<T> where T : IComparable
{
	readonly List<T> items = new List<T>();

	readonly List<T> tempList = new List<T>();

	#region Constructors

	/// <summary>
	/// No argument constructor
	/// </summary>
	public SortedList()
	{
	}

	#endregion

	#region Properties

	/// <summary>
	/// Gets the number of items in the list
	/// </summary>
	/// <value>number of items in the list</value>
	public int Count
	{
		get { return items.Count; }
	}

	/// <summary>
	/// Gets the item in the array at the given index
	/// This property allows access using [ and ]
	/// </summary>
	/// <param name="index">index of item</param>
	/// <returns>item at the given index</returns>
	public T this[int index]
	{
		get { return items[index]; }
	}

	#endregion

	#region Methods

	/// <summary>
	/// Adds the given item to the list
	/// </summary>
	/// <param name="item">item</param>
	public void Add(T item)
	{
		int addLocation = 0;
		while (addLocation < items.Count && items[addLocation].CompareTo(item) < 0)
		{
			addLocation++;
		}

		tempList.Clear();

		for (int i = 0; i < addLocation; i++)
		{
			tempList.Add(items[i]);
		}

		tempList.Add(item);

		for (int i = addLocation; i < items.Count; i++)
		{
			tempList.Add(items[i]);
		}

		items.Clear();
		items.AddRange(tempList);
	}

	/// <summary>
	/// Removes the item at the given index from the list
	/// </summary>
	/// <param name="index">index</param>
	public void RemoveAt(int index)
	{
		bool exists = items[index] != null ? true : false;
		if (!exists)
		{
			return;
		}
		items.RemoveAt(index);
	}

	/// <summary>
	/// Determines the index of the given item using binary search
	/// </summary>
	/// <param name="item">the item to find</param>
	public int IndexOf(T item)
	{
		int lowerBound = 0;
		int upperBound = items.Count - 1;
		int place = -1;

		while (place == -1 && lowerBound <= upperBound)
		{
			int middleLocation = lowerBound + (upperBound - lowerBound) / 2;
			T centerValue = items[middleLocation];

			if (centerValue.CompareTo(item) == 0)
			{
				place = middleLocation;
			}
			else
			{
				if (centerValue.CompareTo(item) > 0)
				{
					upperBound = middleLocation - 1;
				}
				else
				{
					lowerBound = middleLocation + 1;
				}
			}
		}
		return place;
	}

	/// <summary>
	/// Sorts the list
	/// </summary>
	public void Sort()
	{
		items.Sort();
	}
	#endregion
}
