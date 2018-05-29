using System.Collections;
using UnityEngine;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// ブロックとの衝突音
	private AudioSource audioSource;

	void Start () {
	}
	
	void Update () {

		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D ( Collision2D other ) {

		if (other.gameObject.name == "ground" || other.gameObject.tag == "Cube") {

			Debug.Log ("接触");
			audioSource = GetComponent<AudioSource> ();
			audioSource.Play ();

		}
	}
}
