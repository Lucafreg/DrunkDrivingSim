using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private Vector2 input;
    public float speed;
    public float turnSpeed;
    private float currentYRotation; 
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = movement();
        controller.Move(move * speed * Time.deltaTime);
        if(input.x != 0)
        {
            currentYRotation += input.x * turnSpeed * Time.deltaTime;
            currentYRotation = Mathf.Clamp(currentYRotation, -45, 45);
            transform.rotation = Quaternion.Euler(0, currentYRotation, 0);
        }
        
    }
    public void OnMoveInput(InputAction.CallbackContext context)
    {
         input = context.ReadValue<Vector2>();
    }

    private Vector3 movement()
    {
        Vector3 move = transform.right * input.x + transform.forward * speed;
        move.y = 0;
        
        return move.normalized;

    }
   

    
}
