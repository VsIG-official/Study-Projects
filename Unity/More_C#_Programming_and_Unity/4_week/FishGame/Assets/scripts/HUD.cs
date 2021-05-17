using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The HUD
/// </summary>
public class HUD : MonoBehaviour
{
    // scoring support
    [SerializeField]
    Text scoreText;
    int score;
    const string ScorePrefix = "Score: ";

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        scoreText.text = ScorePrefix + score.ToString();
	}
	
    /// <summary>
    /// Adds the given points to the score
    /// </summary>
    /// <param name="points">points</param>
    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = ScorePrefix + score.ToString();
    }
}
