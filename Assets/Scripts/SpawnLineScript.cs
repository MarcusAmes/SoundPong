using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLineScript : MonoBehaviour
{
    public GameObject line;
    private Vector2 touchPosInit;
    private GameObject spawnedLine;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        touchPosInit = new Vector2();
        spawnedLine = new GameObject();
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);       

            if (touch.phase == TouchPhase.Began)
            {
                touchPosInit = Camera.main.ScreenToWorldPoint(touch.position);       
            }
            if (touch.phase == TouchPhase.Moved)
            {
                if (count == 0)
                {
                    spawnedLine = Instantiate(line, touchPos, Quaternion.identity);
                }
                count++;
                //Length
                float a = touchPos.y - touchPosInit.y;
                float b = touchPos.x - touchPosInit.x;
                float c = Mathf.Sqrt((a * a) + (b * b));
                //totally wonky
                spawnedLine.transform.localScale = new Vector3(c, .15f , 1);



                //Rotation
                //Multiply rotate factor
                float angle = Mathf.Asin(a / c) * (180 / Mathf.PI);
                if (b >= 0)
                {
                    angle += 0;
                } else if (a>=0)
                {
                    angle = Mathf.Acos(b / c) * (180 / Mathf.PI);
                } else
                {
                    angle = Mathf.Asin(Mathf.Abs(a) / Mathf.Abs(c)) * (180 / Mathf.PI) + 180;
                }
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.z = angle;
                spawnedLine.transform.rotation = Quaternion.Euler(rotationVector);
            }
            if (touch.phase == TouchPhase.Ended)
            {
                count = 0;
            }
        }
    }
}
