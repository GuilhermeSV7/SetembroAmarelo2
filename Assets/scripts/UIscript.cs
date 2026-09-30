using UnityEngine;
using UnityEngine.SceneManagement;

public class UIscript : MonoBehaviour
{
    public void fase1() 
    { 
        SceneManager.LoadScene("fase1");
    }
    public void fase2()
	{
		SceneManager.LoadScene("fase2");
	}
    public void fase3()
	{
		SceneManager.LoadScene("fase3");
	}
}
