using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class StatueBehaviour : Enemy_Behaviour
{
    // Update is called once per frame
    public GameObject MainCamera;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Update()
    {
        try
        {
            bool Can_Be_Seen = MainCamera.GetComponent<Camera_Renderer>().Check_If_Can_Be_Seen(gameObject);
            bool Attack_Distance_Check = Check_Distance(3.6f);
            if (Can_Be_Seen == false || Attack_Distance_Check == true)
            {
                if (agent.enabled == false)
                {
                    agent.enabled = true;
                }

                bool Is_Statue_Close_Enough = Check_Distance(10f);
                if (Is_Statue_Close_Enough == false)
                {
                    Basic_Movement();
                }
                else
                {
                    Chase_Movement();
                }
            }
        }
        catch
        {

        }
    }
    private bool Check_Distance(float distance)
    {
        GameObject player = GameObject.Find("player_Object");
        float xdif;
        float ydif;
        xdif = transform.position.x - player.transform.position.x;
        ydif = transform.position.x - player.transform.position.y;
        if (transform.position.x > player.transform.position.x)
        {
            xdif = transform.position.x - player.transform.position.x;
        }
        else
        {
            xdif = player.transform.position.x - transform.position.x;
        }
        if (transform.position.z > player.transform.position.z)
        {
            ydif = transform.position.z - player.transform.position.z;
        }
        else
        {
            ydif = player.transform.position.z - transform.position.z;
        }
        float diff = Mathf.Sqrt((xdif * xdif) + (ydif * ydif));
        if(diff > distance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
