using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObstacle : MonoBehaviour
{
    public TextMesh obstacleCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obstacleCount.text = BuildManager.instance.obstacleCounter.ToString();
    }

    private void OnMouseDown()
    {
        BuildManager.instance.BuildObstacle = true;
        BuildManager.instance.BuildTurret = false;
    }
}
