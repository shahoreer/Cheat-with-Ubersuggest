// Project: Cheat with ubersuggest
// 4-13-2021 (14 years now)


using System;
class HelloWorld {
    
    static String keyword1 = "luxurious";
    static String keyword2 = "cars";
       
  static void Main() {
     Console.WriteLine("Visit This Site-->>");
      
     Console.WriteLine(theurl());
  }
  
  static String theurl(){
      
      String url="https://app.neilpatel.com/en/ubersuggest/keyword_ideas?keyword="+keyword1+"%20"+keyword2+"&locId=2840&lang=en";
      
      return url;
  }
  
}