using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    private NavMeshAgent thisNavAgent;

    // Start is called before the first frame update
    void Start()
    {
        thisNavAgent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        thisNavAgent.destination = player.transform.position;
    }
}
