using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStartStop : MonoBehaviour
{
    public ParticleSystem MyParticleSystem;

    public void StartParticles()
    {
        MyParticleSystem.Play();
    }

    public void StopParticles()
    {
        MyParticleSystem.Stop();
    }
}
