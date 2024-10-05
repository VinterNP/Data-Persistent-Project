using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuUIHandler : MonoBehaviour
{
    public InputField PlayerNameInput;

    public void StartOnClicked()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayerInputText(string playerName)
    {
        MenuHandler.Instance.PlayerName = playerName;
    }


    public void ExiteOnClicked()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    
    }
}
