using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catapultSystem : MonoBehaviour {
    public Transform target;
    public float range = 60f;
    public string enemyTag = "Enemy";
    public Transform partToRotate;
    public float turnSpeed = 10;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public GameObject rockPrefab;
    public Transform firePoint;
    public Animator catapultFire;
    public AudioSource Fire;
    public bool LockOn;
    
   

    void Awake()
    {
        
    }

    // Use this for initialization
    void Start () {
      
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
        catapultFire = GetComponent<Animator>();
        Fire = GetComponent<AudioSource>();
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if (target == null)
            return;
        if(LockOn == true)
        {
 Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation,lookRotation,Time.deltaTime*turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);
        }
       

        if(fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;
	}

    void Shoot()
    {
       GameObject rockGO =  Instantiate(rockPrefab, firePoint.position, firePoint.rotation);
        catapultRock rock = rockGO.GetComponent<catapultRock>();

        if (rock != null)
            rock.Seek(target);
    }

    void UpdateTarget()
    {

        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach(GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
                LockOn = true;
            }
        }

        if(nearestEnemy!= null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
            catapultFire.SetBool("catapultFire", true);
            //Fire.Play();
            LockOn = true;
        }
        else
        {
            target = null;
            catapultFire.SetBool("catapultFire", false);
        }
    }

     void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range);
        Gizmos.color = Color.green;
    }
}
