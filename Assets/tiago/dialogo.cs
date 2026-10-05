using TMPro;
using UnityEngine;

public class dialolgo : MonoBehaviour
{
    public TextMeshPro que;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("Pessoa1"))
      {
                que.text = "Sinto que voce esteja mal por conta do aconteceu ultimante";    
      }
      if (collision.CompareTag("Pessoa2"))
      {
                que.text = "Com o tempo voce vai melhorar ";    
      }
      if (collision.CompareTag("Pessoa3"))
      {
                que.text = "Voce pode ter dificuldade no começo";    
      }
      if (collision.CompareTag("Pessoa4"))
      {
                que.text = "Obrigado pela força";    
      }
    }
}
