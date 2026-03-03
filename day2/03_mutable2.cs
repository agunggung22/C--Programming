// Java, C#, Swift에서 문자열 타입은 2개가 있음

// 1. immutable String
//      heap에 생성됨
//      변경이 불가능(하도록 설계됨)
//      "" 표기 그 자체로 string 인스턴스임

using System.Text;
string s1 = "ABC";      // immutable


// 2. mutable String
//      new로 생성해야하는 별도 클래스
//      변경이 가능(하도록 설계됨)
StringBuilder s2 = new StringBuilder("XYZ");