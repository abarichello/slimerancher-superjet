using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MonomiPark.SlimeRancher.DataModel;
using MonomiPark.SlimeRancher.Regions;
using UnityEngine;

public partial class PlayerState : SRBehaviour, PlayerModel.Participant {
	public void Update() {
		this.SetEnergy(1000);
	}

	public void SpendEnergy(float energy) {
		return;
	}
}
