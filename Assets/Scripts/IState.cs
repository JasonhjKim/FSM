using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IState<T> {
//	Enum Name{ get; set; }
	void EnterState (T _owner);
	void ExitState (T _owner);
	void UpdateState (T _owner);
}
