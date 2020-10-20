#include <Arduino.h>

const int buttonPin = 8;
const int ledPin = 3;

int buttonState = LOW;
int lastButtonState = LOW;

int counter = 0;

bool gameOver = false;

void setup() {
  pinMode(buttonPin, OUTPUT);
  pinMode(ledPin, OUTPUT);

  Serial.begin(9600);
}

void loop() {
  buttonState = digitalRead(buttonPin);

  if (buttonState != lastButtonState) {
    if (buttonState == HIGH) {
      Serial.println("button pressed!");

      // Stop counting after 5
      if (counter < 5) {
        counter++;
      }
    }

    delay(50);
  }

  if (counter == 5 && !gameOver)
  {
    Serial.println("Game Over");

    gameOver = true;
  }

  if (gameOver) {
    analogWrite(ledPin, 255);
  }

  lastButtonState = buttonState;
}

// #include <Arduino.h>

// const int buttonPin = 8;
// const int ledPin = 3;

// int buttonState = LOW;
// int lastButtonState = LOW;

// int counter = 0;

// bool gameOver = false;

// void setup()
// {
//   pinMode(buttonPin, OUTPUT);
//   pinMode(ledPin, OUTPUT);

//   Serial.begin(9600);
// }

// void loop()
// {
//   buttonState = digitalRead(buttonPin);

//   if (buttonState != lastButtonState)
//   {
//     if (buttonState == HIGH)
//     {
//       Serial.println("button pressed!");

//       // Stop counting after 5
//       if (counter < 5)
//       {
//         counter++;
//       }
//     }

//     delay(50);
//   }

//   if (counter == 5 && !gameOver)
//   {
//     Serial.println("Game Over");

//     gameOver = true;
//   }

//   if (gameOver)
//   {
//     analogWrite(ledPin, 255);
//   }

//   lastButtonState = buttonState;
// }
