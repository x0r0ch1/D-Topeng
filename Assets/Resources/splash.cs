using UnityEngine;
using System.Collections;

public class splash : MonoBehaviour
{

	void Start()
	{
		StartCoroutine(Example());
	}

	IEnumerator Example()
	{
		yield return new WaitForSeconds(2);
		Application.LoadLevel("loading");
	}
}
