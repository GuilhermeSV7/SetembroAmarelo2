using UnityEngine;

public class SeguirPlayer : MonoBehaviour
{
    public Transform player;
    public float velocidade = 3f;

    private bool seguindo = false;

    void Update()
    {
        if (seguindo)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                velocidade * Time.deltaTime
            );
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            seguindo = true;
        }
    }
}