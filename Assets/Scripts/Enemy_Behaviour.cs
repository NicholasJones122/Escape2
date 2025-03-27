using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Behaviour : MonoBehaviour
{
    public Game_Manager manager;
    public NavMeshAgent agent;
    public Vector3 TargetLocation;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnEnable()
    {
        manager = FindObjectOfType<Game_Manager>();
        manager.PauseGame.AddListener(StopMoving);
    }
    private void OnDisable()
    {
        manager.PauseGame.RemoveListener(StopMoving);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void StopMoving()
    {
        Debug.Log("Game is paused please stop moving");
    }

    public void Chase_Movement()
    {
        GameObject player = GameObject.Find("player_Object");
        TargetLocation = player.transform.position;
        agent.SetDestination(TargetLocation);
    }
    public void Basic_Movement()
    {

    }
}
