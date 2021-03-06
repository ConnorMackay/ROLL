﻿using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Screen.showCursor = true;
        Screen.lockCursor = false;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadLevel(int _level)
    {
        Application.LoadLevel("Level " + _level.ToString());
    }

    public void Play()
    {
        Application.LoadLevel("Roll");
    }
}
