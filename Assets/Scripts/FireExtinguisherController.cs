using UnityEngine;

public class FireExtinguisherController : MonoBehaviour
{
    public Transform gun; // Reference to the gun object
    public Camera mainCamera;
    public Rigidbody2D rigidbody2D;
    public float thrust;
    public GameObject Thruster;

    void Update()
    {
        

        if (mainCamera == null) mainCamera = Camera.main;
        if (gun == null) gun = transform;

        // 1. Get mouse position in world space
        Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        
        // 2. Ensure Z matches the player/gun depth (assuming Z is 0 or fixed)
        mouseWorldPos.z = transform.position.z;

        // 3. Calculate direction vector
        Vector2 direction = (Vector2)mouseWorldPos - (Vector2)transform.position;

        // 4. Calculate angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 5. Apply rotation (Quaternion.Euler for 2D Z-axis rotation)
        // Subtract 90 degrees if your sprite faces right by default, adjust as needed
        gun.rotation = Quaternion.Euler(0, 0, angle);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rigidbody2D.AddForce(-direction * thrust, ForceMode2D.Force);
            Thruster.SetActive(true);
            Invoke(nameof(ThrusterOff), 0.3f);
            Debug.Log("moving");
        }
    }

    public void ThrusterOff()
    {
        Thruster.SetActive(false);
    }
}
