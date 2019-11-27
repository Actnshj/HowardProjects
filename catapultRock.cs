using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catapultRock : MonoBehaviour {
    private Transform target;
    public float speed = 30f;
    public GameObject impactEff;
     public Rigidbody body;
    public float upVel = 10;
	// Use this for initialization


	void Start () {
        //body = GetComponent<Rigidbody>();
        body.velocity = transform.forward * upVel/4;
        body.velocity = transform.up.normalized * upVel / 3;
        //StartCoroutine(Delay());
	}
	
	// Update is called once per frame
	void Update () {

        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

       
        Vector3 dir = target.position - transform.position;       
        float distanceThisFrame = speed * Time.deltaTime;
;
        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        
       
	}

    public void Seek(Transform track)
    {
        target = track; 
    }

    void HitTarget()
    {
        GameObject effectIns = Instantiate(impactEff, transform.position, transform.rotation);
        Destroy(gameObject);
    }

   void OnCollisionEnter(Collision collision)
    {
       if( collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Enemy")
        {
            HitTarget();
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(9);
        yield break;
    }
}
