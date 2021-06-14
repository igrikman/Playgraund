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

}
