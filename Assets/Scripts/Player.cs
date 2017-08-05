using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private FSM fsm;
	// Use this for initialization
	void Start () {
		initalizeAllState ();
	}
	
	// Update is called once per frame
	void Update () {
		fsm.CurrentState.UpdateState ();
	}

	private void initalizeAllState() {
		fsm = new FSM ();
		WanderingState ws = new WanderingState (1);
		fsm.AddState (ws);
		//and so on
	}
}
