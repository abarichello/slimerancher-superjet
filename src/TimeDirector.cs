using System;
using System.Collections;
using System.Diagnostics;
using MonomiPark.SlimeRancher.DataModel;
using UnityEngine;

public class TimeDirector : SRBehaviour, WorldModel.Participant {
	public void Update() {
		if (Input.GetKey(KeyCode.KeypadMinus)) {
			this.worldModel.worldTime -= (double)(Time.deltaTime * this.timeFactor * 100f);
		}
		if (Input.GetKey(KeyCode.KeypadPlus)) {
			this.worldModel.worldTime += (double)(Time.deltaTime * this.timeFactor * 100f);
		}
	}
}
