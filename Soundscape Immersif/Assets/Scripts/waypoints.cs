using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoints : MonoBehaviour {
    public GameObject viewfinder;
    public GameObject waypoint1;
    public GameObject waypoint2;
    private Vector2 viewfinder_pos;
    private Vector2 waypoint1_pos;
    private Vector2 waypoint2_pos;
    public float speed = 0.3f;
    int seconds;

    IEnumerator WaitTime(int seconds)
    {   
        yield return new WaitForSeconds(seconds);
        Debug.Log("Enter Wait Time");
    }

    // Use this for initialization
    void Start () {
        waypoint1_pos = new Vector2(waypoint1.x, waypoint1.y);
        waypoint2_pos = new Vector2(waypoint2.x, waypoint2.y);


    }
	
	// Update is called once per frame
	void Update () {

        viewfinder_pos = viewfinder.transform.position;
        float step = speed * Time.deltaTime;

        if (viewfinder_pos != waypoint1_pos && viewfinder_pos != waypoint1_pos)
            {
            viewfinder_pos = Vector2.MoveTowards(viewfinder_pos, waypoint1_pos, step);
            Debug.Log("Premier if");
            }

        else if (viewfinder_pos == waypoint1_pos && viewfinder_pos == waypoint1_pos)
        {
            WaitTime(3);
            viewfinder_pos = Vector2.MoveTowards(viewfinder_pos, waypoint2_pos, step);
            Debug.Log("Success ?");
        }
    }
}
