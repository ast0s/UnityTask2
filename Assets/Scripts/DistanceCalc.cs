using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalc : MonoBehaviour
{
    public GameObject floor;
    public float distance;
    void Update()
    {
        distance = this.transform.position.y - floor.transform.position.y - this.transform.localScale.y / 2;
    }
}
