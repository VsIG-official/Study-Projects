using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// HUD script
/// </summary>
public class HUD : MonoBehaviour
{
    [SerializeField]
    Text scoreText;

    private float elapsedSeconds = 0f;
    private bool timerIsRunning = true;
    // Start is called before the first frame update
    void Start()
    {
	    scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
	    if (timerIsRunning)
	    {
			elapsedSeconds += Time.deltaTime;
			scoreText.text = elapsedSeconds.ToString("0");
	    }
    }

    public void StopGamerTimer()
    {
	    timerIsRunning = false;
    }
}
