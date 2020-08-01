using UnityEngine;

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
		Invoker invokerMessageEvent = GameObject.Find("MainCamera").GetComponent<Camera>().GetComponent<Invoker>();
		invokerMessageEvent.AddNoArgumentListener(HandleMessageEvent);

		Invoker invokerCountMessageEvent = GameObject.Find("MainCamera").GetComponent<Camera>().GetComponent<Invoker>();
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
