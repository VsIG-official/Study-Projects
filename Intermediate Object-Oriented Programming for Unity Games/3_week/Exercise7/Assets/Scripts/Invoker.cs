using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event invoker
/// </summary>
public class Invoker : MonoBehaviour
{
    // no argument event support
    Timer messageTimer;
    MessageEvent messageEvent;

    /// <summary>
    /// Awake is called before Start
    /// </summary>
    void Awake()
    {
        messageEvent = new MessageEvent();
    }

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
	    // no argument event
        messageTimer = gameObject.AddComponent<Timer>();
        messageTimer.Duration = 1;
        messageTimer.Run();
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // no argument event
        if (messageTimer.Finished)
        {
            messageEvent.Invoke();
            messageTimer.Run();
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
}
