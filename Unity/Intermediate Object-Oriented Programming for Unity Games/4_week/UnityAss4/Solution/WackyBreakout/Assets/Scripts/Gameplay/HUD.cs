using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// The HUD for the game
/// </summary>
public class HUD : MonoBehaviour
{
	#region Fields

	// score support
	Text scoreText;
	int score = 0;
    const string ScorePrefix = "Score: ";

    // balls left support
    Text ballsLeftText;
    int ballsLeft;
    const string BallsLeftPrefix = "Balls Left: ";

    // last ball lost support
    LastBallLost lastBallLost;

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

        // add listeners to the event manager
        EventManager.AddPointsAddedListener(AddPoints);
        EventManager.AddBallLostListener(ReduceBallsLeft);

        // last ball lost support
        lastBallLost = new LastBallLost();
        EventManager.AddLastBallLostInvoker(this);
	}

    /// <summary>
    /// Gets the score
    /// </summary>
    /// <value>score</value>
    public int Score
    {
        get { return score; }
    }

    #region Public methods

    /// <summary>
    /// Adds the given listener for the LastBallLost event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddLastBallLostListener(UnityAction listener)
    {
        lastBallLost.AddListener(listener);
    }

    #endregion

	#region Private methods

	/// <summary>
	/// Updates the score
	/// </summary>
	/// <param name="points">points to add</param>
	void AddPoints(int points)
    {
		score += points;
		scoreText.text = ScorePrefix + score;
	}

    /// <summary>
    /// Updates the balls left
    /// </summary>
    void ReduceBallsLeft()
    {
        ballsLeft--;
        ballsLeftText.text = BallsLeftPrefix + ballsLeft;
        if (ballsLeft == 0)
        {
            lastBallLost.Invoke();
        }
    }

	#endregion
}
