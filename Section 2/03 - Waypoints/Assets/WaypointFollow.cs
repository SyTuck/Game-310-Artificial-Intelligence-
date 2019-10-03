using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{

    public GameObject[] waypoints;
    int currentWP = 0;

    float speed = 3.0f;
    float accuracy = 1.0f;
    float rotSpeed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("waypoint");      //create an array of all our "waypoint" markers
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (waypoints.Length == 0) return;

        //get a vector from the tank to the current waypoint (at currentWP index)
        Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);
        Vector3 direction = lookAtGoal - this.transform.position;

        //set the tank to face towards the waypoint (using a slow turn, slerp, method)
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

        if (direction.magnitude < accuracy)                     //if we are close to the current waypoint
        {
            currentWP++;                                        //set to go to the next waypoint
            if (currentWP >= waypoints.Length) currentWP = 0;   //wrap around once we reach the end of the waypoint array
        }
        this.transform.Translate(0, 0, speed * Time.deltaTime); //finally move the tank towards the waypoint
    }


}
