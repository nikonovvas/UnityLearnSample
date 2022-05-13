using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMod : UseMain
{
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private Vector3 destination = new Vector3(3, 0, 0);

    [ContextMenu("Запустить")]
    public override void Use()
    {
        StartCoroutine(Move());
    }


    IEnumerator Move()
    {
        Vector3 t = (destination - transform.position).normalized;
        while (Vector3.Distance(transform.position, destination) > 2f * Time.deltaTime)
        {
            transform.position += t * speed * Time.deltaTime;
            yield return null;
        }
        transform.position = destination;
    }
    void Start()
    {

    }
    void Update()
    {

    }
}