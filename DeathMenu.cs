using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{


  void Start () {
//    gameObject.SetActive (false);
  }

  void FixedUpdate (){
    if (Input.anyKey) {
      SceneManager.LoadScene ("Menu");
    }
  }



//  public void ToggleEndMenu(float points)
//  {
//    gameObject.SetActive(true);
//}
}
