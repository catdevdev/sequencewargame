using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCall : MonoBehaviour
{
    Spawn spawn;

    public void Call(string jsonData)
    {
        spawn = JsonUtility.FromJson<Spawn>(jsonData);
        print(spawn.typeCall);
        
        // print("GOOOOOOOD!");
        // spawn.Execute();
    }

    private void Start()
    {
        Call("{\"typeCall\":\"spawn\",\"Instantiate\":{\"entityData\":{\"id\":\"f4fjkd1dj3d4\",\"entityName\":\"arrow\",\"nickName\":\"lol228322\",\"team\":\"1\",\"color\":\"#aa23aa\"},\"positionData\":{\"position\":{\"x\":10,\"y\":20},\"rotate\":{\"deg\":90}}}}");
    }
}
