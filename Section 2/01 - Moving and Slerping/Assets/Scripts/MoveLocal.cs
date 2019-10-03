using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocal : MonoBehaviour
{

    public Transform goal;
    float speed = 0.5f;
    float accuracy = 1.0f;
    float rotSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //find the vector between us and the goal, but only an x-z vector, (we don't want to move in the y direction)
        Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        Vector3 direction = lookAtGoal - this.transform.position;

        //this.transform.LookAt(lookAtGoal);        //this is a fast/instant turning towards the goal
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
        //the slerp preforms a slow, smooth turn (based on detltaTime time slices) 

        if (Vector3.Distance(transform.position, lookAtGoal) > accuracy)    //now if we are "far away" from the goal, keep moving towards it
        {                                                       
            this.transform.Translate(0, 0, speed * Time.deltaTime);         //deltaTime is used to smooth, not affected by cpu load, steps forward
        }
        
    }
}
