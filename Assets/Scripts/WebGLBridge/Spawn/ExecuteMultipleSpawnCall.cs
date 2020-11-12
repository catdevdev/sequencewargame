﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteMultipleSpawnCall : SpawnMultipleCall
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
        Spawn (spawns);
    }

    private void Start()
    {
        Call("{\"spawns\":[{\"typeCall\":\"spawn\",\"instantiate\":{\"entityData\":{\"type\":\"playerJoystick\",\"id\":\"f4fjkd1dj3d4\",\"entityName\":\"arrow\",\"nickName\":\"lol228322\",\"team\":\"1\",\"color\":\"#aa23aa\"},\"positionData\":{\"position\":{\"x\":1,\"y\":1},\"rotate\":{\"deg\":180}}}},{\"typeCall\":\"spawn\",\"instantiate\":{\"entityData\":{\"type\":\"playerJoystick\",\"id\":\"32fjkd1dj3d4\",\"entityName\":\"arrow\",\"nickName\":\"test2\",\"team\":\"1\",\"color\":\"#a323aa\"},\"positionData\":{\"position\":{\"x\":1,\"y\":-1},\"rotate\":{\"deg\":45}}}},{\"typeCall\":\"spawn\",\"instantiate\":{\"entityData\":{\"type\":\"playerJoystick\",\"id\":\"4afjkd1dj3d4\",\"entityName\":\"arrow\",\"nickName\":\"test3\",\"team\":\"1\",\"color\":\"#aa23aa\"},\"positionData\":{\"position\":{\"x\":-1,\"y\":-1},\"rotate\":{\"deg\":34}}}}]}");
    }

    private void SpawnGameObj(GameObject gameObject, string name, Spawn spawn)
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

    private void Spawn(Spawns spawns)
    {
        // check on type
        foreach (Spawn spawn in spawns.spawns)
        {
            string type = spawn.instantiate.entityData.type;
            string id = spawn.instantiate.entityData.id;
            switch (type)
            {
                case "playerJoystick":
                    SpawnGameObj(playerJoystick, $"playerJoystick-{id}", spawn);
                    break;
            }
        }
    }
}