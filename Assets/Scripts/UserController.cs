using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : TriangleController
{
    // void Start()
    // {
    //     bullet.GetComponent<Bullet>().team = 1;
    // }

    private void Update()
    {
        float hozizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // if (Input.GetMouseButton(0))
        // {
        //     Fire();
        // }
        // if (hozizontal != 0 || vertical != 0)
        // {
        //     Fire();
        // }
        Move (hozizontal, vertical);
    }
}
