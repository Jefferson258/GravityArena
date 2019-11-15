using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 100f;

    public float backwardForce = -100f;

    public float leftForce = -100f;

    public float rightForce = 100f;

    public float upForce = 20f;

    public float downForce = -20f;

    public Rigidbody player;

    public float maxSpeed = 20f;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey("e"))
        {
          player.AddForce(0, 0, forwardForce);
        }

        if(Input.GetKey("a"))
        {
          player.AddForce(leftForce, 0, 0);
        }

        if(Input.GetKey("d"))
        {
          player.AddForce(rightForce, 0, 0);
        }

        if(Input.GetKey("s"))
        {
          player.AddForce(0, 0, backwardForce);
        }

        if(Input.GetKey("w"))
        {
          player.AddForce(0, upForce, 0);
        }

        if(Input.GetKey("x"))
        {
          player.AddForce(0, downForce, 0);
        }

    }

    void FixedUpdate()
    {
                if(player.velocity.magnitude > maxSpeed)
              {
                 player.velocity = player.velocity.normalized * maxSpeed;
                 //Debug.Log(player.velocity);
              }
    }
}
