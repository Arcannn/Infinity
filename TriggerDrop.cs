using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDrop : MonoBehaviour
{

  Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

    }

    void OnTriggerEnter (Collider col)
    {
      if (col.gameObject.name.Equals("Player"))
      rigid.isKinematic = false;
    }
}
