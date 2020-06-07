using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Resources;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class TurretBehaviour : MonoBehaviour
{
    public Transform target;

    [Header("Turret attributes")]
    public float damage;
    public float range = 2f;
    public float fireRate = 1f;
    public float fireCountdown = 0f;

    [Header("Other")]
    public string enemyTag = "Enemy";

    public GameObject bulletPrefab;
    public Transform bulletSpawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, .25f);
    }

    void UpdateTarget()
    {
        GameObject[] EnemyList = GameObject.FindGameObjectsWithTag(enemyTag);

        float shortestDistance = range + 2f;
        GameObject targetedEnemy = null;

        foreach( GameObject enemy in EnemyList )
        {
            float distanceToEnemy = Vector2.Distance(gameObject.transform.position, enemy.transform.position);

            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                targetedEnemy = enemy;
            }

            if (targetedEnemy !=  null && distanceToEnemy <= range)
            {
                target = enemy.transform;
            }
            else
            {
                target = null;
            }
        }
    }

    void Shoot()
    {
        GameObject bulletPath =  (GameObject)Instantiate(bulletPrefab, bulletSpawnLocation.position, bulletSpawnLocation.rotation);
        BulletBehavior bullet = bulletPath.GetComponent<BulletBehavior>();

        if(bullet != null)
        {
            bullet.Seek(target);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        if(fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(gameObject.transform.position, range);
    }
}
