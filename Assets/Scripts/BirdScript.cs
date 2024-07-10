using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float flapStrength;
    public bool birdIsAlive = true;
    public SoundScript sound;
    public Animator birdAnimator;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        birdAnimator.SetFloat("upSpeed", birdRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            sound.playFlapSFX();
            birdRigidbody.velocity = Vector2.up * flapStrength;
        }

        if ((transform.position.y < -22 || transform.position.y > 22) && birdIsAlive)
        {
            sound.playBirdDeadSFX();
            birdIsAlive = false;
            birdAnimator.SetBool("isAlive", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            sound.playBirdDeadSFX();
            birdIsAlive = false;
            birdAnimator.SetBool("isAlive", false);
        }
    }
}
