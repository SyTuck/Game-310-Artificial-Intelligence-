using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocal : MonoBehaviour {

	public Transform goal;
	public float speed = 1f;
	float accuracy = 1.0f;
	public float rotSpeed = 0.4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 lookAtGoal = new Vector3(goal.position.x,                               //find a director between us and the goal
										this.transform.position.y, 
										goal.position.z);
		Vector3 direction = lookAtGoal - this.transform.position;

		this.transform.rotation = Quaternion.Slerp(this.transform.rotation,             //do a slow rotation between our current direction
												Quaternion.LookRotation(direction),     //and where the goal is
												Time.deltaTime*rotSpeed);               //(* deltaTime is used to make the rotation smooth increments)

//		if(Vector3.Distance(transform.position,lookAtGoal) > accuracy)                  //if we are close enough to the goal, then don't move the character
//			this.transform.Translate(0,0,speed*Time.deltaTime);                         //(disabled to let the character animation control the movement/translate
	}
}
