using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeState : MonoBehaviour
{
    public float ChargeSpeed = 5f;
    public float fieldOfView = 200f;
    public float speed;
    public float lineOfSite;
    private Transform player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


}
