using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBonus : MonoBehaviour
{
   //[SerializeField] private GameObject player;
    [SerializeField] private GameObject objectBonus;
   public enum Bonus { Score = 1,Speed,}
   public Bonus bonus;
    //private void OnCollisionEnter(Collision BonusCol)
    //{
    //    if (BonusCol.gameObject.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    //public void Score()
    //{
    //    bonus = Bonus.Score;
    //    Debug.LogWarning("Score");
    //    if(objectBonus.tag == "player")
    //    {
            
    //    }
    //}
    //public void Speed()
    //{
    //    bonus = Bonus.Speed;
    //    Debug.LogWarning("Speed");
    //}

}
