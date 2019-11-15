using UnityEngine;

public class GravityPoint : MonoBehaviour
{
    public GameObject player;
    public GameObject box;
    private Rigidbody rbPlayer;
    private Transform tPlayer;
    private Transform tBox;
    private Collider cBox;
    public float constant;
    private float lifespan;

    void Start()
    {
      if(player == null)
      {
        player = GameObject.Find("Player(Clone)");
      }

      tBox = box.GetComponent<Transform>();
      cBox = box.GetComponent<Collider>();
      rbPlayer = player.GetComponent<Rigidbody>();
      tPlayer = player.GetComponent<Transform>();
      lifespan = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

      Vector3 closestSurfacePoint = cBox.ClosestPoint(tPlayer.position);
      Vector3 dir = closestSurfacePoint - tPlayer.position;
      float dist = dir.magnitude;
      Vector3 force = dir/(dist*dist*dist) * rbPlayer.mass * constant;
      rbPlayer.AddForce(force);

      lifespan += Time.deltaTime;
      Debug.Log(player.name);
      /*
      if(lifespan > 10.0f)
      {
        Destroy(box);
      }
      */
    }
}
