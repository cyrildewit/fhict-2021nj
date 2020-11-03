#include <Arduino.h>

const int redLightPin = 5;
const int greenLightPin = 3;
const int blueLightPin = 6;
const int buttonPin = 8;

int buttonState = LOW;
int lastButtonState = LOW;

unsigned long timeNow = 0;

bool ledIsOn = false;

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
  pinMode(buttonPin, INPUT);

  Serial.begin(9600);
}

bool buttonRead(int buttonPin)
{
  buttonState = digitalRead(buttonPin);

  return (buttonState != lastButtonState) && buttonState == HIGH;
}

void waitFor(int miliseconds, long timeNow)
{
  while (millis() < timeNow + miliseconds)
  {
    //
  }
}

void loop()
{
  timeNow = millis();

  if (buttonRead(buttonPin)) {
    ledIsOn = !ledIsOn;

    waitFor(50, timeNow);
  }

  if (ledIsOn)
  {
    for (int i = 0; i < 255; i++) {
      analogWrite(redLightPin, i);
      waitFor(30, timeNow);
    }

    for (int i = 255; i > 0; i--)
    {
      analogWrite(redLightPin, i);
      waitFor(30, timeNow);
    }
  }
  else
  {
    apply_RGB_color(colorOff);
  }

  lastButtonState = buttonState;
}
