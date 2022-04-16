using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    private PlayerController plcS;
    // Start is called before the first frame update
    void Start()
    {
        plcS = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (plcS.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(gameObject.transform.position.y < -1)
        {
           Destroy(gameObject);
          // Destroy(gameObject);
        }
    }
}
