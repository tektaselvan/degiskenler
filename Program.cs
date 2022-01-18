int deger = 2;
string degisken=null;
string Degisken = null;
string degisken_veri = null;
string degisken1 = " ";

byte b = 5; //1 byte
sbyte c =5; // 1 byte
short s = 5; // 2 byte
ushort us = 5; // 2 byte
int16 i16 = 5; // 2 byte
int i = 4; //4 byte
int32 i32 = 32; // 4 byte
int64 i64 = 64; // 8 byte
uint ui = 2; // 4 byte
long l = 4; // 8 byte
ulong l1 = 5; // 8 byte

//reel sayılar
float f = 5; // 4 byte 
double d = 5; // 8 byte
decimal de =5; // 16 byte

char ch = '2'; // 2 byte
string str = "Elvan"; // sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt =DateTime.Now;
Console.WriteLine(dt);

object o1 = x;
object o2 = 'y';
object o3 = 4;
object o4 = 4.2;

//string ifadeler
string str1 =string.Empty;
str1 = "Elvan Tektaş";
string ad = "Elvan";
string soyad = "Tektaş";
string tanisim =ad + " " + soyad;

//integer tanımlama şekilleri
int integer1 = 5;
int integer2 = 5;
int integer3 = integer1 * integer2;

//boolean
bool bool1 = 10>2;

//degisken donusumleri
string str20 ="20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger); //Çıktı 2020

int int21 =int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); //Çıktı 40

int int22 = int20 + int.Parse(str20); //Çıktı 40

//DateTime
string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dateTime);

string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(dateTime2);

string hour =DateTime.Now.ToString["HH:mm"];
Console.WriteLine(hour);



