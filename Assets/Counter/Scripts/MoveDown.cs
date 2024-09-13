using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float speedSphere = 8;
    private GameManager uiScripts;

    void Start()
    {
        uiScripts = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (uiScripts.isGameActive == true)
        {
            transform.Translate(Vector3.down * speedSphere * Time.deltaTime);
        }
    }
}
