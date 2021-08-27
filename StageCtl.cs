using System.Collections;
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
    public GuiCtl gui;
    
    public List<GameObject> pBallList;
    
    public int stageStat = 0; // ステージ状態(0:開始前 1:開始中)
    
    public float span = 1f;  // 定期処理
    private float currentTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        setBall();
        startRace();
    }
    
    public void setBall(){
        // ボール一覧設置
        for ( int i = 0 ; i < ballNum ; i++ ) {
            GameObject nBall = Instantiate(obj, StartBase + StartInterVal * ((i+1) / 2) * (((i+1) % 2) * 2 - 1) + StartInterVal * ((ballNum + 1) % 2) / 2 , Quaternion.identity);
            //if (ballNum % 2 == 1) { // 奇数
                pBallList.Add(nBall);
            //} else { // 偶数
            //    Instantiate(obj, StartBase, Quaternion.identity);
            //}
            nBall.GetComponent<BallCtl>().initialize();
            
        }
    }
    
    public void startRace(){
        // 全ボールに開始通知
        foreach(var pB in pBallList ){
            pB.GetComponent<BallCtl>().startMove();
        }
        stageStat = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (stageStat == 1) {
            currentTime += Time.deltaTime;

            if(currentTime > span){
                // 順位の前後チェック(ゴール済みor最下位はチェックしない)
                for (int i = goalNum; i < ballNum - 1; i++) {
                    // 順位入れ替え要
                    if (pBallList[i].transform.position.y > pBallList[i+1].transform.position.y) {
                        
                        var cache = pBallList[i];
                        pBallList[i] = pBallList[i+1];
                        pBallList[i+1] = cache;
                        
                        gui.changeRank(i,i,i+1);
                        gui.changeRank(i+1,i+1,i);
                        Debug.Log("CHG" + i +"<->" + (i+1));
                        i++;
                    }
                }
                currentTime = 0f;
            }
            
            // ゴール判定(先頭のみ)
            if ((goalNum<ballNum)&&(pBallList[goalNum].transform.position.y < GoalY)){
                    Debug.Log("GOAL" + goalNum);
                    goalNum++;
            }
        }
    }
}
