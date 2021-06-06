using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GoToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void SetIsReversed(bool isReversed)
    {
        if (isReversed)
        {
            PlayerPrefs.SetInt("isReversed", 1);
        } else
        {
            PlayerPrefs.SetInt("isReversed", 0);
        }
    }

    public void SetIsColored(bool isColored)
    {
        if (isColored)
        {
            PlayerPrefs.SetInt("isColored", 1);
        }
        else
        {
            PlayerPrefs.SetInt("isColored", 0);
        }
    }

    public void SetFrequency(int frequency)
    {
        PlayerPrefs.SetInt("frequency", frequency);
    }
}
