using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pBallCnf
{
    string name;
    Color color;
    float angularDrag; // 回転抗力
    float drag;  // 抗力
    float mass; // 質量
    
    float bounciness; // 面の跳ね返し度合い
    float dynamicFriction;
    float staticFriction;
    
    float scale;  // 大きさ

    public pBallCnf(string _name, Color _color, float _angularDrag, float _drag, float _mass,
     float _bounciness, float _dynamicFriction, float staticFriction, float _scale){
    
    
    }


}
