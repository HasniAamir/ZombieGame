using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	public GUISkin menuSkin;
	public float areaWidth;
	public float areaHeight;
	public int spacing;
	public AudioClip beep;
	public float secondsDelay=0.35f;
	public string playLevel;
	public string optionsLevel;
	public Texture tex;
	public GameObject actGUI;

	void Start()
	{
		actGUI.gameObject.SetActive(false);
	}

	void OnGUI()
	{
		GUI.skin=menuSkin;
		float screenX=((Screen.width*0.5f)-(areaWidth*0.5f));
		float screenY=((Screen.height*0.5f)-(areaHeight*0.5f));

		GUILayout.BeginArea(new Rect(screenX,screenY,areaWidth,areaHeight));
		if(GUILayout.Button("new game"))
		{
			this.gameObject.SetActive(false);
			actGUI.gameObject.SetActive(true);
			audio.PlayOneShot(beep);
			//Application.LoadLevel(playLevel);
		}
		GUILayout.Space(spacing);
		if(GUILayout.Button("options"))
		{
			audio.PlayOneShot(beep);
			Application.LoadLevel(optionsLevel);
		}
		GUILayout.Space(spacing);
		if(GUILayout.Button("exit"))
		{
			audio.PlayOneShot(beep);
			//delay(secondsDelay);
			//Application.Quit();
		}
		GUILayout.EndArea();
	}

	IEnumerator delay(float seconds)
	{
		yield return new WaitForSeconds(seconds);
	}
}
