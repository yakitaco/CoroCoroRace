using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuiCtl : MonoBehaviour
{
    List<string> nameList = new List<string>();
    public Text t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void addPball(string name, Color color){
        nameList.Add(name);
        showList();
    }
    
    public void changeRank(int before, int after){
        var cache = nameList[before];
        nameList[before] = nameList[after];
        nameList[after] = cache;
        showList();
    }
    
    void showList(){
        t.text = "";
        int i = 1;
        foreach(var n in nameList ){
            t.text += "[" + i +"] "+n + "\n";
            i++;
        }
    }
    
}
