using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


  public void PlayGame ()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  public void PlayLevel2 () {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
  }
  public void PlayLevel3 () {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
  }

  public void Continue ()
  {
    SceneManager.LoadScene("Menu");
  }


  public void QuitGame()
  {
    Debug.Log("QUIT");
    Application.Quit();
  }
}
