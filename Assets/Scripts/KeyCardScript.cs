using UnityEngine;

public class KeyCardScript : MonoBehaviour
{
    public bool green;
    public bool blue;
    public bool red;
    public bool fire;

    public ElevatorController elevatorController;
    public GameObject Sprite;
    public GameObject Gate;

    void OnTriggerEnter2D()
    {
        

        if (red)
        {
            elevatorController.RedKeyCard();
            Sprite.SetActive(false);
        Gate.SetActive(false);
        }
        else if (green)
        {
            elevatorController.GreenKeyCard();
            Sprite.SetActive(false);
        Gate.SetActive(false);
        }
        else if (blue)
        {
            elevatorController.EndKeyCard();
            Sprite.SetActive(false);
        Gate.SetActive(false);
        }
        else if (fire)
        {
            Sprite.SetActive(false);
            Gate.SetActive(true);
        }
        
        
    }
}
