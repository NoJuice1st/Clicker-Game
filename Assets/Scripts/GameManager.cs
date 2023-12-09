using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text clicksText;
    public static int clicks;

    private void Start() 
    {
        Load();
        InvokeRepeating("Save", 3f, 3f);
    }

    private void Update() 
    {
        clicksText.text = clicks.ToString();
    }

    void Save()
    {
        //print("Saves");
        PlayerPrefs.SetInt("clicks", clicks);
    }

    void Load()
    {
        clicks = PlayerPrefs.GetInt("clicks");
    }

    private void OnApplicationQuit() 
    {
        Save();
    }
}
