using UnityEngine;

public class Move : MonoBehaviour {

    public Vector3 goal = new Vector3(5, 0, 4);
    public float speed = 2.0f;

    void Start()
    {
       // goal /= 100.0f;
        
    }

    private void LateUpdate()
    {
        //this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}
