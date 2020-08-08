using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event invoker
/// </summary>
public class Invoker : MonoBehaviour
{
	Listener listner = new Listener();
	Timer MessageTimer;
	MessageEvent messageEvent;
	int count;
	Timer CountMessageTimer;
	CountMessageEvent countMessageEvent = new CountMessageEvent();

	/// <summary>
	/// Awakes this instance.
	/// </summary>
	public void Awake()
	{
		messageEvent = new MessageEvent();
	}

	/// <summary>
	/// Starts this instance.
	/// </summary>
	public void Start()
	{
		MessageTimer = gameObject.AddComponent<Timer>();
		MessageTimer.Duration = 1;
		MessageTimer.Run();
		EventManager.AddNoArgumentInvoker(this);
		EventManager.AddIntArgumentInvoker(this);
	}

	/// <summary>
	/// Updates this instance.
	/// </summary>
	void Update()
	{
		// no argument event
		if (MessageTimer.Finished)
		{
			InvokeNoArgumentEvent();
			MessageTimer.Run();
		}

		// no argument event
		if (CountMessageTimer.Finished)
		{
			{
				InvokeNoArgumentEvent();
				MessageTimer.Run();
			}

			// no argument event
			if (CountMessageTimer.Finished)
			{
				InvokeOneArgumentEvent(count);
				CountMessageTimer.Run();
			}
		}
	}

	/// <summary>
	/// Adds the no argument listener.
	/// </summary>
	/// <param name="listener">The listener.</param>
	public void AddNoArgumentListener(UnityAction listener)
	{
		messageEvent = new MessageEvent();
		messageEvent.AddListener(listener);
	}

	/// <summary>
	/// Adds the one argument listener.
	/// </summary>
	/// <param name="listener">The listener.</param>
	public void AddOneArgumentListener(UnityAction<int> listener)
	{
		countMessageEvent.AddListener(listener);
	}

	/// <summary>
	/// Removes the no argument listener.
	/// </summary>
	/// <param name="listener">The listener.</param>
	public void RemoveNoArgumentListener(UnityAction listener)
	{
		messageEvent.RemoveListener(listener);
	}

	/// <summary>
	/// Removes the one argument listener.
	/// </summary>
	/// <param name="listener">The listener.</param>
	public void RemoveOneArgumentListener(UnityAction<int> listener)
	{
		countMessageEvent.RemoveListener(listener);
	}

	/// <summary>
	/// Invokes the no argument event.
	/// </summary>
	public void InvokeNoArgumentEvent()
	{
		listner.HandleMessageEvent();
		messageEvent.Invoke();
	}

	/// <summary>
	/// Invokes the one argument event.
	/// </summary>
	/// <param name="argument">The argument.</param>
	public void InvokeOneArgumentEvent(int argument)
	{
		listner.HandleCountMessageEvent(argument);
		countMessageEvent.Invoke(argument);
	}
}
