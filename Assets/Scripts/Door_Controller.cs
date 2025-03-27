using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class Door_Controller : MonoBehaviour
{
    public string door;
    public NavMeshSurface bigBootySurface;
    // Start is called before the first frame update
    void Start()
    {
        bigBootySurface = GetComponentInParent<NavMeshSurface>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            OnOpen();
        }
    }
    void OnOpen()
    {
        this.gameObject.SetActive(false);
        bigBootySurface.BuildNavMesh();
    }
}
