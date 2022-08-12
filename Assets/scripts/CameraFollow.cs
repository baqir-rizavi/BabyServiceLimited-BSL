using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   [SerializeField] Transform target;
   [SerializeField] Vector3 offset = Vector3.zero;
   [SerializeField] float smoothness = 1f;

   private void LateUpdate() {
      transform.position = Vector3.Lerp(transform.position, target.position - offset, smoothness * Time.deltaTime);
   }
}
