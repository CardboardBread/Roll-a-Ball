using UnityEngine;
using System.Collections;

public class BoardController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);

        transform.Rotate(movement * speed);
    }

    void Update()
    {
        Vector3 xRelax = new Vector3(1, 0, 0);
        Vector3 zRelax = new Vector3(0, 0, 1);

        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            if (transform.localEulerAngles.x > 0 && transform.localEulerAngles.x < 90)
            {
                transform.Rotate(-xRelax);
            }
            else if (transform.localEulerAngles.x > 0 && transform.localEulerAngles.x > 90)
            {
                transform.Rotate(xRelax);
            }

            if (transform.localEulerAngles.z > 0 && transform.localEulerAngles.z < 90)
            {
                transform.Rotate(-zRelax);
            }
            else if (transform.localEulerAngles.z > 0 && transform.localEulerAngles.z > 90)
            {
                transform.Rotate(zRelax);
            }
        }
    }
}