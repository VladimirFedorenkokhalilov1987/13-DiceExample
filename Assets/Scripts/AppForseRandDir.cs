using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AppForseRandDir : MonoBehaviour {
	public string _buttonName = "Fire1";
	public float _force = 10f;
	public float _torque = 10f;
	public ForceMode _forceMode;
	[SerializeField]
	GameObject _go;
	[SerializeField]
	Text _text;
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			_go.GetComponent<Rigidbody> ().AddForce (Random.onUnitSphere * _force, _forceMode);
			_go.GetComponent<Rigidbody> ().AddForce (Random.onUnitSphere * _torque, _forceMode);
			_text.gameObject.SetActive (false);
		}
	}
}
