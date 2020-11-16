using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : TriangleController
{
    private void Update()
    {
        float hozizontal = Random.Range(0f, 2f) - 1f;
        float vertical = Random.Range(0f, 2f) - 1f;

        Move (hozizontal, vertical);
        Fire();
    }
}
