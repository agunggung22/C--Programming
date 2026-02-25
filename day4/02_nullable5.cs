using static System.Console;

// null conditional operator ( ?, ?[]) 

string s1 = "hello";
string s2 = null;

var ret1 = s1.ToString(); // ok. 객체가 존재.
var ret2 = s2.ToString(); // 런타임에러(예외 발생)
