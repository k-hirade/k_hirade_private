using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalamsSO : ScriptableObject
{
  [Header("スコア")]
  public int score;

  //PalamsSOが保存してある場所のパス
  public const string PATH = "PalamsSO";

  //PalamsSOの実体
  private static PalamsSO _entity;
  public static PalamsSO Entity
  {
    get
    {
      //初アクセス時にロードする
      if (_entity == null)
      {
        _entity = Resources.Load<PalamsSO>(PATH);

        //ロード出来なかった場合はエラーログを表示
        if (_entity == null)
        {
          Debug.LogError(PATH + " not found");
        }
      }

      return _entity;
    }
  }
}
