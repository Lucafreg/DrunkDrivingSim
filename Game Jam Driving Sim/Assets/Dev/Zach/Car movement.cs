using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class Carmovement : MonoBehaviour
{

    public Rigidbody CarRb;
    public GameObject CarPrefab;
    public Quaternion carRotaion;
    public Camera Camera;
    public Vector3 CamOffset;
    public Quaternion CamRotation;
    public float CarSpeed;
    public float CarTurnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        CarRb=GetComponent<Rigidbody>();
       Camera=GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        Camera.transform.position=CarRb.transform.position+ CamOffset;
        Camera.transform.rotation = CamRotation;
    }

    private void FixedUpdate()
    {
       // Camera.transform.rotation = CamRotation;
        Camera.transform.position = CarRb.transform.position + CamOffset;

        CarRb.AddForce(0, 0, CarSpeed);
        if(Input.GetKey(KeyCode.A))
        {
            CarRb.AddForce(-CarTurnSpeed, 0, 0);
            
        }
        if(Input.GetKey(KeyCode.D))
        {
            CarRb.AddForce(CarTurnSpeed, 0, 0);
        }
    }


}
