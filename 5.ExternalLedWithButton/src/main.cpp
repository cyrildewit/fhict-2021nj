#include <Arduino.h>

const int buttonPin = 2;
const int ledPin = 13;

int buttonPushCounter = 0;
int buttonState = 0;
int lastButtonState = 0;

unsigned long timeNow = 0;

void setup() {
  Serial.begin(9600);

  pinMode(buttonPin, INPUT);
  pinMode(ledPin, OUTPUT);
}

void loop() {
  timeNow = millis();
  buttonState = digitalRead(buttonPin);

  if (buttonState != lastButtonState) {
    if (buttonState == HIGH) {
      buttonPushCounter++;
      // Serial.println("on");
      // Serial.print("number of button pushes: ");
      // Serial.println(buttonPushCounter);
    } else {
      // Serial.println("off");
    }

    while (millis() < timeNow + 50)
    {
      //
    }
  }

  lastButtonState = buttonState;

  // In plaats van de if else statement had er ook het volgende kunnen staan: `digitalWrite(ledPin, buttonState);`.
  if (buttonPushCounter != 0 && buttonPushCounter % 4 == 0) {
    digitalWrite(ledPin, HIGH);
  } else {
    digitalWrite(ledPin, LOW);
  }
}

// void loop() {
//   buttonState = digitalRead(buttonPin);

//   digitalWrite(ledPin, buttonState);

//   if (buttonState == HIGH) {
//     Serial.println("Button pressed!");
//   }

//   delay(100);
// }
