using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Listens for the OnClick events for the help menu button
/// </summary>
public class HelpMenu : MonoBehaviour
{
    /// <summary>
    /// Handles the on click event from the back button
    /// </summary>
    public void HandleBackButtonOnClickEvent()
    {
        MenuManager.GoToMenu(MenuName.Main);
    }
} 
