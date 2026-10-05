
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguindo : MonoBehaviour
{
    public float speed;
    public float StoppingOitance;
    private Transform Target;
    public bool tocado;


    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    
    void Update()
    {
        if (tocado == true)
        {
            if (Vector2.Distance(transform.position, Target.position) < 20)
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tocado = true;
        }
    }




}
