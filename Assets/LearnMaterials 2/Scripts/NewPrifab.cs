using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPrifab : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    private GameObject new_object;
    [SerializeField]
    [Min(1)]
    private int amount;
    [SerializeField]
    private float step;
    private Vector3 location = new Vector3(0, 0, 0);

    [ContextMenu("Запуск")]
    public void Use()
    {
        NewP();
    }

    public void NewP()
    {
        location = transform.position;
        for (int i = 0; i < amount; i++)
        {
            location.x += step;
            new_object = Instantiate(prefab, location, Quaternion.identity);
        }
    }

}
