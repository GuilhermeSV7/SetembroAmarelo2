using UnityEngine;
using System.Collections;

public class dialogo : MonoBehaviour
{
    public GameObject player;
    public GameObject dialogo1;
    public GameObject dialogo2;

    [SerializeField] private bool iniciou = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !iniciou)
        {
            iniciou = true;
            StartCoroutine(cutscene());
        }
    }

    IEnumerator cutscene()
    {
        // Espera 1 segundo
        yield return new WaitForSeconds(0.5f);

        // Ativa o diálogo 1
        dialogo1.SetActive(true);

        // Espera 3 segundos
        yield return new WaitForSeconds(3f);

        // Desativa o diálogo 1
        dialogo1.SetActive(false);

        // Espera 1 segundo
        yield return new WaitForSeconds(0.5f);

        // Ativa o diálogo 2
        dialogo2.SetActive(true);

        // Espera 6 segundos
        yield return new WaitForSeconds(6f);

        // Desativa o diálogo 2
        dialogo2.SetActive(false);
    }
}
