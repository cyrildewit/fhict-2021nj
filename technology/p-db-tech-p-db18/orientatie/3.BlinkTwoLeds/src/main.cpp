#include <Arduino.h>

int redLed = 13;
int greenLed = 12;

void setup() {
  pinMode(redLed, OUTPUT);
  pinMode(greenLed, OUTPUT);
}

void loop() {
  digitalWrite(redLed, HIGH);
  digitalWrite(greenLed, LOW);
  delay(500);

  digitalWrite(redLed, LOW);
  digitalWrite(greenLed, HIGH);
  delay(500);
}
