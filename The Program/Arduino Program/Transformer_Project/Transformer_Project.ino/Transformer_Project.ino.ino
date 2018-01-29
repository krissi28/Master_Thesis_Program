/*Masters Project
 * Kristjan G. Birgisson
*/
int SW1 = 2; // Switch 1 in relay 24V output for 15W bulb connected normally open
int SW2 = 3; // Switch 2 in relay 24V output for 40W bulb connected normally open
int SW3 = 4; // Switch 3 in relay 24V output for 60W bulb connected normally open
int SW4 = 5; // Switch 4 in relay 220V output to the transformer connected normally closed
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
// *********** Set the pin connected to Relay as outputs ******* 
pinMode(SW1, OUTPUT);
pinMode(SW2, OUTPUT);
pinMode(SW3, OUTPUT);
pinMode(SW4, OUTPUT);
}



void loop() {
 //Serial.write("Connected to Arduino");// Check connection from C# to Arduino
 char data = Serial.read();
 Serial.print(data);
 delay(500);
 }


