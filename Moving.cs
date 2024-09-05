using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moving : MonoBehaviour
{


  // jumping
  public float jumpForce = 7f;
  private Rigidbody rigid;


// game over
  public bool GameOver = false;
  public bool Level2 = false;
  public bool Level3 = false;

// speed

// forward moving
  public float speed = 3f;

// ground check
  public LayerMask groundLayer;
  public float raycastDistance = 0.6f;
  private bool isGrounded;




  private void Start()
  {
    rigid = gameObject.GetComponent<Rigidbody>();



    InvokeRepeating("increaseSpeed", 5f, 5f);
  }

  // collsion with enemy
  void OnTriggerEnter(Collider collision) {
    if (collision.tag == "Enemy"){
      speed = 0;
      GameOver = true;
      rigid.isKinematic = true;
    }
    if(collision.tag =="Next"){
      speed = 0;
      rigid.isKinematic = true;
      Level2 = true;
    }

    if(collision.tag =="Next3"){
      speed = 0;
      rigid.isKinematic = true;
      Level3 = true;
    }

  }

void increaseSpeed ()
   {
       speed = speed + 1f;
   }

  // game over to main menu
  void FixedUpdate()
  {
    if (GameOver) {
        SceneManager.LoadScene ("Death");
      }

      else{
    if (Level2) {
        SceneManager.LoadScene ("Level2");
      }

        if (Level3) {
          SceneManager.LoadScene("Level3");
        }
      }


  }


  private void Update()
  {

    // speed going forward
    transform.Translate(Vector3.left * speed * Time.deltaTime);



    //Ground Check
    RaycastHit hit;
    if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance, groundLayer))
      isGrounded = true;
    else
      isGrounded = false;



    // jumping

    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    {
      rigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

      if(isGrounded)
      {
        rigid.velocity = new Vector3(rigid.velocity.x, jumpForce);
      }

    }

  }



}
