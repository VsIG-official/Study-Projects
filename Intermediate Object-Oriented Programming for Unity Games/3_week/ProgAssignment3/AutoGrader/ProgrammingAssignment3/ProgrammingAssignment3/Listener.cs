using UnityEngine;

/// <summary>
/// An event listener
/// </summary>
public class Listener : MonoBehaviour
{
	/// <summary>
	/// Starts this instance.
	/// </summary>
	public void Start()
	{
		Invoker invoker = new Invoker();
		invoker.AddNoArgumentListener(HandleMessageEvent);
		invoker.AddOneArgumentListener(HandleCountMessageEvent);
	}

	/// <summary>
	/// Handles the message event.
	/// </summary>
	public void HandleMessageEvent()
	{
		print("MessageEvent");
	}

	/// <summary>
	/// Handles the count message event.
	/// </summary>
	/// <param name="number">The number.</param>
	public void HandleCountMessageEvent(int number)
	{
		print("CountMessageEvent: " + number);
	}
}
