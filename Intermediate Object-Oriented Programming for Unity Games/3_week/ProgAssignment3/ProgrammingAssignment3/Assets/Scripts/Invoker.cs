using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event invoker
/// </summary>
public class Invoker : MonoBehaviour
{
	public int count;
	// add your fields for your message event support here
	Timer messageEventTimer;
	private MessageEvent messageEvent;

	// add your fields for your count message event support here
	Timer countMessageEventTimer;
	private CountMessageEvent countMessageEvent;

	/// <summary>
	/// Awake is called before Start
	/// </summary>
	public void Awake()
	{
		messageEventTimer = gameObject.AddComponent<Timer>();
		messageEvent = new MessageEvent();

		countMessageEventTimer = gameObject.AddComponent<Timer>();
		countMessageEvent = new CountMessageEvent();
	}

	/// <summary>
	/// Use this for initialization
	/// </summary>
	public void Start()
	{
		messageEventTimer.Duration = 1;
		messageEventTimer.Run();

		countMessageEventTimer.Duration = 1;
		countMessageEventTimer.Run();
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		// no argument event
		if (messageEventTimer.Finished)
		{
			InvokeNoArgumentEvent();
			messageEventTimer.Run();
		}

		// no argument event
		if (countMessageEventTimer.Finished)
		{
			InvokeOneArgumentEvent(count);
			countMessageEventTimer.Run();
		}
	}

	/// <summary>
	/// Adds the given listener to the no argument event
	/// </summary>
	/// <param name="listener">listener</param>
	public void AddNoArgumentListener(UnityAction listener)
	{
		messageEvent.AddListener(listener);
	}

	/// <summary>
	/// Adds the given listener to the one argument event
	/// </summary>
	/// <param name="listener">listener</param>
	public void AddOneArgumentListener(UnityAction<int> listener)
	{
		countMessageEvent.AddListener(listener);
	}

	/// <summary>
	/// Removes the given listener to the no argument event
	/// </summary>
	/// <param name="listener">listener</param>
	public void RemoveNoArgumentListener(UnityAction listener)
	{
		messageEvent.RemoveListener(listener);
	}

	/// <summary>
	/// Removes the given listener to the one argument event
	/// </summary>
	/// <param name="listener">listener</param>
	public void RemoveOneArgumentListener(UnityAction<int> listener)
	{
		countMessageEvent.RemoveListener(listener);
	}

	/// <summary>
	/// Invokes the no argument event
	///
	/// NOTE: We need this public method for the autograder to work
	/// </summary>
	public void InvokeNoArgumentEvent()
	{
		messageEvent.Invoke();
	}

	/// <summary>
	/// Invokes the one argument event
	///
	/// NOTE: We need this public method for the autograder to work
	/// </summary>
	/// <param name="argument">argument to use for the Invoke</param>
	public void InvokeOneArgumentEvent(int argument)
	{
		countMessageEvent.Invoke(argument);
		count++;
	}
}
