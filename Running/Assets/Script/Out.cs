using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour
{
   void OnTriggerEnter(Collider other){ //判定エリアに接触した場合に自動的に呼び出される関数
       if(other.gameObject.tag=="Player"){ //Playerタグが触れた時に処理を開始するようにする
           SceneManager.LoadScene(SceneManager.GetActiveScene().name); //SceneManager.GetActiveScene().nameは現在のシーンの名前
       }
   }
}
