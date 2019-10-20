using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rngGoal : MonoBehaviour
{
    public Transform minCorner;
    public Transform maxCorner;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(Random.Range(minCorner.position.x, maxCorner.position.x),
                                                                     (minCorner.position.y + minCorner.position.y)/2,
                                                         Random.Range(minCorner.position.z, maxCorner.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
