using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColoredScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isOn = PlayerPrefs.GetInt("isColored") == 1;
        gameObject.GetComponent<Toggle>().isOn = isOn;
    }

}
