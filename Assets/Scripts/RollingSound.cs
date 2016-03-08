using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class RollingSound : MonoBehaviour {
  Rigidbody _rigidbody;
  public AudioSource rollingAudio;
  int _collisionCount = 0;

	// Use this for initialization
	void Start () {
    	_rigidbody = GetComponent<Rigidbody>();
		rollingAudio = this.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
    if(_collisionCount > 0) {
			if(rollingAudio.isPlaying == false) {
				rollingAudio.Play();
      }

      float volume = Mathf.Clamp(_rigidbody.velocity.magnitude, 0.0f, 1.0f);
      // set volume.

			rollingAudio.volume = volume;
    }
    else {
			if(rollingAudio.isPlaying) {
				rollingAudio.Stop();
      }
    }
  }

  public void OnCollisionEnter() {
    _collisionCount++;
  }

  public void OnCollisionExit() {
    _collisionCount--;
  }

}
