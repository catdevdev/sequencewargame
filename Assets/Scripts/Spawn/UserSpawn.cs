using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserSpawn : MonoBehaviour
{
    public int spawnPointX;

    public int spawnPointY;

    [SerializeField]
    GameObject userSpaceship;

    public void Spawn()
    {
        spawnPointX = Random.Range(-5, 5);
        spawnPointY = Random.Range(-4, 4);
        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, 0);
        Instantiate(userSpaceship, spawnPosition, Quaternion.identity);
    }
}
