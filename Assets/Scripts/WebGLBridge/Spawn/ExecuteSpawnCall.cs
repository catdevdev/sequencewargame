using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteSpawnCall : SpawnCall
{
    public override void Call(string jsonData)
    {
        base.Call(jsonData);

        

        // Instantiate();
    }
}

// const dataCall = {
//   typeCall: "spawn",
//   Instantiate: {
//     entityData: {
//       id: "f4fjkd1dj3d4",
//       entityName: "arrow",
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
