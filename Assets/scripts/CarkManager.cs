using UnityEngine;
public class CarkManager : MonoBehaviour
{
    public Transform carkObjesi;
    public float returnspeed = 100;
    public float harekethizi=2f;
    public float maxPosition = 1.3f;
    public float minPosition = -1.3f;
    private void Update()
    {
        carkObjesi.Rotate(Vector3.right* returnspeed * Time.deltaTime);
        float hareketYonu=Mathf.PingPong(Time.time*harekethizi, maxPosition - minPosition)+ minPosition;
        carkObjesi.transform.localPosition=new Vector3(carkObjesi.transform.localPosition.x,
        carkObjesi.transform.localPosition.y,hareketYonu);
    }

}
