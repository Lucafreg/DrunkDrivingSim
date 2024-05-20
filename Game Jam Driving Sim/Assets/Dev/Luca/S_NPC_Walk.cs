using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_NPC_Walk : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.LookRotation(direction);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = direction * speed * Time.deltaTime;
        Debug.Log(movement);
        transform.Translate(movement,Space.World);
        transform.rotation = Quaternion.LookRotation(movement);

        if(transform.position.x > transform.parent.position.x +1)
        {
            direction = Vector3.left;
        }
        else if(transform.position.x < transform.parent.position.x -1)
        {
            direction = Vector3.right;
        }
    }

}
