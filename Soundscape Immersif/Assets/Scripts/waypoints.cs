using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoints : MonoBehaviour {
    
    [SerializeField]
    GameObject[] WaypointArray;
    [SerializeField]
    Vector3 ChosenWaypoint;
    bool WaitCheck;
    public float speed = 0.3f;
    int seconds;
    public int waitTime;
    int RdmValue;

    IEnumerator WaitTime(int seconds)
    {
        
        yield return new WaitForSeconds(seconds);
        RandomWayPoint();
        yield return new WaitForSeconds(5);
        WaitCheck = false;
        
    }

    // Use this for initialization
    void Start () {
        RdmValue = -1;

        RandomWayPoint();

    }
	
	// Update is called once per frame
	void Update () {

        //viewfinder_pos = viewfinder.transform.position;
        float step = speed * Time.deltaTime;
        
        if(Vector3.Distance(transform.position, ChosenWaypoint) < 0.001f && WaitCheck == false)
        {
            
           StartCoroutine(WaitTime(waitTime));
           
            WaitCheck = true;

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, ChosenWaypoint, step);
            
            
        }

      
    }

    void RandomWayPoint()
    {
        int oldRdm = RdmValue;
        RdmValue = Random.Range(0, WaypointArray.Length);
        if (RdmValue == oldRdm)
        {
            RdmValue = Random.Range(0, WaypointArray.Length);
        }
        else
        {
            ChosenWaypoint = new Vector3(WaypointArray[RdmValue].transform.position.x, WaypointArray[RdmValue].transform.position.y, transform.position.z);
        }
        }
}
