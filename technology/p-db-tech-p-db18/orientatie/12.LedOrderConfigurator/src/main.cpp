const int ledPins[4] = {2, 3, 4, 9};
const int buttonPins[4] = {5, 6, 7, 8};

const int lengthOfPairs = sizeof(ledPins)/sizeof(ledPins[0]);

int buttonStates[4] = {LOW, LOW, LOW, LOW};
int lastButtonStates[4] = {LOW, LOW, LOW, LOW};

// Current created LED sequence
// index => LED index (LED pin can be obtained from mappedLeds)
int ledSequence[4] = {-1, -1, -1, -1};
// Current index of led sequence that can be binded to a LED index
int currentIndex = 0;

unsigned long previousMillis = 0;

void setup()
{
  for (int i = 0; i < lengthOfPairs; i++) {
  	pinMode(ledPins[i], OUTPUT);
    pinMode(buttonPins[i], INPUT);
  }

  Serial.begin(9600);
}

void addLedToSequence(int ledIndex)
{
  ledSequence[currentIndex] = ledIndex;

  currentIndex++;
}

void digitalReadButtons()
{
  for (int i = 0; i < lengthOfPairs; i++) {
    lastButtonStates[i] = digitalRead(buttonPins[i]);
  }
}

void updateLastButtonStates()
{
  for (int i = 0; i < lengthOfPairs; i++) {
    buttonStates[i] = lastButtonStates[i];
  }
}

void resetLedSequence()
{
  currentIndex = 0;
  for (int i =0; i < lengthOfPairs; i++) {
    ledSequence[i] = -1;
  }
}

void loop()
{
  unsigned long currentMillis = millis();

  digitalReadButtons();

  if (currentMillis - previousMillis >= 50 ) {
    for (int i = 0; i < lengthOfPairs; i++) {
      if (buttonStates[i] != lastButtonStates[i]) {
        if (buttonStates[i] == HIGH) {
          addLedToSequence(i);
        }
      }
    }
  }

  if (currentIndex >= lengthOfPairs) {
    for (int i = 0; i < lengthOfPairs; i++) {
      int ledIndex = ledSequence[i];
      digitalWrite(ledPins[ledIndex], HIGH);
      delay(1000);
      digitalWrite(ledPins[ledIndex], LOW);
      delay(1000);
    }

    resetLedSequence();
  }

  updateLastButtonStates();
}





//#include <Arduino.h>

//void setup() {
  // put your setup code here, to run once:
//  pinMode();
//}

//void loop() {
  // put your main code here, to run repeatedly:
//}

// const int ledOne = 2;
// const int ledTwo = 3;
// const int ledThree = 4;

// const int buttonOne = 5;
// const int buttonTwo = 6;
// const int buttonThree = 7;

// int buttonOneState = LOW;
// int lastButtonOneState = LOW;
// int buttonTwoState = LOW;
// int lastButtonTwoState = LOW;
// int buttonThreeState = LOW;
// int lastButtonThreeState = LOW;

// // Available LEDs: index => ledPin
// int mappedLeds[3] = {ledOne, ledTwo, ledThree};

// // Current created LED sequence
// // index => LED index (LED pin can be obtained from mappedLeds)
// int ledSequence[3] = {-1, -1, -1};
// // Current index of led sequence that can be binded to a LED index
// int currentIndex = 0;

// void setup()
// {
//   pinMode(ledOne, OUTPUT);
//   pinMode(ledTwo, OUTPUT);
//   pinMode(ledThree, OUTPUT);

//   pinMode(buttonOne, INPUT);
//   pinMode(buttonTwo, INPUT);
//   pinMode(buttonThree, INPUT);

//   Serial.begin(9600);
// }

// void addLedToSequence(int ledNumber)
// {
//   ledSequence[currentIndex] = ledNumber;

//   currentIndex++;
// }

// void loop()
// {
//   buttonOneState = digitalRead(buttonOne);
//   buttonTwoState = digitalRead(buttonTwo);
//   buttonThreeState = digitalRead(buttonThree);

//   if (buttonOneState != lastButtonOneState)
//   {
//     if (buttonOneState == HIGH)
//     {
//       Serial.println("Button one pressed!");
//       addLedToSequence(0);
//       Serial.println(ledSequence[0]);
//       Serial.println(ledSequence[1]);
//       Serial.println(ledSequence[2]);
//     }

//     delay(50);
//   }

//   if (buttonTwoState != lastButtonTwoState)
//   {
//     if (buttonTwoState == HIGH)
//     {
//       Serial.println("Button two pressed!");
//       addLedToSequence(1);
//       Serial.println(ledSequence[0]);
//       Serial.println(ledSequence[1]);
//       Serial.println(ledSequence[2]);
//     }

//     delay(50);
//   }

//   if (buttonThreeState != lastButtonThreeState)
//   {
//     if (buttonThreeState == HIGH)
//     {
//       Serial.println("Button three pressed!");
//       addLedToSequence(2);

//       // Serial.println(currentIndex);
//       Serial.println(ledSequence[0]);
//       Serial.println(ledSequence[1]);
//       Serial.println(ledSequence[2]);
//     }

//     delay(50);
//   }

//   if (currentIndex >= 3)
//   {
//     for (int i = 0; i < 3; i++)
//     {
//       int ledNumber = ledSequence[i];
//       digitalWrite(mappedLeds[ledNumber], HIGH);
//       delay(1000);
//       digitalWrite(mappedLeds[ledNumber], LOW);
//       delay(1000);
//     }

//     currentIndex = 0;
//     ledSequence[0] = -1;
//     ledSequence[1] = -1;
//     ledSequence[2] = -1;
//   }

//   lastButtonOneState = buttonOneState;
//   lastButtonTwoState = buttonTwoState;
//   lastButtonThreeState = buttonThreeState;
// }
