using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    [SerializeField]
	private static Text ballsText;
	[SerializeField]
	private static Text scoreText;

	public static int balls = 0;
	public static int score = 0;
	const string ScorePrefix = "Score: ";
	const string BallsPrefix = "Balls: ";

	void Start()
	{
		ballsText = GetComponent<Text>();
		scoreText = GetComponent<Text>();
		ChangeText();
	}

	private static void ChangeText()
	{
		ballsText.text = balls.ToString();
		scoreText.text = score.ToString();
	}

	public static void AddPoints()
    {
	    score++;
	    ChangeText();
    }

    public static void AddBalls()
    {
	    balls++;
	    ChangeText();
    }

    public static void ReduceBalls()
    {
	    balls--;
	    ChangeText();
    }
}
