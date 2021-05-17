using UnityEngine;
using System.Collections;

public class mainLoop : MonoBehaviour {

	public int score=0;
	public GUISkin uiSkin;
	public float areaWidth;
	public float areaHeight;
	public bool paused=false;

	void OnGUI()
	{
		GUI.skin=uiSkin;
		float scrX=((Screen.width*0.5f)-(areaWidth*0.5f));
		float scrY=((Screen.height*0.5f)-(areaHeight*0.5f));

//		GUILayout.BeginArea(new Rect(scrX,scrY,areaWidth,areaHeight));
//		GUILayout.Label(""+score);
//		GUILayout.EndArea();
		GUI.Label(new Rect(100,60,areaWidth,areaHeight),""+score);
		if(GUI.Button(new Rect(500,60,200,200),"II"))
		{
			Application.LoadLevel("mainMenu");
		}
	}
}
