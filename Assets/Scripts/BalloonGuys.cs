using UnityEngine;

public class BalloonGuys : MonoBehaviour
{
    //public BoxCollider2D collider;
    //public GameObject Balloon;
    public float desiredHeight;
    public float desiredWidth;
    public float speed;
    public bool triggered;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        desiredHeight = 1;
        desiredWidth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(desiredHeight < 10 && triggered)
        {
        desiredHeight += Time.deltaTime * speed;
        desiredWidth += Time.deltaTime * speed;

        //collider.size = new Vector2(desiredWidth, desiredHeight);
        transform.localScale = new Vector2(desiredWidth, desiredHeight);
        }
        
    }
    void OnTriggerEnter2D()
    {
        triggered = true;
    }
}
