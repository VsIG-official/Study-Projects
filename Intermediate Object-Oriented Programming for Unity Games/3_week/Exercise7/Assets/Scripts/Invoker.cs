using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour
{
	private Timer timer;

	private MessageEvent messageEvent;

	void Awake()
	{
		messageEvent = new MessageEvent();
	}

	void Start()
	{
		timer = gameObject.AddComponent<Timer>();
		timer.Duration = 1;
		timer.Run();
	}

	void Update()
	{
		if (timer.Finished)
		{
			messageEvent.Invoke();
			timer.Run();
		}
	}

	public void AddNoArgumentListener(UnityAction listener)
	{
		messageEvent.AddListener(listener);
	}
}
