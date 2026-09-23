using TMPro;
using UnityEngine;

public class dialogo : MonoBehaviour
{
    public TextMeshPro que;


    void Star()
    {

    }



    void Updade()
    {

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("Player"))
      {
            que.text = "oi";
      }
    
    
    }


}
