using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
   public Transform target;
   public float camSpeed = 0.125f;
   public Vector3 offset;
   public Vector3 velocity = Vector3.zero;

   //LateUpdate = om de x miliseconde volg de speelr positie
   void LateUpdate ()
   {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, camSpeed);
        transform.position = smoothedPosition;
   }
}
