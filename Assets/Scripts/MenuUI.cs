using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuUI : MonoBehaviour
{
    public TextMeshProUGUI playerNameInput;

    public void StartGame()
    {
        DataTranfer.Instance.playerName = playerNameInput.text;
        SceneManager.LoadScene(1);

    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
