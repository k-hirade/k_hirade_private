using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour
{
  int hp;
  public Enemy enemy;
  void Attack()
  {
    Debug.Log("攻撃");
  }
  void Heal()
  {
    Debug.Log("回復");
  }
  // Start is called before the first frame update
  void Start()
  {
    // Attck();
    // Heal();
    // Debug.Log(hp);
    enemy.Attack();
    Debug.Log(enemy.hp);
  }


  // Update is called once per frame
  void Update()
  {

  }
}
