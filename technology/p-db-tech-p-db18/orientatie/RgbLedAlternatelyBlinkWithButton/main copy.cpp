#include <Arduino.h>

const int redLightPin = 2;
const int greenLightPin = 3;
const int blueLightPin = 4;
const int buttonNextColorPin = 5;
const int buttonChangeDirectionPin = 6;

int buttonNextColorState = 0;
int lastButtonNextColorState = 0;

int buttonChangeDirectionState = 0;
int lastButtonChangeDirectionState = 0;

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

RgbColor colors[4] = {
    RgbColor(255, 0, 0),
    RgbColor(0, 255, 0),
    RgbColor(0, 0, 255),
    RgbColor(255, 255, 255)
    // RgbColor(0, 255, 0),
    // RgbColor(0, 0, 255),
    // RgbColor(255, 255, 125),
    // RgbColor(255, 0, 255),
    // RgbColor(0, 255, 255),
    // RgbColor(255, 255, 0),
    // RgbColor(255, 255, 255),
};

void setup()
{
  pinMode(redLightPin, OUTPUT);
  pinMode(greenLightPin, OUTPUT);
  pinMode(blueLightPin, OUTPUT);
  pinMode(buttonNextColorPin, INPUT);
  pinMode(buttonChangeDirectionPin, INPUT);

  Serial.begin(9600);
}

void apply_RGB_color(RgbColor color)
{
  analogWrite(redLightPin, color.red);
  analogWrite(greenLightPin, color.green);
  analogWrite(blueLightPin, color.blue);
}

int goToNextColorIndex()
{
  int lastIndex = (sizeof(colors) / sizeof(colors[0])) - 1;

  if (currentColorChangeDirectionIsDown)
  {
    currentColorIndex++;
  } else {
    currentColorIndex--;
  }

  if ((currentColorIndex == lastIndex + 1) || (currentColorIndex == -1))
  {
    currentColorIndex = 0;
  }

  return currentColorIndex;
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
      RgbColor c = colors[currentColorIndex];
      apply_RGB_color(c);

      Serial.println(currentColorIndex);

      goToNextColorIndex();
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
      // Serial.println(currentColorChangeDirectionIsDown);
    }

    while (millis() < timeNow + 50)
    {
      //
    }
  }

  lastButtonNextColorState = buttonNextColorState;
  lastButtonChangeDirectionState = buttonChangeDirectionState;
}
