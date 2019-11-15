using UnityEngine;

public class ObjectGravity : MonoBehaviour
{

    public Rigidbody player;

    public Transform play;

    public Transform obstacle;

    public float dist;

    public float force = 5f;

    public Vector3 dir;

    //public Collider person;

    //public Collider obj;

    //public bool hasTouched = false;

    // Update is called once per frame
    void Update()
    {
      dist = Vector3.Distance(obstacle.position, play.position);
      if(dist <= 15)
      {
        dir = obstacle.position - play.position;
        dir = dir.normalized;
        //if(hasTouched)
        //{
          //force *= -1;
        //}
        //player.AddForce(dir * force);
      }

      //if(person.IsTouching(obj))
      //{
        //hasTouched == true;
      //}
    }
}
