using UnityEngine;

public class ZeroGMovementController : MonoBehaviour
{
    public bool gravity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gravity)
        {
           // Debug.Log("gravity");
        }
        else if (!gravity)
        {
           // Debug.Log("no gravity");
        }
    }
    public void Go()
    {
        gravity = false;
        
    }

    public void Stop()
    {
        gravity = true;
    }
}
