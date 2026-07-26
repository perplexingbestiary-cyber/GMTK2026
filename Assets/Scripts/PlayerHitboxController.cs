using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHitboxController : MonoBehaviour
{

    public Transform Player;
    public bool tutorial;
    public bool white;
    public bool green;
    public bool red;
void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("DeathScene");

        Debug.Log("contact");
    }
void Update()
    {
        transform.position = Player.position;
    }
}
