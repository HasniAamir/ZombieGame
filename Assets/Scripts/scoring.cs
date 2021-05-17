using UnityEngine;
using System.Collections;

public class scoring : MonoBehaviour {

	//Define the ditch's score value
	public int ditchVal=2;

	//Define the enemy kill points
	public int enemyLightHP=2;
	public int enemyHeavyHP=4;

	/*gui is the object to which the mainLoop script is attached, mainLoop
	 * script controls the ingame GUI(displays timer and scores etc.)
	 */
	public GameObject gui;

	//addScoreTo contains the reference to mainLoop's score variable
	private mainLoop addScoreTo;

	void Start()
	{
		addScoreTo=gui.gameObject.GetComponent<mainLoop>();
		enemyLightHP+=ditchVal;
		enemyHeavyHP+=ditchVal;
	}

	void OnTriggerEnter(Collider enemy)
	{
		if(enemy.gameObject.tag=="enemyLight")
		{
			addScoreTo.score+=enemyLightHP;
		}

		if(enemy.gameObject.tag=="enemyHeavy")
		{
			addScoreTo.score+=enemyHeavyHP;
		}
	}
}
