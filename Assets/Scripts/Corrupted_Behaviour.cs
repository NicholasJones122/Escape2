using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Corrupted_Behaviour : Enemy_Behaviour
{
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //Chase_Movement();
    }

    // Update is called once per frame
    void Update()
    {
        //if corrupted can see the player:
        Chase_Movement();

        //if cannot see the player:
        //Roam_Movement();
    }

    void Roam_Movement()
    {
        //find random point it can reach, move to it, save the location and keep moving to it.
        //if sees player will stop moving to that point.
    }
}
