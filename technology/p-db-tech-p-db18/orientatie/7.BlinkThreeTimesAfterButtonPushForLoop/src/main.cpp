#include <Arduino.h>

const int redLightPin = 2;
const int greenLightPin = 3;
const int blueLightPin = 4;
const int buttonBlinkPin = 5;

int buttonBlinkState = LOW;
int lastButtonBlinkState = LOW;

unsigned long timeNow = 0;

class RgbColor
{
public:
  int red = 0, green = 0, blue = 0;

  RgbColor(int redValue = 0, int greenValue = 0, int blueValue = 0)
  {
    red = redValue;
    green = greenValue;
    blue = blueValue;
  }
};

const RgbColor colorOn = RgbColor(255, 0, 0);
const RgbColor colorOff = RgbColor(0, 0, 0);

void apply_RGB_color(RgbColor color)
{
  analogWrite(redLightPin, color.red);
  analogWrite(greenLightPin, color.green);
  analogWrite(blueLightPin, color.blue);
}

void setup()
{
  pinMode(redLightPin, OUTPUT);
  pinMode(greenLightPin, OUTPUT);
  pinMode(blueLightPin, OUTPUT);
  pinMode(buttonBlinkPin, INPUT);

  Serial.begin(9600);
}

void loop()
{
  timeNow = millis();
  buttonBlinkState = digitalRead(buttonBlinkPin);

  if (buttonBlinkState != lastButtonBlinkState)
  {
    if (buttonBlinkState == HIGH)
    {
      for (int i = 0; i < 3; i++) {
        apply_RGB_color(colorOn);
        delay(1000);
        apply_RGB_color(colorOff);
        delay(1000);
      }
    }

    while (millis() < timeNow + 50)
    {
      //
    }
  }

  lastButtonBlinkState = buttonBlinkState;
}
