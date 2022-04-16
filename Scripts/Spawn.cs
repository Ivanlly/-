using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private PlayerController playerS;
    public GameObject ob;
    //public float l = 30;
    public Vector3   op = new Vector3(20, 0, 0);
    public float st = 2;
    public float de = 2;
    // Start is called before the first frame update
    void Start()
    {
        playerS = GameObject.Find("player").GetComponent<PlayerController>();
        InvokeRepeating("spawnO", st, de);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnO()
    {
        if (playerS.gameOver == false)
        {
            Instantiate(ob, op, ob.transform.rotation);
        }
    }
}
