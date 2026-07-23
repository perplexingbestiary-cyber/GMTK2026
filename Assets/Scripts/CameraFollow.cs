using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothTime = 0.3f;

    private Vector3 velocity;

    public void Start()
    {
        offset = new Vector3(0f, 3.4f, 0f);

    }

    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref velocity, smoothTime);
    }
}
