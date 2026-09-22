using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
	//public GameObject menu;

	//public void desativaMenu()
	//{
	//	menu.SetActive(!menu.activeSelf);
	//}


	//private void Update()
	//{
	//	if (Input.GetKeyUp(KeyCode.Escape))
	//	{
	//		desativaMenu();
	//	}
	//}

	public GameObject menu;
	public GameObject BGSair;
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


	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			desativaMenu();
		}
	}

	public void BGSairTwo() 
	{ 
		BGSair.SetActive(true);
	}
	public void BGSairSair()
	{
		BGSair.SetActive(false);
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
}
