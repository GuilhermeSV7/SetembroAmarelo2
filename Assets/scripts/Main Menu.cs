using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

	public GameObject BGOp;
	public GameObject BGCr;

    public void StartGame()
	{
		SceneManager.LoadScene("GameScene");
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void OpenOptions()
	{
		BGOp.SetActive(true);
	}
	public void CloseOptions()
	{
		BGOp.SetActive(false);
	}

	public void OpenCreditos()
	{
		BGCr.SetActive(true);
	}
	public void CloseCreditos()
	{
		BGCr.SetActive(false);
	}
}
