using UnityEngine;
using UnityEngine.UIElements;
public class camera : MonoBehaviour
{
    private Transform target;
    private Vector3 velocity = Vector3.zero;
    private float smothTime = 0.1f;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        Vector3 cameraPosition = target.position + new Vector3(0, 0, -1);
        transform.position = Vector3.SmoothDamp(transform.position, cameraPosition, ref velocity, smothTime);
    
    }

  

}
