using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
    // This is a class that allows me to change between the different 
    // scenes when clicked on from a button
	public void LoadScene (int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}
}
