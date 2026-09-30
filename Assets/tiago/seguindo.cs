
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguindo : MonoBehaviour
{
    public float speed;
    public float StoppingOitance;
    private Transform Target;


    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    
    void Update()
    {
        if (Vector2.Distance(transform.position, Target.position) < 15)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
        }

    }





}
