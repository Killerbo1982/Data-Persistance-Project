using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataTranfer : MonoBehaviour
{
    
    public static DataTranfer Instance;
    public string playerName;
    public int highscore;
    public string highscoreName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    

}
