using System;
using System.Collections.Generic;
using System.Linq;

/*
    問題名称:A - ○✕ゲーム
    問題URL:https://atcoder.jp/contests/past202012-open/tasks/past202012_a
    提出結果:https://atcoder.jp/contests/past202012-open/submissions/29132384
*/
class Program
{
	static void Main()
    {
      	// 標準入力を取得
	    string str = Console.ReadLine();
	  	string result = "";
		int i = 0;
        int count = 0;
      	while (i < 5 && count < 3){
            string value = str.Substring(i,1);
          	if(value == "o" && result != "o")
        		{ 
                  result = "o";
                  count = 0;
                }
          	else if (value == "x" && result != "x")        		
            	{ 
                  result = "x";
                  count = 0;
                }
          	count++;
            i++;
        }
  		if(count == 3){
          Console.WriteLine(result);
        } else {
          Console.WriteLine("draw");
        }
    }
}