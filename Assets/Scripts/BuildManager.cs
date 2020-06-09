using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    public int turretCounter = 3;
    public int obstacleCounter = 20;
    public GameObject turret;
    public GameObject obstacle;


    [Header("Build Selection")]
    public bool BuildTurret;
    public bool BuildObstacle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
