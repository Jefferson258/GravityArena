using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject pre_player;
    private GameObject player;
    private Rigidbody rbPlayer;
    public GameObject pre_column;
    private GameObject column;
    public GameObject pre_sphere;
    private GameObject sphere;
    private Vector3 initial = new Vector3(0,-99,0);
    private Vector3 offset = new Vector3(0, 2, -5);
    private Vector3 initalPos = new Vector3(41,41,-3);
    private Vector3 colRotate = new Vector3(0,0,45);
    public GameObject pre_cam;
    private GameObject tCam;
    private GameObject fCam;
    private Camera firstPCam;
    private Camera thirdPCam;
    private Transform tCamTransform;
    private Transform tPlayer;

    void Start()
    {
        player = Instantiate(pre_player, initial, Quaternion.identity);
        player.name = "First Player";
        player = GameObject.Find("First Player");
        tPlayer = player.GetComponent<Transform>();
        rbPlayer = player.GetComponent<Rigidbody>();
        tCam = Instantiate(pre_cam, new Vector3(0, 0, 0), new Quaternion());
        sphere = Instantiate(pre_sphere, new Vector3(0,0,0), new Quaternion());
        tCamTransform = tCam.GetComponent<Transform>();
        fCam = Instantiate(pre_cam, new Vector3(0, 0, 0), new Quaternion());
        firstPCam = fCam.GetComponent<Camera>();
        thirdPCam = tCam.GetComponent<Camera>();
        column = Instantiate(pre_column, initalPos, Quaternion.Euler(colRotate));
        column.name = "Column";
        sphere.name = "Boundary";
        tCam.name = "Third Person Camera";
        fCam.name = "First Person Camera";
        player.transform.parent = transform;
        tCam.transform.parent = transform;
        sphere.transform.parent = transform;
        fCam.transform.parent = transform;
        column.transform.parent = transform;
    }

    void Update()
    {
      tCam.transform.position = player.transform.position + offset;
      tCam.transform.LookAt(player.transform);
      fCam.transform.position = player.transform.position;
      /*
      if(rbPlayer.angularVelocity.magnitude > 3)
      {
        thirdPCam.enabled = true;
        firstPCam.enabled = false;
      }
      else
      {
        firstPCam.enabled = true;
        thirdPCam.enabled = false;
      }
      */
      if(Input.GetKeyDown("f"))
      {
        firstPCam.enabled = true;
        thirdPCam.enabled = false;
      }
      if(Input.GetKeyDown("t"))
      {
        thirdPCam.enabled = true;
        firstPCam.enabled = false;
      }
       //tCam.transform.position = player.transform.position + (tCam.transform.position - player.transform.position).normalized * 10;
       //if(Input.GetKey("k"))
        //    tCam.transform.RotateAround(player.transform.position, Vector3.up, 20 * Time.deltaTime);
       //if(Input.GetKey("l"))
        //    tCam.transform.RotateAround(player.transform.position, Vector3.up, -20 * Time.deltaTime);
      //  tCam.transform.RotateAround (player.transform.position, Vector3.up, 20 * Time.deltaTime);

      if(Input.GetKey("h"))
      {
        fCam.transform.Rotate(20 * Vector3.up * Time.deltaTime);
        player.transform.Rotate(20 * Vector3.up * Time.deltaTime);
      }

  }
}
