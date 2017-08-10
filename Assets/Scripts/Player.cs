using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private StateMachine<Player> sm;
	private Dictionary<States, IState<Player>> dic;
	// Use this for initialization
	void Start () {
		sm = new StateMachine<Player> (this);
		initalizeAllState ();
		sm.ChangeState (dic [States.WALK]);
	}
	
	// Update is called once per frame
	void Update () {
		sm.UpdateStateMachine ();
	}

	private void initalizeAllState() {
		dic = new Dictionary<States, IState<Player>> ();
		dic.Add (States.RUN, new RunState ());
		dic.Add (States.WALK, new WalkState());
		dic.Add (States.JUMP, new JumpState());
		dic.Add (States.ATTACK, new AttackState());
	}
}

public enum States {
	RUN,
	WALK,
	JUMP,
	ATTACK
}
