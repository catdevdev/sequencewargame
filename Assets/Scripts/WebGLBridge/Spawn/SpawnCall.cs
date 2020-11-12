using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCall : MonoBehaviour
{
    public Spawn spawn;

    public virtual void Call(string jsonData)
    {
        spawn = JsonUtility.FromJson<Spawn>(jsonData);

    
    }

    private void Start()
    {
        // Call("{\"typeCall\":\"spawn\",\"instantiate\":{\"entityData\":{\"type\":\"playerJoystick\",\"id\":\"f4fjkd1dj3d4\",\"entityName\":\"arrow\",\"nickName\":\"lol228322\",\"team\":\"1\",\"color\":\"#aa23aa\"},\"positionData\":{\"position\":{\"x\":10,\"y\":20},\"rotate\":{\"deg\":90}}}}");
    }
}

// {
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
// {
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
// {
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
