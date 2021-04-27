using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{

	public void GoToMainMenu()
	{
		Application.LoadLevel("main_menu");
	}

	public void GoToDesc()
    {
		Application.LoadLevel("desc");
    }

	public void GoToTopengMalang()
    {
		Application.LoadLevel("Topeng_malang");
	}

	public void GoToTopengCirebon()
    {
		Application.LoadLevel("Topeng_cirebon");
	}

	public void GoToTopengPanji()
    {
		Application.LoadLevel("Topeng_panji");
	}

	public void GoToARMalang()
	{
		Application.LoadLevel("AR_Malang");
	}

	public void GoToARCirebon()
	{
		Application.LoadLevel("AR_Cirebon");
	}

	public void GoToARPanji()
	{
		Application.LoadLevel("AR_Panji");
	}

	public void GoToAbout()
	{
		Application.LoadLevel("about");
	}

	public void ExitApplication()
	{
		Application.Quit();
	}
}
