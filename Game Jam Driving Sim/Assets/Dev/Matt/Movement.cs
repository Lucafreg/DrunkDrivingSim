using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private SpeedSO SpeedSO;

    private CharacterController controller;
    private Vector2 input;
    public float speed;
    public float turnSpeed;
    private float currentYRotation;
    public float turnClamp;
    private Quaternion initialRot;
   
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        initialRot = transform.rotation;
        currentYRotation = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        SpeedSO.MySpeed = SpeedSO.MyMaxSpeed;
        speed = SpeedSO.MySpeed;
        Vector3 move = movement();
        controller.Move(move * speed * Time.deltaTime);
       
            currentYRotation += input.x * turnSpeed * Time.deltaTime;
            currentYRotation = Mathf.Clamp(currentYRotation, -turnClamp, turnClamp);
            transform.rotation = Quaternion.Euler(0, currentYRotation, 0);
       
      
           

          

        

    }
    public void OnMoveInput(InputAction.CallbackContext context)
    {
         input = context.ReadValue<Vector2>();
    }

    private Vector3 movement()
    {
        Vector3 move = transform.forward * speed;
        move.y = 0;
        
        return move.normalized;

    }
   

    
}
