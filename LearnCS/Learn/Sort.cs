using System;
using System.Linq; 
using System.Collections.Generic;

namespace LearnCS{

  public class Sort{

    public void Solve(List<int> a1){
  
      int temp = 0;
      for(int i = 0; i < a1.Count - 1; ++i){
        for(int j = i + 1; j < a1.Count; ++j){
          if(a1[i] > a1[j]){
            temp = a1[i];
            a1[i] = a1[j];
            a1[j] = temp;
          }
        }
      }

      Console.WriteLine(string.Join(',', a1.Select(x => x.ToString()).ToArray()));
    
    }

  }    
}
