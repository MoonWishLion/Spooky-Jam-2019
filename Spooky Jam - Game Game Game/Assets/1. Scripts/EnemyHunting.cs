using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHunting : MonoBehaviour
{
    public float speed;
    public float CHASE_DISTANCE;
    public GameObject BAT;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject instance = BAT;
        Vector3 d3 = instance.transform.position - transform.position;

        if (Vector2.Distance(transform.position, target.position) > CHASE_DISTANCE)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        //Set-Up
        //void Position (float value)
        //{
        //    cursorPosition.x = value;
        //    GameObject instance = this;

        //    Vector3 d3 = instance.transform.position - transform.position;
        //    if (dV.magnitude < CHASE_DISTANCE)
        //    {
        //        transform.position += dV.normalized * speeed * Time.deltaTime;
        //    }
        //}
    }
}
