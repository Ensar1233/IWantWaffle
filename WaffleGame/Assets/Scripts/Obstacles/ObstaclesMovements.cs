using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMovements : MonoBehaviour
{

    [SerializeField] private Transform[] ray;
    [SerializeField] private int willActFirstIndex = 0;
    [SerializeField] private float speed = 1.5f;
    private void Update()
    {
        LimitSettings();
    }


    private void LimitSettings()
    {
        if(Vector3.Distance(ray[willActFirstIndex].position,transform.position)<=.1f)
        {
            if (willActFirstIndex == 0) willActFirstIndex++;
            else willActFirstIndex--;
        }

        GoToTarget(ray[willActFirstIndex].gameObject);
        

    }
    private void GoToTarget(GameObject ray)
    {
        transform.position = Vector3.MoveTowards(transform.position, ray.transform.position, Time.deltaTime * speed);
    }


    
}
