using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAI : MonoBehaviour
{
    //Reference to waypoints
    public List<Transform> points;
    //The int value for next point index
    public int nextID = 0;
    //The value of that applies to ID for changing 
    int idChangeValue = 1;
    //Speed of movemnt
    public float speed = 2;

    void Init()
    {
        //Create Root object
        GameObject root = new GameObject(name + "_Root");
        //Reset Position of Root to enemy object
        root.transform.position = transform.position;
        //Set enemy object as child of root
        transform.SetParent(root.transform);
        //Create Waypoints object
        GameObject waypoints = new GameObject("Waypoints");
        //Make waypoints object child of root
        waypoints.transform.SetParent(root.transform);
        waypoints.transform.position = root.transform.position;
        //Make the points children of waypoints object
        GameObject p1 = new GameObject("Point 1"); p1.transform.SetParent(waypoints.transform); p1.transform.position = root.transform.position;
        GameObject p2 = new GameObject("Point 2"); p2.transform.SetParent(waypoints.transform); p2.transform.position = root.transform.position;
        GameObject p3 = new GameObject("Point 3"); p3.transform.SetParent(waypoints.transform); p3.transform.position = root.transform.position;
        GameObject p4 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p4.transform.position = root.transform.position;
        //Init points list then add the points to it
        points.Add(p1.transform);
        points.Add(p2.transform);
        points.Add(p3.transform);
        points.Add(p4.transform);
    }

    private void Update()
    {
        MoveToNextPoint();
    }

    private void MoveToNextPoint()
    {
        //Get the next Point transform
        Transform goalPoint = points[nextID];
        //Flip the enemy transform to look intothe point's diection
        if (goalPoint.transform.position.x > transform.position.x)
            transform.localScale = new Vector3(-1, 1, 1);
        else
            transform.localScale = new Vector3(1, 1, 1);
        //Move the enemy towards the goal point
        transform.position = Vector2.MoveTowards(transform.position, goalPoint.position, speed * Time.deltaTime);
        //Check the distance bewteen enemy and goal point to trigger next point
        if(Vector2.Distance(transform.position, goalPoint.position)<1f)
        {
            //Check if we are at the end of the line (make the change -1)
            if (nextID == points.Count - 1)
                idChangeValue = -1;
            //Check if we are at the start of the line (make the change +1)
            if (nextID == 0)
                idChangeValue = 1;
            //Apply the change on the nextID 
            nextID += idChangeValue;
        }
    }
}
