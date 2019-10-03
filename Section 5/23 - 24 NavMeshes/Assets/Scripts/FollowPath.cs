using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    public GameObject wpManager;
    GameObject[] wps;
    UnityEngine.AI.NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        wps = wpManager.GetComponent<WPManager>().waypoints;
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void LateUpdate()
    {

    }

    public void GoToHeli()
    {
        agent.SetDestination(wps[0].transform.position);
//        g.AStar(currentNode, wps[0]);
//        currentWP = 0;
    }

    public void GoToRuin()
    {
        agent.SetDestination(wps[3].transform.position);
        //        g.AStar(currentNode, wps[3]);
        //        currentWP = 0;
    }

    public void GoToPot()
    {
        agent.SetDestination(wps[7].transform.position);
        //        g.AStar(currentNode, wps[7]);
        //        currentWP = 0;
    }
}
