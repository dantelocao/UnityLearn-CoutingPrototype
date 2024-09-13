using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OutOfBounds : MonoBehaviour
{
    private Counter boxScripts;

    private void Start()
    {
        boxScripts = GameObject.Find("Box").GetComponent<Counter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        boxScripts.Count--;
        // Count -= 1;
        //countText.text = "Count : " + Count;
        boxScripts.CounterText.text = "Count : " + boxScripts.Count;
        other.gameObject.SetActive(false);
    }
}
