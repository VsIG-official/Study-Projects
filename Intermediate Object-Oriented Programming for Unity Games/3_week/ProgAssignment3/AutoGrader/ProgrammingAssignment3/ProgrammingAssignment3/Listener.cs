using UnityEngine;

/// <summary>
/// An event listener
/// </summary>
public class Listener : MonoBehaviour
{
	public void Start()
	{
		Invoker invoker = new Invoker();
		invoker.AddNoArgumentListener(HandleMessageEvent);
		invoker.AddOneArgumentListener(HandleCountMessageEvent);
	}

	public void HandleMessageEvent()
	{
		print("MessageEvent");
	}

	public void HandleCountMessageEvent(int number)
	{
		print("CountMessageEvent: " + number);
	}
}
