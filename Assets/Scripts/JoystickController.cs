using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : TriangleController
{
    ExecuteJoystickCall executeJoystickCall = new ExecuteJoystickCall();

    private void Start()
    {
        executeJoystickCall.joystickInput.posX = 0;
        executeJoystickCall.joystickInput.posY = 0;
    }

    public void Call(string jsonData)
    {
        executeJoystickCall.Call (jsonData);
    }

    private void Update()
    {
        // Call("{\"posX\":1,\"posY\":-1}");
        float hozizontal = executeJoystickCall.joystickInput.posX;
        float vertical = executeJoystickCall.joystickInput.posY;

        Move (hozizontal, vertical);
    }

    private void FixedUpdate()
    {
        // if (hozizontal != 0 || vertical != 0)
        // {
        Fire();

        // }
    }
}
