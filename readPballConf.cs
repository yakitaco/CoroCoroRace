using System.Collections;
using System.Collections.Generic;
using System.IO;

// ボール設定ファイルを読み取る
public class readPballConf
{
    public readPballConf(string filePath){
        if (System.IO.File.Exists(@filePath)){
            StreamReader sr = new StreamReader(@filePath);
            // 末尾まで繰り返す
            while (!sr.EndOfStream) {
                // CSVファイルの一行を読み込む
                string line = sr.ReadLine();
                // 読み込んだ一行をカンマ毎に分けて配列に格納する
                string[] values = line.Split(',');
 
                // 配列からリストに格納する
                List<string> lists = new List<string>();
                lists.AddRange(values);
 
                // コンソールに出力する
                foreach (string list in lists) {
                    System.Console.Write("{0} ", list);
                }
                System.Console.WriteLine();
            }
            System.Console.ReadKey();
        }
    }
    
    public void get(int c){
        
    }
    
    public void set(){
    
    }
    
}
