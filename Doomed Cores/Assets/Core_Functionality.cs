using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core_Functionality : MonoBehaviour
{
    int coreLife;

    // Start is called before the first frame update
    void Start()
    {
        coreLife = 10;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && coreLife != 0)
        {
            print($"{coreLife}");
            coreLife--;
        }

        if(coreLife == 0)
        {
            print("Core is dead YOU LOSE");
            Destroy(gameObject);
        }

    }
}
