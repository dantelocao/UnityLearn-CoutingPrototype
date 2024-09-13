using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultButton : MonoBehaviour
{
    private Button button;
    private GameManager manager;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();

        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        manager.StartGame(difficulty);
    }
}
