using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float fireRate = 0.5f;

    private float nextFireTime = 0f;

    private GameObject bulletInst;

    //private void Update()
    //{
      //  HandleCatShooting();
    //}
    public void HandleCatShooting()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            // Spawn bullet. ZO
            bulletInst = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }
    }
}
