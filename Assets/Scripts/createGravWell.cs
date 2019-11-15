using UnityEngine;

public class createGravWell : MonoBehaviour
{

    public GameObject GravityWellObject;
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("q"))
        {
            Instantiate(GravityWellObject, player.position, Quaternion.identity);
        }
    }
}
