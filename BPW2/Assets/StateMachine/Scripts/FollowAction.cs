using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Follow")]
public class FollowAction : ActionScript {
	public override void Act(StateManager stateManager)
	{
		followPlayer(stateManager);
	}

	private void followPlayer(StateManager stateManager)
	{
		stateManager.navMeshAgent.SetDestination(stateManager.player.transform.position);
	}
}
