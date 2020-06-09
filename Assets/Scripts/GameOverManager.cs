using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cameraFocus;
    public Camera cam;
    public int test;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.PlayerHp <= 0)
        {
            cam.transform.position = cameraFocus.position;
        }
    }
}
