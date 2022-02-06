using System;
using System.Collections.Generic;
using System.Linq;

/*
    問題名称:B - 上書き
    問題URL:https://atcoder.jp/contests/past202012-open/tasks/past202012_b
    提出結果:https://atcoder.jp/contests/past202012-open/submissions/29132982
*/
using System;
using System.Collections.Generic;
using System.Linq;
 
class Program
{  
	static void Main()
	{
		// 標準入力を取得
		int num = Int32.Parse(Console.ReadLine());
		string str = Console.ReadLine();

    // 返却用変数に文字列をセット
    string result = str;
		int i = 0;
    while (i < num) {
      string repStr = str.Substring(i,1);
			result = result.Replace(repStr, "") + repStr;
      i++;
    }
    Console.WriteLine(result);
	}  	
}