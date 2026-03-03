// 핵심 : switch expression

int dayofweek = 1;

string s1 = "";

// 일반적인 방식의 switch 문
switch (dayofweek)
{
	case 0:
		s1 = "sun"; break;
	case 1:
		s1 = "mon";break;
	case 2:
		s1 = "tue";break;
	default:
		s1 = "unknown"; break;
}

// C# 언어가 가진 특별한 switch 문법
// => 변수 초기화 + 조건문을 합친 역할
// => switch expression이라 부름
//		Rust, Swift 등 최신 문법에 널리 사용

string s2 = dayofweek switch
{
	0 => "sum",
	1 => "mon",
	2 => "tue",
	_ => "unknown"
};

switch(dayofweek)
{
	case 0: s1 = "sun"; break;
	case 1: s1 = "mon"; break;
	case 2: s1 = "tue"; break;
	default : s1 = "unknown"; break;
}
