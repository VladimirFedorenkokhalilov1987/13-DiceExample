using UnityEngine;
using System.Collections;

public class DicePoints : MonoBehaviour {
	public LayerMask _diceColMask = -1;
	private int _currValue = 1;
	void Update () {
		RaycastHit _hit;
		if (Physics.Raycast (transform.position, Vector3.up, out _hit, Mathf.Infinity, _diceColMask)) {
			_currValue=_hit.collider.GetComponent<DiceValue>()._diceValue;
		}
	}
	void OnGUI()
	{
		GUI.Box (new Rect(300,10,100,25), _currValue.ToString ());
		if (GUI.Button (new Rect (10, 10, 100, 100), "Beck")) {
			Application.LoadLevel(0);
		}
	}

}
