using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rngGoal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(Random.range)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
