using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {
	public string gameName = "My Game";
	public string gameScene = "Game";
	
	void OnGUI() {
		GUI.Box(new Rect(10,10,100,90), gameName);
		if(GUI.Button(new Rect(20,40,80,20), "Start game")) {
			if(Application.CanStreamedLevelBeLoaded(gameScene)) {
				Application.LoadLevel(gameScene);
			} else {
				print("Scene " + gameScene + " does not exist!");	
			}
		}
	}
}
