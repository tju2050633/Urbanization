using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if((transform.position.x < -10&& horizontal<0)|| (transform.position.x > 10 && horizontal > 0)||(transform.position.y < -10 && vertical < 0)||(transform.position.y > 10 && vertical > 0))
        {

        }
        else
        {
            transform.position += (new Vector3(horizontal, vertical, 0) * (Time.deltaTime * speed));
        }
    }
}
