using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
  float movementspeed = 0.5f;
  float rotationSpeed = 3.0f;
  //goal is to have a spaceship-like camera feeling
  void Update(){
      Vector3 position = new Vector3(0,	0,Input.GetAxis("Vertical"));
      this.transform.Translate(position * movementspeed);
      //roll camera with horizontal arrow keys
      float zRoll = rotationSpeed * Input.GetAxis("Horizontal");
      transform.Rotate(0, 0, -zRoll);

      //click left mouse to rotate camera
      if (Input.GetMouseButton (0)) {
        float h = rotationSpeed * Input.GetAxis("Mouse X");
        float v = rotationSpeed * Input.GetAxis("Mouse Y");
        //reset perceived mouse camera roll
        //float z = transform.eulerAngles.z;
        transform.Rotate(v, h, 0);
      }
    }
  }
  
