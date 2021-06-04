using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteLineScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            foreach (var touch in Input.touches)
            {
                if (touch.tapCount == 2)
                {
                    Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    if (GetComponent<BoxCollider2D>().OverlapPoint(wp))
                    {
                        Destroy(transform.parent.gameObject);
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
}
