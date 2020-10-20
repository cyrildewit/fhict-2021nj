#include <Arduino.h>

const int redLightPin = 2;
const int greenLightPin = 3;
const int blueLightPin = 4;
const int buttonPin = 5;

int buttonState = LOW;
int lastButtonState = LOW;

unsigned long timeNow = 0;

int buttonClickCount = 0;

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

void loop()
{
  timeNow = millis();
  buttonState = digitalRead(buttonPin);

  if (buttonState != lastButtonState)
  {
    if (buttonState == HIGH)
    {
      buttonClickCount++;

      if (buttonClickCount % 3 == 0)
      {
        ledIsOn = !ledIsOn;
      }
    }

    while (millis() < timeNow + 50)
    {
      //
    }
  }

  if (ledIsOn)
  {
      apply_RGB_color(colorOn);

      // Serial.println("-----------");
      // Serial.println("RED: ");
      // Serial.println(colorOn.red);
      // Serial.println("GREEN:");
      // Serial.println(colorOn.green);
      // Serial.println("BLUE:");
      // Serial.println(colorOn.blue);
      // delay(1000);
  }
  else
  {
    apply_RGB_color(colorOff);
  }

  lastButtonState = buttonState;
}
