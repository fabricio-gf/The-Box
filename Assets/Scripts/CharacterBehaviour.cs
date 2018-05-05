using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterBehaviour : MonoBehaviour {

    NavMeshAgent agent;

	void Move(Vector3 pos){
		agent.target = pos;
	}
}
