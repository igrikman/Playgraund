using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTriger : MonoBehaviour
{
    private void OnCollisionEnter(Collision CoinCollision)
    {
        Debug.LogWarning("Collision Enteret");
        if (CoinCollision.gameObject.tag == "CoinTag")
        {
            Debug.LogWarning("Collision object is Coin");
            Destroy(CoinCollision.gameObject, 0f);
        }
        else
        {
            Debug.LogWarning("Collision object isn't a Coin");
        }
    }

    private void Update()
    {
        
    }
}
   
