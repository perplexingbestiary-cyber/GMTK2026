using UnityEngine;

public class DoorButtonController : MonoBehaviour
{
    public GameObject Door;
    void OnTriggerEnter2D()
    {
        Door.SetActive(false);
        gameObject.SetActive(false);
    }
}
