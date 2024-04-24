using UnityEngine;

public class Stabilizer : MonoBehaviour
{
    public float stabilizationSpeed = 5f;

    void Update()
    {
        // Get the current rotation of the object
        Quaternion currentRotation = transform.rotation;

        // Calculate the target rotation (upright position)
        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, Vector3.up) * currentRotation;

        transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, stabilizationSpeed * Time.deltaTime);
    }
}
