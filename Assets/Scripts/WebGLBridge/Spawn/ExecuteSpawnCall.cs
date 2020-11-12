using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ExecuteSpawnCall : SpawnCall
{
    [SerializeField]
    GameObject enemyBot;

    [SerializeField]
    GameObject ownBot;

    [SerializeField]
    GameObject playerJoystick;

    public override void Call(string jsonData)
    {
        base.Call(jsonData);

        Spawn (spawn);
        // Instantiate(enemyBot,
        // new Vector2(2, 3),
        // Quaternion
        //     .Euler(new Vector3(0,
        //         0,
        //         spawn.instantiate.positionData.rotate.deg)));
    }

    private void Start()
    {
        // Call("{\"typeCall\":\"spawn\",\"instantiate\":{\"entityData\":{\"type\":\"playerJoystick\",\"id\":\"f4fjkd1dj3d4\",\"entityName\":\"arrow\",\"nickName\":\"lol228322\",\"team\":\"1\",\"color\":\"#aa23aa\"},\"positionData\":{\"position\":{\"x\":1,\"y\":1},\"rotate\":{\"deg\":45}}}}");
    }

    private void SpawnGameObj(GameObject gameObject, string name)
    {
        GameObject createdGameObject =
            Instantiate(gameObject,
            new Vector2(spawn.instantiate.positionData.position.x,
                spawn.instantiate.positionData.position.y),
            Quaternion
                .Euler(new Vector3(0,
                    0,
                    spawn.instantiate.positionData.rotate.deg)));
        createdGameObject.name = name;
    }

    private void Spawn(Spawn spawn)
    {
        // check on type
        string type = spawn.instantiate.entityData.type;
        string id = spawn.instantiate.entityData.id;
        switch (type)
        {
            case "playerJoystick":
                SpawnGameObj(playerJoystick, $"playerJoystick-{id}");
                break;
            
        }
    }
}

// {
//   typeCall: "spawn",
//   Instantiate: {
//     entityData: {
//       type: "playerJoystick"
//       id: "f4fjkd1dj3d4",
//       entityName: "trianle",
//       nickName: "lol228322",
//       team: "1",
//       color: "#aa23aa",
//     },
//     positionData: {
//       position: {x: 10, y: 20},
//       rotate: {deg: 90}
//     }
//   }
// }
