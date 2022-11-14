
using UnityEngine;

public class Collision : MonoBehaviour
{
    public PlayerScr movement;
    public GameManager gameManager;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log("Oh shit!");

            FindObjectOfType<GameManager>().EndGame();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
