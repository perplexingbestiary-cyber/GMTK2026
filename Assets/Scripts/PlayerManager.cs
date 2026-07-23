using UnityEngine;
using TarodevController;

public class PlayerManager : MonoBehaviour
{
    public bool gravity;
    public bool playerMovementOn;
    public bool zeroGMovementOn;
    public bool fireOn;

    public float countDown;


    public PlayerController playerController;
    public ZeroGMovementController zeroGMovementController;
    public FireExtinguisherController fireExtinguisher;

    public float currentTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gravity = false;
        playerMovementOn = true;
        zeroGMovementOn = false;
        fireOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > countDown && !gravity)
        {
           gravity = true;
            currentTime = 0;
        }
        else if(currentTime > countDown && gravity)
        {
            gravity = false;
            currentTime = 0;
        }


        if (!gravity && playerMovementOn)
        {
            playerController.Stop();
            Debug.Log("player controller stopped");
            playerMovementOn = false;
        }
        else if (gravity && !playerMovementOn)
        {
            playerController.Go();
            Debug.Log("player controller started");
            playerMovementOn = true;
        }
        
        else if(!gravity && !zeroGMovementOn)
        {
            zeroGMovementController.Go();
            Debug.Log("zerg controller started");
            zeroGMovementOn = true;
        }
        else if(gravity && zeroGMovementOn)
        {
            zeroGMovementController.Stop();
            Debug.Log("zerog controller stopped");
            zeroGMovementOn = false;
        }

    }
}
