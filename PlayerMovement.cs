using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }
    }
}
