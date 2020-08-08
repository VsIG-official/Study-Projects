using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event listener
/// </summary>
public class Listener : MonoBehaviour
{
<<<<<<< HEAD
=======

>>>>>>> parent of 9e8e406... feat: some update
	/// <summary>
	/// Use this for initialization
	/// </summary>
	public void Start()
	{
<<<<<<< HEAD
		Invoker invoker = new Invoker();

		invoker.AddNoArgumentListener(HandleMessageEvent);

		invoker.AddOneArgumentListener(HandleCountMessageEvent);
=======
		Invoker invokerMessageEvent = new Invoker();
		invokerMessageEvent.AddNoArgumentListener(HandleMessageEvent);

		Invoker invokerCountMessageEvent = new Invoker();
		invokerCountMessageEvent.AddOneArgumentListener(HandleCountMessageEvent);
>>>>>>> parent of 9e8e406... feat: some update
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
