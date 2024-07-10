using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource buttonClickSFX;  //DM-CGS-31.wav
    public AudioSource flapSFX;         //DM-CGS-07.wav
    public AudioSource addScoreSFX;     //DM-CGS-28.wav
    public AudioSource birdDeadSFX;     //DM-CGS-25.wav

    public void playButtonClickSFX()
    {
        buttonClickSFX.Play();
    }

    public void playFlapSFX()
    {
        flapSFX.Play();
    }

    public void playAddScoreSFX()
    {
        addScoreSFX.Play();
    }

    public void playBirdDeadSFX()
    {
        birdDeadSFX.Play();
    }
}