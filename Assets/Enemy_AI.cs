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

        transform.position = UnityEngine.Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        
        
    }
}
