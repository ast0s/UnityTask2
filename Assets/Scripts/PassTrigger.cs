using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassTrigger : MonoBehaviour
{
    public int triggerCounter = 0;
    private void OnTriggerEnter(Collider other)
    {
        triggerCounter++;
    }
}
