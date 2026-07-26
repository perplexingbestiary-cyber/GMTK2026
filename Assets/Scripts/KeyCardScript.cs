using UnityEngine;

public class KeyCardScript : MonoBehaviour
{
    public bool green;
    public bool blue;
    public bool red;

    public ElevatorController elevatorController;
    public GameObject Sprite;
    public GameObject Gate;

    void OnTriggerEnter2D()
    {
        Sprite.SetActive(false);
        Gate.SetActive(false);

        if (red)
        {
            elevatorController.RedKeyCard();
        }
        else if (green)
        {
            elevatorController.GreenKeyCard();
        }
        else if (blue)
        {
            elevatorController.EndKeyCard();
        }
        
        
    }
}
