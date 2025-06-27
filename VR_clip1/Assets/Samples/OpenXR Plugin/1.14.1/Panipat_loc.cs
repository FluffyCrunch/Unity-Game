using UnityEngine;

public class CameraFocusPanipat : MonoBehaviour
{
    public Transform Panipat_loc;
    public float zoomSpeed = 5f;
    public float rotationSpeed = 2f;
    public float minDistance = 0.1f;

    void Update()
    {
        if (Panipat_loc != null)
        {
            // Move towards Panipat
            if (Vector3.Distance(transform.position, Panipat_loc.position) > minDistance)
            {
                transform.position = Vector3.Lerp(transform.position, Panipat_loc.position, Time.deltaTime * zoomSpeed);
            }

            // Rotate to look at Panipat
            Quaternion targetRotation = Quaternion.LookRotation(Panipat_loc.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
    }
}