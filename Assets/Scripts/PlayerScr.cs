using UnityEngine;

public class PlayerScr : MonoBehaviour
{

        public Rigidbody rb;

        public float ForwardForce = 2000f;
        public float SideForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Сучара");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);


        if (Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
