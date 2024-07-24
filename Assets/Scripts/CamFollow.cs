using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField]
    Transform target;
  
    Vector3 velocity = Vector3.zero;

    public Vector3 offset;

    private float smooth = 0.25f;

    private void FixedUpdate()
    {
        if (target != null && target.position.y > -8)
        {
            Vector3 targetPos = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smooth);
        }
    }
}
