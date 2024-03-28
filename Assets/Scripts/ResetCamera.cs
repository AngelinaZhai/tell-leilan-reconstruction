using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCamera : MonoBehaviour
{
    // Reference to the main camera GameObject
    public GameObject mainCamera;

    // Store the original position and rotation of the camera
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    void Start()
    {
        // Store the original position and rotation of the camera
        originalPosition = mainCamera.transform.position;
        originalRotation = mainCamera.transform.rotation;
    }

    // Function to reset the camera position and rotation
    public void RecenterCamera()
    {
        // Reset the position and rotation of the camera
        mainCamera.transform.position = originalPosition;
        mainCamera.transform.rotation = originalRotation;
    }
}
