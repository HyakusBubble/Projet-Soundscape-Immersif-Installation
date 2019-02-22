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
    int seconds;
    public int _seconds;
    float speed;

    IEnumerator WaitTime(int seconds)
    {   
        yield return new WaitForSeconds(seconds);
        Debug.Log("Enter Wait Time");
    }

    // Use this for initialization
    void Start () {
        waypoint1_pos = waypoint1.transform.position;
        waypoint2_pos = waypoint1.transform.position;
        speed = Time.deltaTime / 4;

    }
	
	// Update is called once per frame
	void Update () {

        viewfinder_pos = viewfinder.transform.position;

        if (viewfinder_pos.x != waypoint1_pos.x && viewfinder_pos.y != waypoint1_pos.y)
            {
            viewfinder.transform.Translate(waypoint1_pos.x, waypoint1_pos.y, 0 * speed);
            Debug.Log("Premier if");
            }

        else if (viewfinder_pos.x == waypoint1_pos.x && viewfinder_pos.y == waypoint1_pos.y)
        {
            //WaitTime(_seconds);
            viewfinder.transform.Translate(waypoint2_pos.x, waypoint2_pos.y, 0 * speed);
            Debug.Log("Success ?");
        }
    }
}
