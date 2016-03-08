using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
[RequireComponent(typeof(Light))]
public class Alarm : MonoBehaviour {
  public GameObject ball;
  public AudioSource alarmSound;

  // Use this for initialization
  void Start() {
		alarmSound = this.GetComponent<AudioSource> ();
  }
	void OnTriggerEnter(Collider collider){
		
		if (collider.GetComponent<Collider>().gameObject == ball) {
				alarmSound.Play();

			ball.transform.position = new Vector3 (0, 2, 0);
		}
	}
	void OnTriggerExit(Collider collider){
		if (collider.GetComponent<Collider>().gameObject == ball) {
			alarmSound.Stop ();
		}
	}

}
