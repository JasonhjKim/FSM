using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateMachine<T>: MonoBehaviour {
	private IState<T> currentState;
	private IState<T> previousState;
	public T Owner;

	public StateMachine(T _owner) {
		Owner = _owner;
	}
	public void ChangeState(IState<T> newState) {
		if (currentState != null) 
			currentState.ExitState (Owner);
		previousState = currentState;
		currentState = newState;
		currentState.EnterState (Owner);
	}

	public void UpdateStateMachine() {
		if (currentState != null)
			currentState.UpdateState (Owner);
	}

	public void ChangeToPreviousState() {
		if (currentState != null) {
			IState<T> temp = currentState;
			currentState.ExitState (Owner);
			currentState = previousState;
			previousState = temp;
			currentState.EnterState (Owner);
		}
	}
}
