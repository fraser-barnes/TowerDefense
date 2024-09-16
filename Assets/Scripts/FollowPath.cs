using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    GameObject[] waypoints;
    int target = 0;
    public float speed = 10f;

    // Start is called before the first frame update
    void Awake()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoints");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[target].transform.position, speed * Time.deltaTime);
        if (transform.position == waypoints[target].transform.position)
        {
            target++;
        }
    }
}
