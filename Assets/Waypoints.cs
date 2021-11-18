using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    static public Transform[] points;

    private void Awake()
    {
        points = new Transform[transform.childCount];

        for(int i =0;i<transform.childCount;++i)
        {
            points[i] = transform.GetChild(i);
        }
    }


}
