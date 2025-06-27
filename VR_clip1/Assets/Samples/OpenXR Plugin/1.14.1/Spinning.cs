using UnityEngine;
public class SpinGlobe : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 20 * Time.deltaTime, 0); // Rotates around Y-axis
    }
}