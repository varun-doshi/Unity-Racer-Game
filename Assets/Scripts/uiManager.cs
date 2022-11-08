using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{

    public Button[] Buttons;

    public void gameOverScreen()
    {
        foreach(Button buttons in Buttons)
        {
            buttons.gameObject.SetActive(true);
        }
    }

    public void playButton()
    {
        SceneManager.LoadScene(1);
    }

   public void exit()
    {
        Application.Quit();
    }
    public void pauseGmae()
    {
        if (Time.timeScale == 1)
        {
            gameManager.Instance.isPause = !gameManager.Instance.isPause;
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            gameManager.Instance.isPause = !gameManager.Instance.isPause;
        }
    }
    
}
