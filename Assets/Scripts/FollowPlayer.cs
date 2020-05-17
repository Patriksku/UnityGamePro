using UnityEngine;
public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    public Vector3 offset; // holds three floats, (x,y,z)
    private Vector3 rotationCamera = new Vector3(0f, 0f, 0f);

    // Variables for camera rotation while mouse-wheel is pressed down
    // Meaning of Yaw and Pitch --> https://howthingsfly.si.edu/flight-dynamics/roll-pitch-and-yaw
    private float speedOfRotation = 3f;
    private float yaw = 0f;
    private float pitch = 0f;

    private bool mouseWheelRotation = false;

    private void resetRotationCamera()
    {
        rotationCamera.x = 0;
        rotationCamera.y = 0;
        rotationCamera.z = 0;
    }

    private void setRotationCamera(float x, float y, float z)
    {
        rotationCamera.x = x;
        rotationCamera.y = y;
        rotationCamera.z = z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            setRotationCamera(0f, -90f, 0f);
            transform.position = (player.position + offset);
            transform.rotation = Quaternion.Euler(rotationCamera);
            Debug.Log("left");
        } 
        else if (Input.GetKey("right"))
        {
            setRotationCamera(0f, 90f, 0f);
            transform.position = (player.position + offset);
            transform.rotation = Quaternion.Euler(rotationCamera);
            Debug.Log("right");
        } 
        else if (Input.GetKey("down"))
        {
            setRotationCamera(0f, -180f, 0f);
            transform.position = (player.position + offset);
            transform.rotation = Quaternion.Euler(rotationCamera);
            Debug.Log("down");
        } 
        else // standard camera position --> Forward direction
        {
            resetRotationCamera();
            transform.rotation = Quaternion.Euler(rotationCamera);
            //transform is linked to the transform-component of the camera, as camera is the object inheriting the script.
            transform.position = (player.position + offset); //the camera position is the same as the player. other +- values are altered directly in Unity.
        }

        if (Input.GetMouseButton(2))
        {
            yaw += speedOfRotation * Input.GetAxis("Mouse X");
            pitch += speedOfRotation * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(-pitch, yaw, 0f);
        }

        if (Input.GetMouseButtonUp(2))
        {
            yaw = 0f;
            pitch = 0f;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
} 
