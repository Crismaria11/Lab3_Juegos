using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    public GameObject currentPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            if (currentPlayer == false)
            {
                currentPlayer = Instantiate(prefab, transform.position, Quaternion.identity);
            }
        }
    }
}
