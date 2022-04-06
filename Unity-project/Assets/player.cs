using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
  // Start関数はupdate前に一度だけ実行
  void Start()
  {
    Debug.Log("けいし");
  }

  // Updateマイフレーム(役0.02秒に一回)実行
  void Update()
  {
    transform.position += new Vector3(0.1f, 0, 0);
  }
}
