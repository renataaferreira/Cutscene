using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;        // Player (Krebs)
    public float smoothSpeed = 5f;   // Suavidade da câmera
    public Vector3 offset;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );

        transform.position = smoothPosition;
    }
}
