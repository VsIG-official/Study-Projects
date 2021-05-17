using UnityEngine.Events;

/// <summary>
/// An event manager
/// </summary>
public static class EventManager
{
	private static Fish invoker;
	private static UnityAction<int> listener;

	/// <summary>
	/// adds the invoker
	/// </summary>
	/// <param name="script"></param>
	public static void AddInvoker(Fish script)
	{
		invoker = script;
		if (listener != null)
		{
			invoker.AddPointsAddedEventListener(listener);
		}
	}

	/// <summary>
	/// adds the listener
	/// </summary>
	/// <param name="script"></param>
	public static void AddListener(UnityAction<int> handler)
	{
		listener = handler;
		if (invoker != null)
		{
			invoker.AddPointsAddedEventListener(listener);
		}
	}
}
