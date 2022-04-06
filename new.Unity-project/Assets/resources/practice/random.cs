using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    int num = Random.Range(0, 100);// 0~99
    Debug.Log(num);
    // 確率
    if (num < 30)
    {
    }
    // 30%の確率
  }

  // Update is called once per frame
  void Update()
  {

  }
}
