using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public GameManager uiManagerScript;

    public Text CounterText;
    public int Count = 0;

    void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
        other.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Count == -1)
        {
            Debug.Log("Game Over!");
            uiManagerScript.GameOver();
            Count = 0;
        }

    }
}
