using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
    public Transform player;
    public float zOffset;
    public float smoothAmount;

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position + new Vector3(0f, 0f, zOffset), smoothAmount);
    }
}
