using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   [SerializeField] Transform target;
   [SerializeField] Vector3 offset = Vector3.zero;
   [SerializeField] float smoothness = 1f;

   private void LateUpdate() {
      Vector3 pos = transform.position;
      pos.x = Mathf.Lerp(pos.x, (target.position - offset).x, smoothness * Time.deltaTime);
      transform.position = pos;
   }
}
