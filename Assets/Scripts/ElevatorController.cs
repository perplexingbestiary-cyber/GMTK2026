using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += Vector3.up * speed * Time.deltaTime;
            
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
