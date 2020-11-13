using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMultipleCall : MonoBehaviour
{
    public Spawns spawns;

    public virtual void Call(string jsonData)
    {
        spawns = JsonUtility.FromJson<Spawns>(jsonData);

        print(spawns.spawns[0].instantiate.positionData.position.x);
        // print(spawns.instantiate.positionDatas
    }

    private void Start()
    {
        // Call("{\"spawns\":[{\"typeCall\":\"spawn\",\"instantiate\":{\"entityData\":{\"type\":\"playerJoystick\",\"id\":\"f4fjkd1dj3d4\",\"entityName\":\"arrow\",\"nickName\":\"lol228322\",\"team\":\"1\",\"color\":\"#aa23aa\"},\"positionData\":{\"position\":{\"x\":1,\"y\":1},\"rotate\":{\"deg\":180}}}},{\"typeCall\":\"spawn\",\"instantiate\":{\"entityData\":{\"type\":\"playerJoystick\",\"id\":\"32fjkd1dj3d4\",\"entityName\":\"arrow\",\"nickName\":\"test2\",\"team\":\"1\",\"color\":\"#a323aa\"},\"positionData\":{\"position\":{\"x\":1,\"y\":-1},\"rotate\":{\"deg\":45}}}},{\"typeCall\":\"spawn\",\"instantiate\":{\"entityData\":{\"type\":\"playerJoystick\",\"id\":\"4afjkd1dj3d4\",\"entityName\":\"arrow\",\"nickName\":\"test3\",\"team\":\"1\",\"color\":\"#aa23aa\"},\"positionData\":{\"position\":{\"x\":-1,\"y\":-1},\"rotate\":{\"deg\":34}}}}]}");
    }
}
