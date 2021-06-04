using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float length = collision.gameObject.transform.parent.transform.localScale.x;
        AudioClip bounceSound = Resources.Load<AudioClip>("bNote");
        if (length <= 1)
        {
            bounceSound = Resources.Load<AudioClip>("bNote");
        } else if (length > 1 && length <= 2)
        {
            bounceSound = Resources.Load<AudioClip>("aNote");
        } else if (length > 2 && length <= 3)
        {
            bounceSound = Resources.Load<AudioClip>("gNote");
        } else if (length > 3 && length <= 4)
        {
            bounceSound = Resources.Load<AudioClip>("fNote");
        } else if (length > 4 && length <= 5)
        {
            bounceSound = Resources.Load<AudioClip>("eNote");
        } else if (length > 5 && length <= 6)
        {
            bounceSound = Resources.Load<AudioClip>("dNote");
        } else if (length > 6)
        {
            bounceSound = Resources.Load<AudioClip>("cNote");
        }
        SoundManagerScript.playSound(bounceSound);
    }
}
