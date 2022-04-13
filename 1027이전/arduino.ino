int joyX1;                    //조이스틱1 상하
int joyY1;                    //조이스틱1 좌우
int joyX2;                    //조이스틱2 상하
int joyY2;                    //조이스틱2 좌우
int button1 = 34;              //F 버튼
int button2 = 35;              //ESC 버튼
String data;


// 세그먼트 0~9까지 숫자를 배열로 초기화
byte num[11][7] =
{ 
 { 0,0,0,0,0,0,1 },    // 0
 { 1,0,0,1,1,1,1 },    // 1
 { 0,0,1,0,0,1,0 },    // 2
 { 0,0,0,0,1,1,0 },    // 3
 { 1,0,0,1,1,0,0 },    // 4
 { 0,1,0,0,1,0,0 },    // 5
 { 0,1,0,0,0,0,0 },    // 6
 { 0,0,0,1,1,1,1 },    // 7
 { 0,0,0,0,0,0,0 },    // 8
 { 0,0,0,1,1,0,0 },     // 9
 { 1,1,1,1,1,1,0 }      // -

};

// 자리수,  제어 핀 아두이노와 초기화
int digit_pin[3][4] = {
                       {12,2,3,4},
                       {1,13,14,15},
                       {16,17,18,19}};
int segment_pin[3][8] = {
                         {5,6,7,8,9,10,11},
                         {20,21,22,23,24,25,26},
                         {27,28,29,30,31,32,33}
};



void setup()
{
  Serial.begin(9600); //시리얼 통신을 하기위한 통신속도설정

  for(int i=0;i<3;i++){ // 자리수 1~4핀 출력모드로 세팅
    for(int j=0;j<4;j++){
      pinMode(digit_pin[i][j],OUTPUT);
    }
 };
  for(int i=0;i<3;i++){ // 세그먼트 1~8핀 출력모드로 세팅
    for(int j=0;j<8;j++){
      pinMode(segment_pin[i][j],OUTPUT);
    }
  };
}


void loop()
{

 data = Serial.read();
 segmentPlay(data);
}




void segmentPlay(String data){

   String a = data.substring(0,1);
   String c = data.substring(1,4);
   int b = c.toInt();
   int x = 0;
   
   int b1 = abs((b / 100) % 10);
   int c1 = abs((b / 10) % 10);
   int d1 = abs((b / 1) % 10);

   if(b < 0){
    digitalWrite(digit_pin[x][0], HIGH);
    for (int i=0; i < 7; i++)
     {
     digitalWrite(segment_pin[x][i], num[10][i]);
     }
     delay(5); // 잔상이 남아야 하므로 지연시간  
   } else {
    show_num(0,1,x);
   }
   show_num(b1,2,x);
   show_num(c1,3,x);
   show_num(d1,4,x);
}

void show_num(int number, int digit, int x) // 사용자 정의 함수 show_num 정의
{
 // 4자리 중 해당하는 자릿수의 선택 핀만 LOW로 설정
 if(digit == 1){
  digitalWrite(digit_pin[x][0],HIGH);
  digitalWrite(digit_pin[x][1],LOW);
  digitalWrite(digit_pin[x][2],LOW);
  digitalWrite(digit_pin[x][3],LOW);
 }else if(digit==2){
  digitalWrite(digit_pin[x][1],HIGH);
  digitalWrite(digit_pin[x][0],LOW);
  digitalWrite(digit_pin[x][2],LOW);
  digitalWrite(digit_pin[x][3],LOW);
 }else if(digit==3){
  digitalWrite(digit_pin[x][2],HIGH);
  digitalWrite(digit_pin[x][0],LOW);
  digitalWrite(digit_pin[x][1],LOW);
  digitalWrite(digit_pin[x][3],LOW);
 }else if(digit==4){
  digitalWrite(digit_pin[x][3],HIGH);
  digitalWrite(digit_pin[x][0],LOW);
  digitalWrite(digit_pin[x][1],LOW);
  digitalWrite(digit_pin[x][2],LOW);
 }
 // 세그먼트에서 숫자 출력
 // a,b,c,d,e,f,g,dp 8개의 세그먼트를 배열에 맞춰서 on/off
 for (int i=0; i < 7; i++)
 {
  digitalWrite(segment_pin[x][i], num[number][i]);
 }
 delay(5); // 잔상이 남아야 하므로 지연시간  
}
