using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonCall : MonoBehaviour
{
    Call call;

    void Call(string jsonData)
    {
        call = JsonUtility.FromJson<Call>(jsonData);
    }
}
