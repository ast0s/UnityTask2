using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulerAnglesRotation : MonoBehaviour
{
    public float RPM = 60f;
    public Vector3 axis = new Vector3(0,0,0);
    
    void FixedUpdate()
    {
        transform.eulerAngles += axis.normalized * RPM / 60 * 360 * Time.fixedDeltaTime;
    }
}
