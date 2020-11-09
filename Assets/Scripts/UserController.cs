using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : TriangleController
{
    private void Update()
    {
        float hozizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Move (hozizontal, vertical);
    }
}
