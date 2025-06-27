using UnityEngine;

public class VRMovement : MonoBehaviour
{
    public float speed = 2.0f; // Movement speed

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D keys
        float moveZ = Input.GetAxis("Vertical");   // W/S keys

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        transform.position += move * speed * Time.deltaTime;
    }
}
