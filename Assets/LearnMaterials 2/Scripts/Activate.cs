using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    [SerializeField]
    private List<SampleScript> uses = new List<SampleScript>();

      void Start()
    {
        foreach (SampleScript use in uses)
        {
            use.Use();
        }
    }

    void Update()
    {

    }
}