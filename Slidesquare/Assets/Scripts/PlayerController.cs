using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    //public float movementSpeed = 4000f;
    public float strafeSpeed = 350f;
    public Transform groundLevel;
    private GameManager gameManager;
    //Update calls slower than FixedUpdate
    //FixedUpdate is used for physics!!!

    // Start is called before the first frame update
    
    /*
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        //Comentariu de consola este Debug.Log("Mesaj");

    }
    */

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Added to obstacles instead
        //rb.AddForce(0, 0, movementSpeed * Time.deltaTime);

        //Movement
        if(Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            //Velocity completely negates the mass.
            rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //Fixed
        /*
        if (rb.position.y < groundLevel.position.y)
        {
            gameManager.EndGame();
        }
        */

        //Pause check
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            gameManager.PauseGame();
        }

    }
}
