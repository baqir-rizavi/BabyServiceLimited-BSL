using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMotor : MonoBehaviour
{

    [SerializeField] Transform target;
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed = 5f;
    [SerializeField] float movementSmoothness = 1f;
    [SerializeField] float ufoHeight = 5f;
    
    [SerializeField] float timeGapInShooting = 1.5f;

    Transform tempBullet;

    void Start()
    {
        StartCoroutine(shooting());
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 nextPos = new Vector3(target.position.x, ufoHeight, target.position.z);
        transform.position = Vector3.Lerp(transform.position, nextPos, 1f/movementSmoothness * Time.deltaTime);
        if (tempBullet != null)
        {
            tempBullet.Translate((target.position - transform.position) * bulletSpeed * Time.deltaTime, Space.World);
        }
    }

    IEnumerator shooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeGapInShooting);
            GameObject b = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            tempBullet = b.transform;
            Destroy(b, 2f);
        }
    }
}
