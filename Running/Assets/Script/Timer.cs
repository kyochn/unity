using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time = 0;

    // Update is called once per frame
    void Update()
    {
        if(Goal.goal==false){
            time += Time.deltaTime; //timeに経過時間を足す
            int t=Mathf.FloorToInt(time); //timeの小数点以下を切り捨てる
            Text uiText=GetComponent<Text>(); //このスクリプトがアタッチされているオブジェクトのコンポーネントを取得
            uiText.text="Time:" + t;  //テキストを変更
        }
    }
}
