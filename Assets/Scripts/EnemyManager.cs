using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public float startingHp = 3f;
    public float currentHp;

    public Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = startingHp;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = currentHp / startingHp;
        //Debug.Log("currentHp = " + currentHp + " // Ratio = " + currentHp / startingHp);
        if (currentHp <= 0)
        {
            GameManager.Score += 1;
            Destroy(gameObject);
        }
    }
}
