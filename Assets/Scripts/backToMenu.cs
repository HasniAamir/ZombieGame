using UnityEngine;
using System.Collections;

public class backToMenu : MonoBehaviour {

	public string toMenu;
	public GUISkin guiSkin;
	public float areaWidth;
	public float areaHeight;
	public int spaceFromTop;

	void OnGUI()
	{
		GUI.skin=guiSkin;
		float screenX=((Screen.width*0.5f)-(areaWidth*0.5f));
		float screenY=((Screen.height*0.5f)-(areaHeight*0.5f));
		GUILayout.BeginArea(new Rect(screenX,screenY,areaWidth,areaHeight));
		GUILayout.Space(spaceFromTop);
		if(GUILayout.Button("main menu"))
			Application.LoadLevel(toMenu);
		GUILayout.EndArea();
	}
}
