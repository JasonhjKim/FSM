using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM {
	private List<State> states;
	private State currentState;
	public State CurrentState{ get {return currentState; } }

	public FSM() {
		states = new List<State> ();
	}

	public void AddState(State newState) {
		if (newState == null) {
			Debug.Log ("The fuck?");
		}
		states.Add (newState);
	}

	public void DeleteState(State deleteState) {
		foreach (State state in states) {
			if (deleteState == state) {
				states.Remove (state);
			}
		}
	}


}
