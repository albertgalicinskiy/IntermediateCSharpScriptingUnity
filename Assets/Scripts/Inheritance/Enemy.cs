using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected void Attack()
    {
        Debug.Log("Enemy Atack");
        GetComponent<Renderer>().material.color = Color.red;
    }
}
