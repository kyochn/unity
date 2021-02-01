using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour {
    public float deleteTime = 2.0f; //砲弾を消去するまでの時間
    // Start is called before the first frame update
    void Start () {
        //Destroy()でオブジェクトを削除
        Destroy (gameObject, deleteTime);
    }

    // Update is called once per frame
    void Update () {

    }
}