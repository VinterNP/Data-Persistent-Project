using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class MenuManager : MonoBehaviour
{
    public Text MenuScoreBoardText;
    private string _BestName;
    private int _BestScore;
    private void Awake()
    {
        LoadScore();
        MenuScoreBoardText.text = $"Best Score : {_BestName} : {_BestScore}"; ;
    }

    [System.Serializable]
    class SaveData
    {
        public string BestPlayerName;
        public int BestScore;
    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savescore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            _BestName = data.BestPlayerName;
            _BestScore = data.BestScore;

        }
    }
}
