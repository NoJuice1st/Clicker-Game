using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Worker : MonoBehaviour
{
    public string workerName;
    public int count;
    public int price;
    public int cps;

    public TMP_Text countText;
    public TMP_Text priceText;
    public Button button;

    private void Update()
    {
        countText.text = count.ToString();
        priceText.text = "price:" + price;

        var canClick = GameManager.clicks >= price;
        button.interactable = canClick;
    }

    private void Start() 
    {
        InvokeRepeating("Work", 1f, 1f);
        Load();
    }

    public void Buy()
    {
        if (GameManager.clicks < price) return;

        GameManager.clicks -= price;
        price = (int)(price * 1.4);
        count++;
        Save();
    }

    public void Work()
    {
        GameManager.clicks += count * cps;
    }

    void Save()
    {
        PlayerPrefs.SetInt(workerName, count);
        PlayerPrefs.SetInt(name + "price", price);
    }

    void Load()
    {
        count = PlayerPrefs.GetInt(workerName);
        price = PlayerPrefs.GetInt(name + "price", price);
    }
}
