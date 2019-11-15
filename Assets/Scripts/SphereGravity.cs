using UnityEngine;

public class SphereGravity : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private Transform tPlayer;
    private float constant = 100;
    private GameObject sphere;
    private MeshCollider cSphere;
    private Transform tSphere;

    void Start()
    {
      sphere = GameObject.Find("Boundary");
      tSphere = sphere.GetComponent<Transform>();
      rbPlayer = GetComponent<Rigidbody>();
      tPlayer = GetComponent<Transform>();
      cSphere = sphere.GetComponent<MeshCollider>();
      tSphere = sphere.GetComponent<Transform>();
    }


    void Update()
    {
      //Vector3 closestSurfacePoint = Physics.ClosestPoint(tPlayer.position, cSphere, tSphere.position, Quaternion.identity);
      //Vector3 dir = closestSurfacePoint - tPlayer.position;
      //float dist = dir.magnitude;
      //Vector3 force = dir/(dist*dist*dist) * rbPlayer.mass * constant;
      //rbPlayer.AddForce(force);
      //Debug.DrawLine(tSphere.position, tPlayer.position, Color.red);
      //Debug.Log(cSphere.ClosestPointOnBounds(tPlayer.position));
    }
}
