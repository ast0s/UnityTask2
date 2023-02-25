using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRotation : MonoBehaviour
{
    public float RPM = 60f;
    public Vector3 axis = new Vector3(1, 0, 0);

    private void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(RPM / 60 * 360 * Time.fixedDeltaTime, axis);
    }
}
