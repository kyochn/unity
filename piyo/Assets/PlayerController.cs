using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 8f;
    public float moveabeleRange = 5.5f;
    public float power = 1000f; //砲弾の威力
    public GameObject cannonBall; //砲弾のプレハブをアタッチ
    public Transform spawnPoint; //発射口をアタッチ

    // Update is called once per frame
    void Update () {
        transform.Translate (Input.GetAxisRaw ("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.position = new Vector2 (Mathf.Clamp (
                transform.position.x, -moveabeleRange, moveabeleRange),
            transform.position.y);
        
        //スペースキーが入力されたらShoot()を呼び出す
        if (Input.GetKeyDown (KeyCode.Space)) {
            Shoot ();
        }
    }

    //砲弾を発射する関数
    void Shoot () {
        //砲弾プレハブからインスタンス(newBullet)を生成
        GameObject newBullet = Instantiate (cannonBall, spawnPoint.position, Quaternion.identity) as GameObject;
        //AddForceでnewBulletのRigidbody2Dコンポーネントに上向きの力を加える
        newBullet.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * power);
    }
}