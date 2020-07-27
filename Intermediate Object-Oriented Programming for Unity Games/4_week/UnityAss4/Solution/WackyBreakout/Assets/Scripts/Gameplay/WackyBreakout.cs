using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game manager
/// </summary>
public class WackyBreakout : MonoBehaviour
{
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        EventManager.AddLastBallLostListener(HandleLastBallLost);
        EventManager.AddBlockDestroyedListener(HandleBlockDestroyed);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // pause game on escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuManager.GoToMenu(MenuName.Pause);
        }
    }

    /// <summary>
    /// Plays sound effect and ends the game if the last ball is lost
    /// </summary>
    void HandleLastBallLost()
    {
        AudioManager.Play(AudioClipName.GameLost);
        EndGame();
    }

    /// <summary>
    /// Ends the game if the last block was destroyed
    /// </summary>
    void HandleBlockDestroyed()
    {
        // check for 1 because the last block still exists in the scene
        // when it invokes the event
        if (GameObject.FindGameObjectsWithTag("Block").Length == 1)
        {
            EndGame();
        }
    }

    /// <summary>
    /// Ends the game
    /// </summary>
    void EndGame()
    {
        // instantiate prefab and set score
        GameObject gameOverMessage = Instantiate(Resources.Load("GameOverMessage")) as GameObject;
        GameOverMessage gameOverMessageScript = gameOverMessage.GetComponent<GameOverMessage>();
        GameObject hud = GameObject.FindGameObjectWithTag("HUD");
        HUD hudScript = hud.GetComponent<HUD>();
        gameOverMessageScript.SetScore(hudScript.Score);
    }
}
