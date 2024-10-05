using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public static MenuHandler Instance;

    private string playerName;

    public string PlayerName { get; set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        playerName = PlayerName;
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }

}
