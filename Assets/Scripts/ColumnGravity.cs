using UnityEngine;

public class ColumnGravity : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private Transform tPlayer;
    private float constant = 30;
    private GameObject column;
    private Collider cylinder;

    void Start()
    {
      column = GameObject.Find("Column");
      rbPlayer = GetComponent<Rigidbody>();
      tPlayer = GetComponent<Transform>();
      cylinder = column.GetComponent<Collider>();
    }

    void Update()
    {
         Vector3 closestSurfacePoint = cylinder.ClosestPoint(tPlayer.position);
         Vector3 dir = closestSurfacePoint - tPlayer.position;
         float dist = dir.magnitude;
         Vector3 force = dir/(dist*dist*dist) * rbPlayer.mass * constant;
         rbPlayer.AddForce(force);
    }
}
