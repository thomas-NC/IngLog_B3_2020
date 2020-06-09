using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{

    public static int Score = 0;
    public static int PlayerHp = 3;

    [Header("UI")]
    public TextMesh scoreTM;
    public TextMesh PlayerHpTM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Score = " + Score);
        scoreTM.text = "SCORE " + Score;
        PlayerHpTM.text = PlayerHp.ToString();
        
    }
}
