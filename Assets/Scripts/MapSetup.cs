using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSetup : MonoBehaviour
{
    float pathWidth = 7.5f;
    GameObject[] waypoints;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoints");
        GameObject pathCollider = new GameObject("Path", typeof(BoxCollider));
        pathCollider.transform.position = new Vector3(Mathf.Abs(waypoints[1].transform.position.x) - Mathf.Abs(waypoints[0].transform.position.x), 0, Mathf.Abs(waypoints[1].transform.position.z) - Mathf.Abs(waypoints[0].transform.position.z));
        pathCollider.transform.LookAt(waypoints[0].transform.position);
        pathCollider.transform.Rotate(0f, 90f, 0f);
        pathCollider.GetComponent<BoxCollider>().size = new Vector3(waypoints[1].transform.position.x - waypoints[0].transform.position.x,0,pathWidth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
