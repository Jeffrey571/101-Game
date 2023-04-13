using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBlockGenerator : MonoBehaviour
{

    public GameObject BlockPrehab;

    // Start is called before the first frame update
    void Start()
    {
        for(int x = -20; x < 20; x++)
        {
            for (int y = -20; y < 20; y++)
            {
                GameObject newblock = Instantiate(BlockPrehab);

                newblock.transform.position = transform.position + new Vector3(x, 0, y);
            }
        }
    }

}
