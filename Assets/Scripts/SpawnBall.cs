using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public Rigidbody2D ball;
    public int frequency;
    public float elaspedTime = 0.0f;

    private void Start()
    {
        frequency = PlayerPrefs.GetInt("frequency", 2);
    }

    // Update is called once per frame
    void Update()
    {
        elaspedTime += Time.deltaTime;
        if (elaspedTime > frequency + 1)
        {
            elaspedTime = 0;
            Rigidbody2D clone = Instantiate(ball, transform.position, transform.rotation);
        }
    }
}
