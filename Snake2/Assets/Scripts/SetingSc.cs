using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetingSc : MonoBehaviour {

    private bool paused2 = false;
    public GameObject panel2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!paused2)
            {
                SetingT();

            }
            else
            {
                SetingF();

            }
        }

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

