using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinTriger : MonoBehaviour
    
{
    public int score = 0;
    public Text indicator;
    private void OnCollisionEnter(Collision CoinCollision)
    {
        
        if (CoinCollision.gameObject.tag == "CoinTag")
        {
            Destroy(CoinCollision.gameObject, 0f);
            ScoreCoin(1);
        }
       
    }
    void ScoreCoin(int takecoin)
    {
        score += takecoin;    
        indicator.text = score.ToString();
    }
    private void Start()
    {
        indicator.text = score.ToString(); 
    }

    private void Update()
    {
       
    }
}
   
