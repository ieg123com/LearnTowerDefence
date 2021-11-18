using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    private void Start()
    {
        target = Waypoints.points[0];
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime,Space.World);

        if(Vector3.Distance(transform.position,target.position) <=0.2f)
        {
            GetNextWaypoint();
        }
        

    }

    private void GetNextWaypoint()
    {
        ++wavepointIndex;
        if (wavepointIndex >= Waypoints.points.Length)
        {
            Destroy(gameObject);
        }
        else
        {
            target = Waypoints.points[wavepointIndex];
        }
    }
}
