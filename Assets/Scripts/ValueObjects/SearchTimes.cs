using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class SearchTimes
{
  //値オブジェクトのプロパティはprivateで不変にする。
  private readonly int time;
  
  SearchTimes(int time) 
  {
    //timeが0以下になる時は、0で固定にする。
    if(time < 0) time = 0;
    this.time = time;
  }
  
  public int getValue() {
    return time;
  }

  public SearchTimes addTime(int addValue) {
    //値を変更する時は、新しいインスタンスを生成する。
    return new SearchTimes(time + addValue);
  }
}