using UnityEngine;

public class MouseLook360 : MonoBehaviour
{
    public float rotationSpeed = 2f;  // how fast the camera rotates
    public bool holdRightMouseOnly = true; // set false if you want always-on look

    private float yaw;   // left-right rotation
    private float pitch; // up-down rotation

    void Start()
    {
        // initialize with current rotation
        yaw = transform.eulerAngles.y;
        pitch = transform.eulerAngles.x;
    }

    void Update()
    {
        // Only rotate while holding right mouse button, if enabled
        if (holdRightMouseOnly && !Input.GetMouseButton(1)) // 1 = right mouse
        {
            return;
        }

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        yaw += mouseX * rotationSpeed;
        pitch -= mouseY * rotationSpeed; // invert so moving mouse up looks up

        // clamp vertical look so you can't flip upside down
        pitch = Mathf.Clamp(pitch, -80f, 80f);

        transform.rotation = Quaternion.Euler(pitch, yaw, 0f);
    }
}

