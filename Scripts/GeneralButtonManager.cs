using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralButtonManager : MonoBehaviour {

    /*
    Script Version: 1.0

    Made by DemirK2
    https://twitter.com/demir_k2

    This script contains a lot o useful stuff that can be used via buttons.
    This script gets updated often, check its GitHub Repository for newer versions.
    https://github.com/DemirK2/Unity
    
    Support:
    https://discord.gg/STcThtu
    https://www.pokenix.com
    */

    // Loads a scene.
    public void SceneLoader(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }

    // Opens an URL (default browser).
    public void OpenURL(string URL)
    {
        Application.OpenURL(URL);
    }

    // Closes the application down.
    public void Quit()
    {
        Application.Quit();
    }

    // Disables the cursor.
    public void DisableCursor()
    {
        Cursor.visible = false;
        Cursor.LockState = CursorLockMode.Locked;
    }

    // Enables the cursor.
    public void EnableCursor()
    {
        Cursor.visible = true;
        Cursor.LockState = CursorLockMode.None;
    }
}