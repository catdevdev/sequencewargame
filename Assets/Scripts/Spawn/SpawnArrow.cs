using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrow : MonoBehaviour
{
    [SerializeField]
    EnemySpawn enemy;

    [SerializeField]
    UserSpawn user;

    public void Spawn(string type)
    {
        switch (type)
        {
            case "user":
                user.Spawn();
                break;
            case "enemy":
                // enemy.Spawn (spawnPointX, spawnPointY);
                break;
        }
    }

    private void Start()
    {
        Spawn("user");
        Spawn("user");
        Spawn("user");
   
    }
}
