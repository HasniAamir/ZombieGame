using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class audioSource : MonoBehaviour {

	void Start() {
		audio.Play();
	}
}
