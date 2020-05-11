using UnityEngine;
public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset; // holds three floats, (x,y,z)

    // Update is called once per frame
    void Update()
    {
        //transform is linked to the transform-component of the camera, as camera is the object inheriting the script.
        transform.position = (player.position + offset); //the camera position is the same as the player. other +- values are altered directly in Unity.
    }
}
