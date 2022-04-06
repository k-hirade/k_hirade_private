using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public int hp = 100;
  // Start is called before the first frame update
  public void Attack()
  {
    Debug.Log("敵の攻撃");
  }
  public void Heal()
  {
    Debug.Log("敵の回復");
  }
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
