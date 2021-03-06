﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{

    public Transform target;
    public int damage = 1;

    [Header("Attributes")]
    public float speed;

    public void Seek (Transform target)
    {
        this.target = target;
    }

    void EnemyHit()
    {
        target.gameObject.GetComponent<EnemyManager>().currentHp -= damage;
        //Debug.Log(target.gameObject.GetComponent<EnemyManager>().currentHp);
        //Debug.Log("tuchey");
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector2 dir = target.position - transform.position;
        float distanceDelta = speed * Time.deltaTime;

        if(dir.magnitude <= distanceDelta)
        {
            EnemyHit();
            return;
        }

        transform.Translate(dir.normalized * distanceDelta, Space.World);
    }
}
