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
	[SerializeField]
	Text scoreText;
	int score = 0;
    const string ScorePrefix = "Score: ";

    #endregion

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		// add listener for PointsAddedEvent
		EventManager.AddListener(HandlePointsAddedEvent);

		// initialize score text
		scoreText.text = ScorePrefix + score;
	}

	#region Private methods

	/// <summary>
	/// Handles the points added event by updating the displayed score
	/// </summary>
	/// <param name="points">points to add</param>
	void HandlePointsAddedEvent(int points)
    {
		score += points;
		scoreText.text = ScorePrefix + score;
	}

	#endregion
}
