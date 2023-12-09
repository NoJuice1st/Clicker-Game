using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public string workerName;
    public int count;
    public int price;
    public int cps;

    private void Start() 
    {
        Load();
    }

    public void Buy()
    {
        if (GameManager.clicks < price) return;

        GameManager.clicks -= price;
        count++;
        Save();
    }

    void Save()
    {
        PlayerPrefs.SetInt(workerName, count);
    }

    void Load()
    {
        count = PlayerPrefs.GetInt(workerName);
    }
}
