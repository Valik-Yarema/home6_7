﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        GameExit();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameExit()
    {
        Application.Quit();
    }


}
