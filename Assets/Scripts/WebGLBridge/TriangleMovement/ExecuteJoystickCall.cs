using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteJoystickCall : JoystickCall
{
    public override void Call(string jsonData)
    {
        base.Call(jsonData);
        // Spawn (spawn);
        // Instantiate(enemyBot,
        // new Vector2(2, 3),
        // Quaternion
        //     .Euler(new Vector3(0,
        //         0,
        //         spawn.instantiate.positionData.rotate.deg)));
    }

    private void Start()
    {
        // Call("{\"posX\":\"10\",\"posY:\"\"15\"}");
    }
}
