using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Patrolling")]
    public GameObject patrolLeftPoint;
    public GameObject patrolRightPoint;
    public float patrolSpeed;
    private Rigidbody2D rb;
    private Transform patrolTargetPoint;
    // Start is called before the first frame update
    void Start()
    {
        patrolTargetPoint = patrolRightPoint.transform;
        patrolSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = patrolTargetPoint.position - transform.position;
        if (patrolTargetPoint == patrolRightPoint.transform) {
            rb.velocity = new Vector2(patrolSpeed, 0);
        } else {
            rb.velocity = new Vector2(-patrolSpeed, 0);
        }

        if (Vector2.Distance(transform.position, patrolTargetPoint.position) < 0.5f) {
                if (patrolTargetPoint == patrolRightPoint.transform) {
                    patrolTargetPoint = patrolRightPoint.transform;
                } else {
                    patrolTargetPoint = patrolLeftPoint.transform;
                }
        }
    }

    private void OnDrawGizmos() {
        Gizmos.DrawWireSphere(patrolLeftPoint.transform.position, 0.5f);
        Gizmos.DrawWireSphere(patrolRightPoint.transform.position, 0.5f);
        Gizmos.DrawLine(patrolLeftPoint.transform.position, patrolRightPoint.transform.position);
    }
}
