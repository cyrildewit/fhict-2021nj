#include <Arduino.h>

const int redLightPin = 2;
const int greenLightPin = 3;
const int blueLightPin = 4;
const int buttonNextColorPin = 5;
const int buttonChangeDirectionPin = 6;

int buttonNextColorState = LOW;
int lastButtonNextColorState = LOW;

int buttonChangeDirectionState = LOW;
int lastButtonChangeDirectionState = LOW;

unsigned long timeNow = 0;

int currentColorIndex = 0;

bool currentColorChangeDirectionIsDown = true;

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

RgbColor colors[7] = {
    RgbColor(0, 255, 0),
    RgbColor(0, 0, 255),
    RgbColor(255, 255, 125),
    RgbColor(255, 0, 255),
    RgbColor(0, 255, 255),
    RgbColor(255, 255, 0),
    RgbColor(255, 255, 255)
};

void apply_RGB_color(RgbColor color)
{
  analogWrite(redLightPin, color.red);
  analogWrite(greenLightPin, color.green);
  analogWrite(blueLightPin, color.blue);
}

void applyCurrentColor()
{
  apply_RGB_color(colors[currentColorIndex]);
}

void setup()
{
  pinMode(redLightPin, OUTPUT);
  pinMode(greenLightPin, OUTPUT);
  pinMode(blueLightPin, OUTPUT);
  pinMode(buttonNextColorPin, INPUT);
  pinMode(buttonChangeDirectionPin, INPUT);

  applyCurrentColor();

  Serial.begin(9600);
}

void goToNextColor()
{
  int lastIndex = (sizeof(colors) / sizeof(colors[0])) - 1;

  if (currentColorChangeDirectionIsDown)
  {
    if (currentColorIndex + 1 > lastIndex) {
      currentColorIndex = 0;

    } else {
      currentColorIndex++;
    }
  }
  else
  {
    if (currentColorIndex - 1 < 0) {
      currentColorIndex = lastIndex;
    } else {
      currentColorIndex--;
    }
  }

  applyCurrentColor();
}

void loop()
{
  timeNow = millis();
  buttonNextColorState = digitalRead(buttonNextColorPin);
  buttonChangeDirectionState = digitalRead(buttonChangeDirectionPin);

  if (buttonNextColorState != lastButtonNextColorState)
  {
    if (buttonNextColorState == HIGH)
    {
      goToNextColor();
    }

    while (millis() < timeNow + 50)
    {
      //
    }
  }

  if (buttonChangeDirectionState != lastButtonChangeDirectionState)
  {
    if (buttonChangeDirectionState == HIGH)
    {
      currentColorChangeDirectionIsDown = !currentColorChangeDirectionIsDown;
    }

    while (millis() < timeNow + 50)
    {
      //
    }
  }

  lastButtonNextColorState = buttonNextColorState;
  lastButtonChangeDirectionState = buttonChangeDirectionState;
}
