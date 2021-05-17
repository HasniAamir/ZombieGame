using UnityEngine;
using System.Collections;

public class npcAi : MonoBehaviour {
	public enum enemyState
	{
		idle,follow,attack,
	}
	public GameObject target;
	public float movementSpeed=10f;
	public float rotationSpeed=5f;
	public float attackRadius=10f;
	public enemyState currentState=enemyState.follow;

	void Start () {
		currentState=enemyState.follow;
	}

	void Update () {
		switch(currentState)
		{
		case enemyState.follow:
				gameObject.animation.CrossFade("walk");
				transform.rotation=Quaternion.Slerp(transform.rotation,
				Quaternion.LookRotation(target.transform.position-this.transform.position),rotationSpeed*Time.deltaTime);
				transform.position+=transform.forward*movementSpeed*Time.deltaTime;
			if((target.transform.position-this.transform.position).sqrMagnitude<=attackRadius)
				currentState=enemyState.attack;
			break;
		case enemyState.attack:
				transform.rotation=Quaternion.Slerp(transform.rotation,
			    Quaternion.LookRotation(target.transform.position-this.transform.position),rotationSpeed*Time.deltaTime);
				gameObject.animation.CrossFade("attack");
			if((target.transform.position-this.transform.position).sqrMagnitude>=attackRadius)
				currentState=enemyState.follow;
			break;
		}
	}
}
