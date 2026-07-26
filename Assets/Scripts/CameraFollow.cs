using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothTime = 0.3f;
    public float value;
    public float t;
    public float speed;

    public bool cursorVisible;

    private Vector3 velocity;

    public void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        
        
        
        offset = new Vector3(0f, 1f, 0f);
       // QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
       // Application.targetFrameRate = 4;

    }

    private void LateUpdate()
    {
        Camera.main.orthographicSize = value;
        
        value = Mathf.Lerp(499.28f, 6.48f, t);

        t += speed*Time.deltaTime;

        if(value == 6.48)
        {
            t = 0;
        }
        
        if (!cursorVisible && Cursor.visible)
        {
          Cursor.visible = false;  
        }
        else if (cursorVisible && !Cursor.visible)
        {
            Cursor.visible = true;  
        }

        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref velocity, smoothTime);
    }
}
        

