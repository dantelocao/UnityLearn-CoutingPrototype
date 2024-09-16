using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using UnityEditor;

public class GameManager: MonoBehaviour
{
    private float yPos = 23.5f;
    private float zPos = 12;
    private float startDelay = 0;
    private float delay = 8f;

    public Counter counterScript;
    public bool isGameActive;

    public MoveDown sphereScript;

    public Text countText;

    public Button easyMode;
    public Button mediumMode;
    public Button HARDMODE;
    public GameObject titleScreen;

    public void StartGame(int difficulty)
    {
        delay = 8f;
        ObjectPooler.SharedInstance.ResetGameObjects();
        delay = delay/difficulty;
        isGameActive = true;
        titleScreen.SetActive(false);
        countText.gameObject.SetActive(true);
        InvokeRepeating("InvokeSpheres", startDelay, delay);
    }

    public void GameOver()
    {
        CancelInvoke();
        isGameActive = false;
        titleScreen.SetActive(true);
    }

    public void InvokeSpheres()
    {
        // Get an object object from the pool
        GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();
        if (pooledProjectile != null)
        {
            pooledProjectile.SetActive(true); // activate it
            pooledProjectile.transform.position = new Vector3(0, yPos, Random.Range(-zPos, zPos));
        }
    }

}
