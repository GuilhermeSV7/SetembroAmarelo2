using UnityEngine;

public class Playermove : MonoBehaviour
{
    public coinmanager cm;
    public float speed = 5f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * move * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            cm.coinCount++;
        }

    }
}