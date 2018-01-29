/*Masters Project
 * Kristjan G. Birgisson
*/
long randNum;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
randomSeed(analogRead(0)); // not connected pin from arduino 
}

void loop() {
  Transformer_Primary();
  Transformer_Secondary();
  // put your main code here, to run repeatedly: 
 /* float MaxNum, MinNum;
  MaxNum = 100.2;
  MinNum = 50.1;
 // float RandNum  = RandomNumMaker(MinNum,MaxNum);
 // delay(1000);
 //Serial.println(RandNum);
 */
 }
///***************  For Testing of Code only ***********************  ///
// Random Num maker
float RandomNumMaker( float min, float max)
{ 
     // Makes the random number 
     float randNum = random(min,max);
     return randNum;
}

void Transformer_Primary()
{
  float VoltageMeas,AmpereMeas,V,I,RandVMin;
  float RandVMax,RandIMin,RandIMax;
  VoltageMeas = 220.;
  AmpereMeas = 10.;
  RandVMin = VoltageMeas - 5.;
  RandVMax = VoltageMeas + 1.5;
  RandIMin = AmpereMeas -  2.;
  RandIMax = AmpereMeas +  1.;
  V = RandomNumMaker(RandVMin,RandVMax);
  I = RandomNumMaker(RandIMin,RandIMax);
  Serial.println("Primary Measurements");
  Serial.print("Volt: ");
  Serial.print(V);
  Serial.print('\n');
  Serial.print("Amp: ");
  Serial.print(I);
  Serial.print('\n');
}

void Transformer_Secondary()
{
  float VoltageMeas,AmpereMeas,V,I,RandVMin;
  float RandVMax,RandIMin,RandIMax;
  VoltageMeas = 24.;
  AmpereMeas = 8.;
  RandVMin = VoltageMeas - 3.;
  RandVMax = VoltageMeas + 1.5;
  RandIMin = AmpereMeas -  2.;
  RandIMax = AmpereMeas +  1.;
  V = RandomNumMaker(RandVMin,RandVMax);
  I = RandomNumMaker(RandIMin,RandIMax);
  Serial.println("Secondary Measurements");
  Serial.print("Volt: ");
  Serial.print(V);
  Serial.print('\n');
  Serial.print("Amp: ");
  Serial.print(I);
  Serial.print('\n');
delay(2000);  
}
///****************************************************************  ///

