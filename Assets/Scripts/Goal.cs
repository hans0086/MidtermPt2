using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour {
  public GameObject ball;
  public AudioSource goalSound;
  bool _played = false;

	void Start(){
		goalSound = this.gameObject.GetComponent<AudioSource> ();
	}
	public void OnCollisionEnter(Collision collision){
		
		if (collision.collider.gameObject == ball) {
			goalSound.Play ();
			_played = true;
			Application.LoadLevel (0);

		}

	}

}
