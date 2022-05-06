using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copier : SampleScript
{
    [SerializeField]
    private GameObject target;
    private GameObject new_object;
    [SerializeField]
    [Min(1)]
    private int amount;
    [SerializeField]
    private float step;
    private Vector3 location = new Vector3(0, 0, 0);

    [ContextMenu("Use")]
    public override void Use()
       
    {
        Copy();       
    }

    public void Copy()
    {
        location = transform.position;
        for (int i = 0; i < amount; i++)
        {
            location.x += step;
            new_object = Instantiate(target, location, Quaternion.identity);
        }
    }

    // Start is called before the first frame update

}
