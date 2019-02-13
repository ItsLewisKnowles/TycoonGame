using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
	public void Quit()
	{
		//platform specific execution (#if UNITY_EDITOR does not compile)
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
	Application.Quit();
		#endif
	}
}
