using UnityEngine;

public class RotateController : MonoBehaviour
{
public float rotationSpeed = 100f;
public Transform TargetTransform;
private void Update()
    {
        TargetTransform.Rotate(Vector3.up*rotationSpeed* Time.deltaTime);
    }
}
