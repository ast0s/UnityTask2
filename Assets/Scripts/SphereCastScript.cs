using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCastScript : MonoBehaviour
{
    public GameObject currentHitObject;

    public float radius = 1f;
    public float maxDistance;
    public LayerMask layerMask;

    private Vector3 origin;
    private Vector3 direction;

    private float currentHitDistance;
    private void Update()
    {
        origin = transform.position;
        direction = transform.forward;

        RaycastHit hit;
        if (Physics.SphereCast(origin, radius, direction, out hit, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal))
        {
            currentHitObject = hit.transform.gameObject;
            currentHitDistance = hit.distance;
            Debug.Log("SphereCast hit something!");
        }
        else
        {
            currentHitDistance = maxDistance;
            currentHitObject = null;
            Debug.Log("Nothing was hit by SphereCast(");
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Debug.DrawLine(origin, origin + direction * currentHitDistance);
        Gizmos.DrawWireSphere(origin + direction * currentHitDistance, radius);
    }
}
