using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Game_Manager : MonoBehaviour
{
    public UnityEvent PauseGame = new UnityEvent();
    public static Game_Manager Instance {  get; private set; }
    public void Awake()
    {
        
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
    }
    public void PauseMenu()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
        else
        {
            PauseGame.Invoke();
            //Time.timeScale = 0f;
        }
    }
}
