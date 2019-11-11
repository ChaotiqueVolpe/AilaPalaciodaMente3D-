﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OutraCena()
    {
        SceneManager.LoadScene("AilaIsBorn");

    }

    public void LoadGame()
    {

        LoadInformation.LoadAll();

        Debug.Log("Player name: " + GameInformation.Aila.PlayerName);
        Debug.Log("Player lvl: " + GameInformation.Aila.PlayerLevel);
        Debug.Log("Player Power: " + GameInformation.Aila.Poder);
        Debug.Log("Player Determination: " + GameInformation.Aila.Determinacao);

        if (GameInformation.LastScene != null && GameInformation.LastScene != "")
        {
            SceneManager.LoadScene(GameInformation.LastScene);
        }
    }
}
