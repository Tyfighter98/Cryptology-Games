﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ContinueToGame2 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Portal2Game");
        }
    }
}
