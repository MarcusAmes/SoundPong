using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public bool reversedNotes;

    void Start()
    {
        int reversed = PlayerPrefs.GetInt("isReversed", 0);
        if(reversed == 0)
        {
            reversedNotes = false;
        } else
        {
            reversedNotes = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float length = collision.gameObject.transform.parent.transform.localScale.x;
        AudioClip bounceSound = Resources.Load<AudioClip>("bNote");
        if(!reversedNotes)
        {
            if (length <= 1)
            {
                bounceSound = Resources.Load<AudioClip>("bNote");
            }
            else if (length > 1 && length <= 2)
            {
                bounceSound = Resources.Load<AudioClip>("aNote");
            }
            else if (length > 2 && length <= 3)
            {
                bounceSound = Resources.Load<AudioClip>("gNote");
            }
            else if (length > 3 && length <= 4)
            {
                bounceSound = Resources.Load<AudioClip>("fNote");
            }
            else if (length > 4 && length <= 5)
            {
                bounceSound = Resources.Load<AudioClip>("eNote");
            }
            else if (length > 5 && length <= 6)
            {
                bounceSound = Resources.Load<AudioClip>("dNote");
            }
            else if (length > 6)
            {
                bounceSound = Resources.Load<AudioClip>("cNote");
            }
        } else
        {
            if (length <= 1)
            {
                bounceSound = Resources.Load<AudioClip>("cNote");
            }
            else if (length > 1 && length <= 2)
            {
                bounceSound = Resources.Load<AudioClip>("dNote");
            }
            else if (length > 2 && length <= 3)
            {
                bounceSound = Resources.Load<AudioClip>("eNote");
            }
            else if (length > 3 && length <= 4)
            {
                bounceSound = Resources.Load<AudioClip>("fNote");
            }
            else if (length > 4 && length <= 5)
            {
                bounceSound = Resources.Load<AudioClip>("gNote");
            }
            else if (length > 5 && length <= 6)
            {
                bounceSound = Resources.Load<AudioClip>("aNote");
            }
            else if (length > 6)
            {
                bounceSound = Resources.Load<AudioClip>("bNote");
            }
        }
        
        SoundManagerScript.playSound(bounceSound);
    }
}
