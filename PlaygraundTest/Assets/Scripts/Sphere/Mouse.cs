using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Transform SphereCharecter;
    public float mouseSensitivity = 100f;
    float xRotetion =0f ;


    void Start()
    {
        
    }

   
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        SphereCharecter.Rotate(Vector3.up * mouseX);
        

        xRotetion = Mathf.Clamp(xRotetion, -30, 30);         
    }
}
