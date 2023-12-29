using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = UnityEngine.Vector2.Distance(transform.position, player.transform.position);        
        UnityEngine.Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = UnityEngine.Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = UnityEngine.Quaternion.Euler(UnityEngine.Vector3.forward * angle);
        
    }
}
