using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class Range_Attack : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite)
        {
            transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);
        }
        
    }

    private void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,lineOfSite);
    }

}

