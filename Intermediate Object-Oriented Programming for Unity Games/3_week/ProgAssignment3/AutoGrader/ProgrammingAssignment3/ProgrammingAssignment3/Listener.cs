using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event listener
/// </summary>
public class Listener : MonoBehaviour
{

	/// <summary>
	/// Use this for initialization
	/// </summary>
	public void Start()
	{
		Invoker invokerMessageEvent = new Invoker();
		invokerMessageEvent.AddNoArgumentListener(HandleMessageEvent);

		Invoker invokerCountMessageEvent = new Invoker();
		invokerCountMessageEvent.AddOneArgumentListener(HandleCountMessageEvent);
	}

	/// <summary>
	/// Handles the no argument event
	/// </summary>
	void HandleMessageEvent()
	{
		print("MessageEvent");
	}

	/// <summary>
	/// Handles the one argument event
	/// </summary>
	/// <param name="number">number</number>
	void HandleCountMessageEvent(int number)
	{
		print("CountMessageEvent: " + number);
	}
}
