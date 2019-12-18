using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [Range(1f,100f)]
    public float speed = 5f;

    void Update()
    {
         if (Input.GetKey(KeyCode.A))
              transform.Rotate(Vector3.forward * speed * Time.deltaTime);
              
          if (Input.GetKey(KeyCode.D))
              transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
          
          if (Input.GetKey(KeyCode.W))
              transform.Rotate(Vector3.right * speed * Time.deltaTime);
      
          if (Input.GetKey(KeyCode.S))
              transform.Rotate(-Vector3.right * speed * Time.deltaTime);
          
          if (Input.GetKey(KeyCode.R))
              transform.rotation= new Quaternion(0f,0f,0f,0f);
    }
}
