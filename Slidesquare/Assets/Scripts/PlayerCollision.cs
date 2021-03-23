using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController controller;
    private GameManager gameManager;
    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerExit(Collider objectInfo)
    {
        if(objectInfo.tag == "Ground")
        {
            gameManager.EndGame();
        }
    }

    void OnCollisionEnter(Collision objectInfo)
    {
        if (objectInfo.collider.tag == "Obstacle")
        {
            gameManager.EndGame();
            //Application.LoadLevel(Application.loadedLevel);
        }
    }

    void OnTriggerEnter(Collider objectInfo)
    {
        if(objectInfo.tag == "Deadzone")
        {
            Destroy(gameObject);
        }
    }
}

