using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResult : MonoBehaviour
{
    private int highScore;
    public Text resultTime;
    public Text bestTime;
    public GameObject resultUI;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefsでセーブができる
        if(PlayerPrefs.HasKey("HighScore")){ //セーブデータにHighScoreという項目があれば
            highScore = PlayerPrefs.GetInt("HighScore"); //highScoreにその値を代入
        }else{
            highScore=999;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Goal.goal){ //ゴールしたとき
            resultUI.SetActive(true); //resultUIに格納したオブジェクトを表示する
            int result = Mathf.FloorToInt(Timer.time); //タイマーの値を取得
            resultTime.text="ResultTime:"+result;
            bestTime.text="BestTime:"+highScore;
            if(highScore>result){
                PlayerPrefs.SetInt("HighScore",result);
            }
        }
    }

    public void OnRetry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Timer.time=0;
        Goal.goal=false;
    }
}
