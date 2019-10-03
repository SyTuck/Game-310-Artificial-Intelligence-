using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    GameObject followObject;

    public float petSpeed = 2.0f;              
    public float petRotSpeed = 1.0f;
    public float petStopDistance = 1.0f;


    private float petHoverHeight = 1.0f;                            //distance to keep the pet off the ground
    private float terrainHeight;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        followObject = GameObject.FindGameObjectWithTag("Player");  //find the player object
    }

    // Update is called once per frame
    void LateUpdate()               
    {

        //find the vector between the player and the pet ('this'). All axis are used as we use the terrain height below to keep the pet from rising into the air
        Vector3 PlayerPosition = new Vector3(followObject.transform.position.x, followObject.transform.position.y, followObject.transform.position.z);
        Vector3 VectToPlayer = PlayerPosition - this.transform.position;

        //find the distance between the pet and it's current spot over the terrain. Then set the pet position to 2units above the terrain
        float terrainHeight = Terrain.activeTerrain.SampleHeight(this.transform.position);
        this.transform.position = new Vector3(this.transform.position.x, terrainHeight + 2.0f, this.transform.position.z);

        //now do a slerp (partial rotation) between the pet's current facing direction and where the player is. (using the deltaTime to make it a slow even turn)
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(VectToPlayer), Time.deltaTime * petRotSpeed);

        if (VectToPlayer.magnitude > petStopDistance)                       //and here we check to see if we're "close enough"
        {                                                                   //to the player to stop moving
            this.transform.Translate(0, 0, petSpeed * Time.deltaTime);
        }

    }


}
