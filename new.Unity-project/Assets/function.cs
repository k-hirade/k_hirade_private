using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class function : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    // SayName1("hirade", 85);
    string username = GetSayName("yamada", 85);
    Debug.Log(username);
  }

  // 関数の作り方
  //   void SayName1(string username, int weight)
  //   {
  //     Debug.Log("keisi" + username + weight);
  //   }

  // 何も返さない→void / 戻り値がある→string
  string GetSayName(string fullname, int weight)
  {
    return "keisihirade" + fullname + weight;
  }
}
