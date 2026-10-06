using UnityEngine;
using UnityEngine.SceneManagement;

public class sair : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) { SceneManager.LoadScene("SDF"); }
    }
}
