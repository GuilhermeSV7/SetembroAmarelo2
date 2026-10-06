using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
	public GameObject menu;
	public GameObject BGOp;
	public bool IsMenu;
	public int IsMenuI = -1;


    public void desativaMenu()
	{
		menu.SetActive(!menu.activeSelf);
		IsMenuI *= -1;
		if (IsMenuI == 1) { IsMenu = true; } else { IsMenu = false; }
	}

	public void PlayMenu()
	{
		SceneManager.LoadScene("Game");
	}

	public void SDF () { SceneManager.LoadScene("SDF"); }

	
	private void Update() {
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			desativaMenu();			
		}

	}


    public void BGOpEntrar()
	{
		BGOp.SetActive(true);
	}
	public void BGOpSair()
	{
		BGOp.SetActive(false);
	}

	public void Voltar()
	{
		menu.SetActive(false);
		IsMenuI *= -1;
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void FullScreen(bool isFullscreen)
	{ Screen.fullScreen = isFullscreen; }

	//public void Fase1()
	//{
	//	SceneManager.LoadScene("Fase1");
	//}
	//public void Fase2()
	//{
	//	SceneManager.LoadScene("Fase2");
	//}
	//public void Fase3()
	//{
	//	SceneManager.LoadScene("Fase3");
	//}
}
