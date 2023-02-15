using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    public float hitforce = 1;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            RaycastHit hit;

            Physics.Raycast(transform.position, new Vector3(-1, 0, 0), out hit, 12);

            if (hit.rigidbody != null)
            {
                hit.collider.attachedRigidbody.AddForce(-hit.normal * hitforce);
            }

            Debug.DrawRay(transform.position, new Vector3(-12, 0, 0), Color.red);
        }
    }
}
