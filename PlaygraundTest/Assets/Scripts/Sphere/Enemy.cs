using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;

    [SerializeField]
    private Rigidbody enemyRb;

    public void Go(GameObject player) => enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);

    public void Die() => Destroy(gameObject);

}
