using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingcube : MonoBehaviour
{
  [SerializeField] private GameObject cubemove;
  // Start is called before the first frame update
  void Start()
  {
    Instantiate(cubemove);
  }

}
