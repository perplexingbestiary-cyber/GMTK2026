using UnityEngine;

public class Geyser : MonoBehaviour
{
    public bool geyserOn;
    public float currentTime;
    public GameObject GeyserObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GeyserObject.SetActive(false);
        geyserOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > 7f && !geyserOn)
        {
            GeyserObject.SetActive(true);
            geyserOn = true;
            currentTime = 0f;
        }
        else if(currentTime > 3f && geyserOn)
        {
           GeyserObject.SetActive(false);
            geyserOn = false;
            currentTime = 0f; 
        }
    }
}
