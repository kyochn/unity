using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGenerator : MonoBehaviour {
    public GameObject obj; //ひよこ玉プレハブ
    public float interval = 3.0f; //生成間隔
    // Start is called before the first frame update
    void Start () {
        InvokeRepeating ("SpawnObj", 0.1f, interval); //一定間隔で関数(SpawnObj)を呼び出す
    }
    
    //ひよこ玉を生成する関数
    void SpawnObj () {
        Instantiate (obj, transform.position, transform.rotation);
    }
}