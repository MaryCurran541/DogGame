﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTracker : MonoBehaviour
{
    public AudioSource[] soundFX;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Zkey")){
			soundFX[0].Play();
		}
		
		
    }
}
