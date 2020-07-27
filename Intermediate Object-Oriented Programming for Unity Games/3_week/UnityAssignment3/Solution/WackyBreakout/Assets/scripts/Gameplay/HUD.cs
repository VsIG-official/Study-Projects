using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The HUD for the game
/// </summary>
public class HUD : MonoBehaviour
{
	#region Fields

	// score support
	static Text scoreText;
	static int score = 0;
    const string ScorePrefix = "Score: ";

    // balls left support
    static Text ballsLeftText;
    static int ballsLeft;
    const string BallsLeftPrefix = "Balls Left: ";

    #endregion

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		// initialize score text
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
		scoreText.text = ScorePrefix + score;

        // initialize balls left value and text
        ballsLeft = ConfigurationUtils.BallsPerGame;
        ballsLeftText = GameObject.FindGameObjectWithTag("BallsLeftText").GetComponent<Text>();
        ballsLeftText.text = BallsLeftPrefix + ballsLeft;
	}

	#region Public methods

	/// <summary>
	/// Updates the score
	/// </summary>
	/// <param name="points">points to add</param>
	public static void AddPoints(int points)
    {
		score += points;
		scoreText.text = ScorePrefix + score;
	}

    /// <summary>
    /// Updates the balls left
    /// </summary>
    public static void ReduceBallsLeft()
    {
        ballsLeft--;
        ballsLeftText.text = BallsLeftPrefix + ballsLeft;
    }

	#endregion
}
