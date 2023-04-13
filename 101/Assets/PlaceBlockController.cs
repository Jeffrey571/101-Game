using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBlockController : MonoBehaviour
{
    // Start is called before the first frame update

    
    public BlockPalletController Pallet;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 8f))
            {
                Debug.Log($"Hit GameObject {hit.collider.gameObject.name}");

                GameObject BlockGeo = Instantiate(Pallet.GetCurrentBlock());
                BlockGeo.transform.position = Vector3Int.RoundToInt(hit.collider.transform.position) + hit.normal;

            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 8f))
            {
                if (hit.collider.gameObject.name.Contains("Cube"))
                {
                    Destroy(hit.collider.gameObject);
                }

            }
        }

        if (Input.mouseScrollDelta.y > 0)
        {
            Pallet.IncrumentBlockIndex();
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            Pallet.DecrumentBlockIndex();
        }
    }
}
