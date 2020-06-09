using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTurret : MonoBehaviour
{

    public TextMesh turretCount;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        turretCount.text = BuildManager.instance.turretCounter.ToString();
    }

    private void OnMouseDown()
    {
        BuildManager.instance.BuildObstacle = false;
        BuildManager.instance.BuildTurret = true;
    }
}
