using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatBackground : MonoBehaviour
{
    private Vector3 startP;
    public float repeatWidth;
  
    // Start is called before the first frame update
    void Start()
    {
        startP = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startP.x - repeatWidth)
        {
            transform.position = startP;
        }
    }
}
