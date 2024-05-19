using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject target;
    public Vector3 offset;
    public float smoothDelta;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = target.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LateUpdate()
    {
        Follow();

    }

    private void Follow()
    {
        Vector3 desiredPos = target.transform.position + offset;
        Vector3 smoothPos = Vector3.Slerp(transform.position, desiredPos, smoothDelta);
        transform.position = smoothPos;
        transform.LookAt(target.transform);
    }
}
