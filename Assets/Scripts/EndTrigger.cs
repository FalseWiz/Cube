using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
   
    void OnTriggerEnter ()
    {
        Debug.Log("Level Won!");
        gameManager.ComleteLevel ();
    }

}
