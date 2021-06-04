using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public Rigidbody2D ball;
    public float frequency;
    public float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == frequency)
        {
            Rigidbody2D clone;
            clone = Instantiate(ball, transform.position, transform.rotation);
            clone.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            count = 0;
        } else
        {
            count++;
        }
    }
}
