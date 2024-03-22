using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update()
    {
        Invoke("Rotate", 1f);     
    }
    void Rotate()
    {
        transform.Rotate(new Vector3(0f, 1f, 0f));
    }
}
