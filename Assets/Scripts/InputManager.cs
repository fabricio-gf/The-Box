using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InputManager : MonoBehaviour {

    public GameObject player;
    NavMeshAgent agent;

    private void Awake()
    {
        agent = player.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            print("click");
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000))
            {
                print(hit.transform.name);
                if(hit.transform.tag == "Ground")
                {
                    print("HIT");
                    Move(hit.point);
                }
            }
        }
    }

    void Move(Vector3 pos)
    {
        print(pos);
        agent.destination = pos;
    }
}
