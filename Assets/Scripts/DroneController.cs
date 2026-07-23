using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float speed;

    public Transform Drone;

    public Transform DroneAnchor1;
    public Transform DroneAnchor2;

    public bool droneAnchor1;
    public bool droneAnchor2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = Time.deltaTime * speed;

        if(Vector2.Distance(Drone.position, DroneAnchor1.position) <= 0.001f)
        {
            droneAnchor1 = true;
            droneAnchor2 = false;
        }
        else if(Vector2.Distance(Drone.position, DroneAnchor2.position) <= 0.001f)
        {
            droneAnchor1 = false;
            droneAnchor2 = true;
        }

        if (droneAnchor1)
        {
            Drone.position = Vector2.MoveTowards(Drone.position, DroneAnchor2.position, step);
        }
        else if (droneAnchor2)
        {
            Drone.position = Vector2.MoveTowards(Drone.position, DroneAnchor1.position, step);
        }
        
    }
}
