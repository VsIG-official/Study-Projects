using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
	void Start()
	{
		Invoker invoker = Camera.main.GetComponent<Invoker>();
		invoker.AddNoArgumentListener(PrintMessage);
	}

	public void PrintMessage()
	{
		Debug.Log("Finally! Our fight will be legendary!!");
	}
}
