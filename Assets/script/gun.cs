using System.Collections;
using UnityEngine;

public class gun : MonoBehaviour {
    public bool isFiring;
    public bullet bullet;
    public float bulletSpeed;
    public float timeBetweenShots;
    private float shotCounter;
    public Transform firePoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                bullet newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as bullet;
                newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
	}
}
