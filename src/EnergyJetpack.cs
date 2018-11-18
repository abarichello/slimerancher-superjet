using System;
using MonomiPark.SlimeRancher.DataModel;
using MonomiPark.SlimeRancher.Regions;
using UnityEngine;

public class EnergyJetpack : SRBehaviour, EventHandlerRegistrable, PlayerModel.Participant {
	private void OnStart_Jetpack() {
		this.hoverY = float.PositiveInfinity;
		//this.playerState.SpendEnergy(this.initEnergyUsed * this.model.jetpackEfficiency);
	}

	[Tooltip("Energy used per second of jetpacking.")]
	public float energyPerSecond = 0.0f;

	[Tooltip("This much energy is used on initiation of the jetpack.")]
	public float initEnergyUsed = 0.0f;
}
