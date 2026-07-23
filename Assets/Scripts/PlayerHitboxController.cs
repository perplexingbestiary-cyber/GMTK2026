using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHitboxController : MonoBehaviour
{
void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("DeathScene");
        Debug.Log("contact");
    }
}
