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

    public Transform WhiteAnchor;
    public Transform GreenAnchor;
    public Transform RedAnchor;
void OnTriggerEnter2D()
    {
       // SceneManager.LoadScene("DeathScene");
        if (white)
        {
            Player.position = WhiteAnchor.position;
        }

        else if (green)
        {
            Player.position = GreenAnchor.position;
        }

        else if (red)
        {
            Player.position = RedAnchor.position;
        }

        Debug.Log("contact");
    }
void Update()
    {
        transform.position = Player.position;
    }

    public void White()
    {
        white = true;
        green = false;
        red = false;
    }

    public void Green()
    {
        white = false;
        green = true;
        red = false;
    }

    public void Red()
    {
        white = false;
        green = false;
        red = true;
    }
}
