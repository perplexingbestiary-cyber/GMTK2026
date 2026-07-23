using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathButtonController : MonoBehaviour
{
[SerializeField] private Button button;
//public GameObject mainMenu;
//public GameObject investmentMenu;

private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Asset Test");
        });
    }

}
