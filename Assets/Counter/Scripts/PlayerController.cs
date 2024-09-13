using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float speed;

    private GameManager uiScripts;

    private void Start()
    {
        uiScripts = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (uiScripts.isGameActive == true)
        {
            horizontalInput = Input.GetAxis("Horizontal") * speed;
            transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime);
        }
    }
}
