using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnterEndzone : MonoBehaviour
{

    //public CircleCollider2D endZone;
    // Start is called before the first frame update
    void Start()
    {
        //endZone = gameObject.GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Enemy"))
        {
            GameManager.instance.PlayerHp -= 1;
            Destroy(col.gameObject);
        }
    }
}
