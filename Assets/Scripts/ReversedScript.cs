using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReversedScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isOn = PlayerPrefs.GetInt("isReversed") == 1;
        gameObject.GetComponent<Toggle>().isOn = isOn;
    }


}
