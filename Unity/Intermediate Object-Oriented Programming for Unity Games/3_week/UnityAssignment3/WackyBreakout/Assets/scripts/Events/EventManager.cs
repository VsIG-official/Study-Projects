using System.Collections.Generic;
using UnityEngine.Events;

public static class EventManager
{
	// FreezerEffectActivated support
	static List<PickupBlock> freezerEffectInvokers = new List<PickupBlock>();
	static List<UnityAction<float>> freezerEffectListeners =
		new List<UnityAction<float>>();

	/// <summary>
	/// Adds the given script as an invoker
	/// </summary>
	/// <param name="invoker">the invoker</param>
	public static void AddFreezerEffectInvoker(PickupBlock invoker)
	{
		// add invoker to list and add all listeners to invoker
		freezerEffectInvokers.Add(invoker);
		foreach (UnityAction<float> listener in freezerEffectListeners)
		{
			invoker.AddFreezerEffectListener(listener);
		}
	}

	/// <summary>
	/// Adds the given method as a freezer effect listener
	/// </summary>
	/// <param name="listener">listener</param>
	public static void AddFreezerEffectListener(UnityAction<float> listener)
	{
		// add listener to list and to all invokers
		freezerEffectListeners.Add(listener);
		foreach (PickupBlock invoker in freezerEffectInvokers)
		{
			invoker.AddFreezerEffectListener(listener);
		}
	}
}
