using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMotor : MonoBehaviour
{

    [SerializeField] Transform target;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform spawnPos;
    [SerializeField] float bulletSpeed = 5f;
    [SerializeField] float movementSmoothness = 1f;
    [SerializeField] float ufoHeight = 6f;
    
    [SerializeField] float timeGapInShooting = 1.5f;

    Transform tempBullet;
    Vector3 tempPosition;

    void Start()
    {
        StartCoroutine(shooting());
    }

    
    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 nextPos = new Vector3(target.position.x, ufoHeight, target.position.z);
            transform.position = Vector3.Lerp(transform.position, nextPos, 1f/movementSmoothness * Time.deltaTime);
            if (tempBullet != null && tempPosition != null)
            {
                tempBullet.Translate((tempPosition - transform.position).normalized * bulletSpeed * Time.deltaTime, Space.World);
            }
        }
    }

    IEnumerator shooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeGapInShooting);
            GameObject b = Instantiate(bullet, spawnPos.position, Quaternion.identity) as GameObject;
            tempBullet = b.transform;
            tempBullet.rotation = Quaternion.LookRotation((tempPosition - transform.position).normalized);
            if (target != null)
                tempPosition = target.position;
            Destroy(b, 2f);
        }
    }
}
