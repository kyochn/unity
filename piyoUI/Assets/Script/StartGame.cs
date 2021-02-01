using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移用のライブラリ

public class StartGame : MonoBehaviour {
    public void LoadingNewScene () {
        //LoadSceneで任意のシーンを読み込む
        SceneManager.LoadScene ("Main");
    }
}