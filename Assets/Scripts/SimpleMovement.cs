using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public Vector3 direction = new Vector3(0f, 0f, 0f);
    public float speed = 0f;
    void FixedUpdate()
    {
        transform.position += direction.normalized * speed * Time.fixedDeltaTime;
    }
}
