using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class title_start : MonoBehaviour 
{
	public bool hover = false;

	void OnMouseOver()
	{
		hover = true;
	}

	void OnMouseExit()
	{
		hover = false;
	}

	void Update()
	{
		if(hover == true && Input.GetKeyDown(KeyCode.Mouse0))
		{
			SceneManager.LoadScene("Desert_01");
		}
	}
}