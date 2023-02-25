using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class SimpleRotation : MonoBehaviour
{
    public float RPM = 60f;
    public Vector3 axis = new Vector3(0, 0, 0);
    void Update()
    {
        transform.Rotate(axis.normalized * RPM / 60 * 360 * Time.fixedDeltaTime);
    }
}
