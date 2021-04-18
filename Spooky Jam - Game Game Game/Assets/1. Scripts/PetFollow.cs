using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetFollow : MonoBehaviour
{
    public float speed;
    public float GimmeSpace;
    public GameObject Fuzzball;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject instance = Fuzzball;
        Vector3 d3 = instance.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) > GimmeSpace)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
