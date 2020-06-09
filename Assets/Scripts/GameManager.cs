using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    public int Score = 0;
    public int PlayerHp = 3;

    [Header("UI")]
    public TextMesh scoreTM;
    public TextMesh EndscoreTM;
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
        EndscoreTM.text = "Frodos killed \n" + Score;
        PlayerHpTM.text = PlayerHp.ToString();
        
    }
}
