﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScenario : MonoBehaviour
{
    [SerializeField]
    string sceneName;
    public void LoadScenario1()
    {
        SceneManager.LoadScene(sceneName);
    }
}
