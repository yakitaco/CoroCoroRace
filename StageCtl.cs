﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCtl : MonoBehaviour
{
    public Vector3 StartBase; // スタート設置ベース(偶数の場合は中央に置かない)
    public Vector3 StartInterVal;  // スタート設置間隔(+-交互に設置)
    
    public float GoalY;  // ゴールY座標
    public int ballNum;  // ボール数
    public int goalNum;  // ゴール済数
    
    public GameObject obj;  // デバッグ用
    
    public List<BallCtl> pBallList;
    
    public int stageStat = 0; // ステージ状態(0:開始前 1:開始中)
    
    public float span = 1f;  // 定期処理
    private float currentTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void setBall(){
        // ボール一覧設置
        for ( int i = 0 ; i < ballNum ; i++ ) {
            //if (ballNum % 2 == 1) { // 奇数
                pBallList.Add(Instantiate(obj, StartBase + StartInterVal * (i / 2) * ((i % 2) * 2 - 1) + StartInterVal * (ballNum % 2) / 2 , Quaternion.identity).GetComponent<BallCtl>());
            //} else { // 偶数
            //    Instantiate(obj, StartBase, Quaternion.identity);
            //}
        }
    }
    
    public void startRace(){
        // 全ボールに開始通知
        foreach(var pB in pBallList ){
            pB.startMove();
        }
        stageStat = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (stageStat == 1) {
            currentTime += Time.deltaTime;

            if(currentTime > span){
                // 順位の前後チェック(最下位はチェックしない)
                for (int i = 0; i < ballNum - 1; i++) {
                    // 順位入れ替え要
                    if (pBallList[i].transform.y > pBallList[i+1].transform.y) {
                        
                        var cache = pBallList[i];
                        pBallList[i] = pBallList[i+1];
                        pBallList[i+1] = cache;
                        
                        i++;
                    }
                }
                currentTime = 0f;
            }
            
            // ゴール判定
            if ( int i = goalNum ; i < ballNum ; i++ ) {
                
            }
        }
    }
}