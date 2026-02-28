using UnityEngine;

public class CameraController : MonoBehaviour
{
   public Transform target;
   Vector3 offset = Vector3.zero;
   private void Start()
   {
     offset = transform.position - target.position;
   }
   void LateUpdate()
   {
     //transform.position = target.position+ offset;
     Vector3 mevcutPos = transform.position;
     Vector3 TargetPos = new Vector3(mevcutPos.x, target.position.y + offset.y, target.position.z + offset.z);
     transform.position = TargetPos;

   }

}
