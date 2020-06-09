using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehavior : MonoBehaviour
{
    public AstarPath pathfinderScript;

    public Color hoverColor;
    private SpriteRenderer rend;
    private Color BaseColor;
    
    // Start is called before the first frame update
    void Start()
    {
        pathfinderScript = GameObject.Find("PathfindingManager").GetComponent<AstarPath>();
        rend = gameObject.GetComponent<SpriteRenderer>();
        BaseColor = rend.color;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseExit()
    {
        rend.color = BaseColor;
    }
    private void OnMouseEnter()
    {
        rend.color = hoverColor;
    }
    private void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        if (BuildManager.instance.BuildTurret && BuildManager.instance.turretCounter > 0)
        {
            Instantiate(BuildManager.instance.turret, gameObject.transform.position, gameObject.transform.rotation);
            BuildManager.instance.turretCounter -= 1;
            
        }
        else if(BuildManager.instance.BuildObstacle && BuildManager.instance.obstacleCounter > 0)
        {
            Instantiate(BuildManager.instance.obstacle, gameObject.transform.position, gameObject.transform.rotation);
            BuildManager.instance.obstacleCounter -= 1;
            pathfinderScript.Scan();

        }
    }
}
