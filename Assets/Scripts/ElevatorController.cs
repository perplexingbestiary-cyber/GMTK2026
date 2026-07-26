using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public float speed = 5f;
    //

    public Transform White;
    public Transform Green;
    public Transform Red;
    public Transform End;

    public PlayerHitboxController playerHitbox;

    //public bool white;
    //public bool green;
    //public bool red;
    //public bool end;

    public bool noKeyCard;
    public bool greenKeyCard;
    public bool redKeyCard;
    public bool endKeyCard;
    
    public bool closedDoors;
    public bool playerInside;
    public GameObject Barrier;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        noKeyCard = true;
    }

    void OnTriggerEnter2D()
    {
        playerInside = true;
    }
    void OnTriggerExit2D()
    {
        playerInside = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        float step = Time.deltaTime * speed;
        if(playerInside && noKeyCard)
        {
            closedDoors = true;

            if(Vector2.Distance(transform.position, White.position) >= 0.001f)
            {
            transform.position = Vector2.MoveTowards(transform.position, White.position, step);
            
            }
            else if(Vector2.Distance(transform.position, White.position) <= 0.001f)
            {
                noKeyCard = false;
                closedDoors = false;
                playerHitbox.White();
            }
        }

        if(playerInside && greenKeyCard)
        {
            closedDoors = true;
           if(Vector2.Distance(transform.position, Green.position) >= 0.001f)
            {
            transform.position = Vector2.MoveTowards(transform.position, Green.position, step);
            } 
            else if(Vector2.Distance(transform.position, Green.position) <= 0.001f)
            {
                greenKeyCard = false;
                closedDoors = false;
                playerHitbox.Green();
            }
        }  

        if(playerInside && redKeyCard)
        {
            closedDoors = true;
           if(Vector2.Distance(transform.position, Red.position) >= 0.001f)
            {
            transform.position = Vector2.MoveTowards(transform.position, Red.position, step);
            } 
            else if(Vector2.Distance(transform.position, Red.position) <= 0.001f)
            {
                redKeyCard = false;
                closedDoors = false;
                playerHitbox.Red();
            }
        } 

        if(playerInside && endKeyCard)
        {
            closedDoors = true;
           if(Vector2.Distance(transform.position, End.position) >= 0.001f)
            {
            transform.position = Vector2.MoveTowards(transform.position, End.position, step);
            } 
            else if(Vector2.Distance(transform.position, End.position) <= 0.001f)
            {
                endKeyCard = false;
                closedDoors = false;
            }
        }
        /*
if (Input.GetKey(KeyCode.UpArrow))
    transform.position += Vector3.up * speed * Time.deltaTime;

if (Input.GetKey(KeyCode.DownArrow))
    transform.position += Vector3.down * speed * Time.deltaTime;
    */

        if (closedDoors)
        {
            Barrier.SetActive(true);
        }
        else if (!closedDoors)
        {
            Barrier.SetActive(false);
        }

    }


    public void GreenKeyCard()
    {
        greenKeyCard = true;
    }

    public void RedKeyCard()
    {
        redKeyCard = true;
    }

    public void EndKeyCard()
    {
        endKeyCard = true;
    }

    public void PlayerInside()
    {
        playerInside = true;
    }

    public void PlayerNotInside()
    {
        playerInside = false;
    }

    public void ClosedDoors()
    {
        closedDoors = true;
    }
}
