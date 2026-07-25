using UnityEngine;

public class DoorButtonController : MonoBehaviour
{
    public GameObject Door;
    public GameObject Door_outline;
    public GameObject button_outline;
    void OnTriggerEnter2D()
    {
        Door.SetActive(false);
        gameObject.SetActive(false);
    }
}
