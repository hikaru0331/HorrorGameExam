using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RandomMovement : MonoBehaviour
{
    private float interval = 0.5f;
    private float timeCount;
    [SerializeField] private float speed = 2.0f;
 
    private void Start() 
    {
        Destroy(this.gameObject, 5.0f);
    }

    void Update()
    {
        timeCount += Time.deltaTime;
 
        // 自動前進
        transform.position += -transform.forward * speed * Time.deltaTime;
 
        // 指定時間の経過（条件）
        if(timeCount > interval)
        {
            // 進路をランダムに変更する
            Vector3 course = new Vector3(0, Random.Range(0, 180), 0);
            transform.localRotation = Quaternion.Euler(course);
 
            // タイムカウントを０に戻す
            timeCount = 0;
        }
    }
}