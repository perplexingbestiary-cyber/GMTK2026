using UnityEngine;

public class Geyser : MonoBehaviour
{
    public bool geyserOn;
    public float currentTime;
    public GameObject GeyserObject;
    public bool offset;

    public float On;
    public float Off;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (offset)
        {
            GeyserObject.SetActive(true);
        geyserOn = true;
        }
        else if (!offset)
        {
            GeyserObject.SetActive(false);
        geyserOn = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > Off && !geyserOn)
        {
            GeyserObject.SetActive(true);
            geyserOn = true;
            currentTime = 0f;
        }
        else if(currentTime > On && geyserOn)
        {
           GeyserObject.SetActive(false);
            geyserOn = false;
            currentTime = 0f; 
        }
    }
}
