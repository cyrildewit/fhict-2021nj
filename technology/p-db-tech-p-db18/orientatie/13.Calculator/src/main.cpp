#include <Arduino.h>

int number = 0;

void setup() {
  Serial.begin(9600);
  Serial.println("Vul een getal ");
}

void loop() {
  if (Serial.available() > 0)
  {
    number = Serial.parseInt();

    Serial.print("Result: ");
    Serial.println(number * number, DEC);
  }
}
