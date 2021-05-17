using UnityEngine;
using System.Collections;

public class actMenu : MonoBehaviour {

	public GameObject main;
	public GUISkin giSkin;
	public float areaHeight;
	public float areaWidth;
	public float spacing;
	public int score=0;

	void Start()
	{
		//main=GameObject.Find("GUI");
		//main.gameObject.SetActive(false);
	}
	void OnGUI()
	{	
		GUI.skin=giSkin;
		float scrY=((Screen.height*0.5f)-(areaHeight*0.5f));
		float scrX=((Screen.width*0.5f)-(areaWidth*0.5f));
		GUILayout.BeginArea(new Rect(scrX,scrY,areaWidth,areaHeight));
		if(score>10)
		{

			if(GUILayout.Button("Graveyard"))
			{
				
			}
		}
		GUILayout.Space(spacing);
		if(score>20)
		{
			if(GUILayout.Button("Cityscape"))
			{
				
			}
		}
		GUILayout.Space(spacing);
		if(GUILayout.Button("Back"))
		{
			this.gameObject.SetActive(false);
			main.gameObject.SetActive(true);
		}
		GUILayout.EndArea();
	}
}
