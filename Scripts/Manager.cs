using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager : MonoBehaviour {

    // You can use this script to do multiple things.

    // Loads a specific scene.
    public void ChangeScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }

    // Closes the game down.
    public void QuitGame()
    {
        Application.Quit();
    }

    // Disables the cursor.
    public void DisableCursor() 
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Enables the cursor.
    public void EnableCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}