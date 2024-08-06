using UnityEngine;
using Cinemachine;

public class BrawlStarsmovement : MonoBehaviour
{
    public CinemachineFreeLook freeLookCamera;
    public Transform player;

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Check if the player is moving forward or backward
        if (Mathf.Abs(verticalInput) > 0)
        {
            // Prevent camera rotation around the player
            freeLookCamera.m_XAxis.m_MaxSpeed = 0;
        }
        else if (Mathf.Abs(horizontalInput) > 0)
        {
            // Allow camera rotation when moving left or right
            freeLookCamera.m_XAxis.m_MaxSpeed = 300; // Adjust this value as needed
        }
        else
        {
            // Allow camera rotation when idle
            freeLookCamera.m_XAxis.m_MaxSpeed = 300; // Adjust this value as needed
        }
    }
}
