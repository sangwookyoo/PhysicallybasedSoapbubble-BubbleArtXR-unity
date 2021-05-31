using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleDestroy : MonoBehaviour
{
    public ParticleSystem ParticleLauncher;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ParticleLauncher.Play();
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            ParticleLauncher.Stop();
        }
    }
}