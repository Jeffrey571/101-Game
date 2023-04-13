using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPalletController : MonoBehaviour
{
    
    [SerializeField]
    private int desiredBlockIndex = 0;
    public GameObject[] BlockArr = new GameObject[3];

    public void IncrumentBlockIndex()
    {
        desiredBlockIndex = (desiredBlockIndex + 1) % (BlockArr.Length);
    }
    public void DecrumentBlockIndex()
    {
        desiredBlockIndex = (desiredBlockIndex <= 0) ? BlockArr.Length - 1 : desiredBlockIndex--;
    }
    public GameObject GetCurrentBlock()
    {
        return BlockArr[desiredBlockIndex];
    }
}
