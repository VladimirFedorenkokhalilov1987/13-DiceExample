using UnityEngine;
using System.Collections;

public class MainMenuDice3d : MonoBehaviour {


	void OnGUI()
	{
		if (GUI.Button (new Rect (100, 100, 100, 100), "Start")) {
			Application.LoadLevel(1);
		}
		if (GUI.Button (new Rect (300, 100, 100, 100), "Exit")) {
			Application.Quit();
		}
	}
}
