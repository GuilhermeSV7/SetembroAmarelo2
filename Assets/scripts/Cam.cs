using UnityEngine;

public class Cam : MonoBehaviour
{
    private Transform target;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        if (transform.position != target.position) 
        { 
            Vector3 targetPositon = new Vector2(target.position.x, target.position.y);

            transform .position = Vector3.Lerp(transform.position, targetPositon, 1.0f);
        }
    }
}
