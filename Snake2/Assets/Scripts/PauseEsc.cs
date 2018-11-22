using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseEsc : MonoBehaviour
{
    private bool paused2 = false;
    private bool paused = false;
    public GameObject panel;
    public GameObject panel2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                PauseT();
                
            }
            else
            {
                PauseF();
               
                }
        }
        
    }

    public void PauseT()
    {
        Time.timeScale = 0;
        paused = true;
        panel.SetActive(true);
    }

    public void PauseF()
    {
        Time.timeScale = 1;
        paused = false;
        panel.SetActive(false);
    }
    public void SetingT()
    {
        Time.timeScale = 0;
        paused2 = true;
        panel2.SetActive(true);
    }

    public void SetingF()
    {
        Time.timeScale = 1;
        paused2 = false;
        panel2.SetActive(false);
    }
}

