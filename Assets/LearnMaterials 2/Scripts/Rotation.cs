using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : Use
{

    [SerializeField]
    Vector3 RotVec;
    [SerializeField]
    float rotateSpeed;
    float rotationAmt;
    bool rotateting = false;
    float totalRotation = 0;


    public void Start()
    {
        rotationAmt = rotateSpeed * Time.deltaTime;
    }

    public void Update()
    {
        if (rotateting)
        {
            if (totalRotation < 90)
            {
                Debug.Log(rotationAmt);
                transform.Rotate(rotationAmt, 0, 0);
                totalRotation += rotationAmt;
                
            }
        }
    }
    [ContextMenu("Запуск")]
    public  void Use()
    {
        rotateting = true;

    }
}