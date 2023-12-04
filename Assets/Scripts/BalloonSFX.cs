using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSFX : MonoBehaviour
{
    public AudioSource balloonSFX;

    public void playBalloonSFX()
    {
        balloonSFX.Play();
    }
}
