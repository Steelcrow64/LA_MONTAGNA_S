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
        GameObject p5 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p5.transform.position = root.transform.position;
        GameObject p6 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p6.transform.position = root.transform.position;
        GameObject p7 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p7.transform.position = root.transform.position;
        GameObject p8 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p8.transform.position = root.transform.position;
        GameObject p9 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p9.transform.position = root.transform.position;
        GameObject p10 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p10.transform.position = root.transform.position;
        GameObject p11 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p11.transform.position = root.transform.position;
        GameObject p12 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p12.transform.position = root.transform.position;
        GameObject p13 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p13.transform.position = root.transform.position;
        GameObject p14 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p14.transform.position = root.transform.position;
        GameObject p15 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p15.transform.position = root.transform.position;
        GameObject p16 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p16.transform.position = root.transform.position;
        GameObject p17 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p17.transform.position = root.transform.position;
        GameObject p18 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p18.transform.position = root.transform.position;
        GameObject p19 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p19.transform.position = root.transform.position;
        GameObject p20 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p20.transform.position = root.transform.position;
        GameObject p21 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p21.transform.position = root.transform.position;
        GameObject p22 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p22.transform.position = root.transform.position;
        GameObject p23 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p23.transform.position = root.transform.position;
        GameObject p24 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p24.transform.position = root.transform.position;
        GameObject p25 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p25.transform.position = root.transform.position;
        GameObject p26 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p26.transform.position = root.transform.position;
        GameObject p27 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p27.transform.position = root.transform.position;
        GameObject p28 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p28.transform.position = root.transform.position;
        GameObject p29 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p29.transform.position = root.transform.position;
        GameObject p30 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p30.transform.position = root.transform.position;
        GameObject p31 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p31.transform.position = root.transform.position;
        GameObject p32 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p32.transform.position = root.transform.position;
        GameObject p33 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p33.transform.position = root.transform.position;
        GameObject p34 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p34.transform.position = root.transform.position;
        GameObject p35 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p35.transform.position = root.transform.position;
        GameObject p36 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p36.transform.position = root.transform.position;
        GameObject p37 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p37.transform.position = root.transform.position;
        GameObject p38 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p38.transform.position = root.transform.position;
        GameObject p39 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p39.transform.position = root.transform.position;
        GameObject p40 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p40.transform.position = root.transform.position;
        GameObject p41 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p41.transform.position = root.transform.position;
        GameObject p42 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p42.transform.position = root.transform.position;
        GameObject p43 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p43.transform.position = root.transform.position;
        GameObject p44 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p44.transform.position = root.transform.position;
        GameObject p45 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p45.transform.position = root.transform.position;
        GameObject p46 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p46.transform.position = root.transform.position;
        GameObject p47 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p47.transform.position = root.transform.position;
        GameObject p48 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p48.transform.position = root.transform.position;
        GameObject p49 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p49.transform.position = root.transform.position;
        GameObject p50 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p50.transform.position = root.transform.position;
        GameObject p51 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p51.transform.position = root.transform.position;
        GameObject p52 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p52.transform.position = root.transform.position;
        GameObject p53 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p53.transform.position = root.transform.position;
        GameObject p54 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p54.transform.position = root.transform.position;
        GameObject p55 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p55.transform.position = root.transform.position;
        GameObject p56 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p56.transform.position = root.transform.position;
        GameObject p57 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p57.transform.position = root.transform.position;
        GameObject p58 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p58.transform.position = root.transform.position;
        GameObject p59 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p59.transform.position = root.transform.position;
        GameObject p60 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p60.transform.position = root.transform.position;
        GameObject p61 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p61.transform.position = root.transform.position;
        GameObject p62 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p62.transform.position = root.transform.position;
        GameObject p63 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p63.transform.position = root.transform.position;
        GameObject p64 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p64.transform.position = root.transform.position;
        GameObject p65 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p65.transform.position = root.transform.position;
        GameObject p66 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p66.transform.position = root.transform.position;
        GameObject p67 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p67.transform.position = root.transform.position;
        GameObject p68 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p68.transform.position = root.transform.position;
        GameObject p69 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p69.transform.position = root.transform.position;
        GameObject p70 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p70.transform.position = root.transform.position;
        GameObject p71 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p71.transform.position = root.transform.position;
        GameObject p72 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p72.transform.position = root.transform.position;
        GameObject p73 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p73.transform.position = root.transform.position;
        GameObject p74 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p74.transform.position = root.transform.position;
        GameObject p75 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p75.transform.position = root.transform.position;
        GameObject p76 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p76.transform.position = root.transform.position;
        GameObject p77 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p77.transform.position = root.transform.position;
        GameObject p78 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p78.transform.position = root.transform.position;
        GameObject p79 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p79.transform.position = root.transform.position;
        GameObject p80 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p80.transform.position = root.transform.position;
        GameObject p81 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p81.transform.position = root.transform.position;
        GameObject p82 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p82.transform.position = root.transform.position;
        GameObject p83 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p83.transform.position = root.transform.position;
        GameObject p84 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p84.transform.position = root.transform.position;
        GameObject p85 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p85.transform.position = root.transform.position;
        GameObject p86 = new GameObject("Point 4"); p4.transform.SetParent(waypoints.transform); p86.transform.position = root.transform.position;
        //Init points list then add the points to it
        points.Add(p1.transform);
        points.Add(p2.transform);
        points.Add(p3.transform);
        points.Add(p4.transform);
        points.Add(p5.transform);
        points.Add(p6.transform);
        points.Add(p7.transform);
        points.Add(p8.transform);
        points.Add(p9.transform);
        points.Add(p10.transform);
        points.Add(p11.transform);
        points.Add(p12.transform);
        points.Add(p13.transform);
        points.Add(p14.transform);
        points.Add(p15.transform);
        points.Add(p16.transform);
        points.Add(p17.transform);
        points.Add(p18.transform);
        points.Add(p19.transform);
        points.Add(p20.transform);
        points.Add(p21.transform);
        points.Add(p22.transform);
        points.Add(p23.transform);
        points.Add(p24.transform);
        points.Add(p25.transform);
        points.Add(p26.transform);
        points.Add(p27.transform);
        points.Add(p28.transform);
        points.Add(p29.transform);
        points.Add(p30.transform);
        points.Add(p31.transform);
        points.Add(p32.transform);
        points.Add(p33.transform);
        points.Add(p34.transform);
        points.Add(p35.transform);
        points.Add(p36.transform);
        points.Add(p37.transform);
        points.Add(p38.transform);
        points.Add(p39.transform);
        points.Add(p40.transform);
        points.Add(p41.transform);
        points.Add(p42.transform);
        points.Add(p43.transform);
        points.Add(p44.transform);
        points.Add(p45.transform);
        points.Add(p46.transform);
        points.Add(p47.transform);
        points.Add(p48.transform);
        points.Add(p49.transform);
        points.Add(p50.transform);
        points.Add(p51.transform);
        points.Add(p52.transform);
        points.Add(p53.transform);
        points.Add(p54.transform);
        points.Add(p55.transform);
        points.Add(p56.transform);
        points.Add(p57.transform);
        points.Add(p58.transform);
        points.Add(p59.transform);
        points.Add(p60.transform);
        points.Add(p61.transform);
        points.Add(p62.transform);
        points.Add(p63.transform);
        points.Add(p64.transform);
        points.Add(p65.transform);
        points.Add(p66.transform);
        points.Add(p67.transform);
        points.Add(p68.transform);
        points.Add(p69.transform);
        points.Add(p70.transform);
        points.Add(p71.transform);
        points.Add(p72.transform);
        points.Add(p73.transform);
        points.Add(p74.transform);
        points.Add(p75.transform);
        points.Add(p76.transform);
        points.Add(p77.transform);
        points.Add(p78.transform);
        points.Add(p79.transform);
        points.Add(p80.transform);
        points.Add(p81.transform);
        points.Add(p82.transform);
        points.Add(p83.transform);
        points.Add(p84.transform);
        points.Add(p85.transform);
        points.Add(p86.transform);
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
