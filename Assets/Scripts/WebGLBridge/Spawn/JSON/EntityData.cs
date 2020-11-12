using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EntityData
{
   public string type;
   public string id;
   public string entityName;
   public string nickName;
   public string team;
   public string color;
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