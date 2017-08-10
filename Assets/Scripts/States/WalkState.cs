using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState: IState<Player>{
	public void EnterState(Player _owner) {

	}
	public void ExitState(Player _owner) {

	}
	public void UpdateState(Player _owner) {
		Debug.Log ("Walking");
	}
}
