using UnityEngine;

public class scr_espelhochase : MonoBehaviour
{
    float speed = 2;
    [SerializeField] Transform Target;

    private void Update()
    {
        if (Target.position.y > 0 && Target.position.x > -12.5f && Target.position.x < 12.5) {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
        } }
}
