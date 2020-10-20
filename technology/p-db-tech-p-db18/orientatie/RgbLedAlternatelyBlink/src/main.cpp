#include <Arduino.h>

const int redPin = 2;
const int greenPin = 3;
const int bluePin = 4;

void setup() {
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);
}

void RGB_color(int red_light_value, int green_light_value, int blue_light_value) {
  analogWrite(redPin, red_light_value);
  analogWrite(greenPin, green_light_value);
  analogWrite(bluePin, blue_light_value);
}

void loop() {
  delay(1000);
  RGB_color(0, 255, 0); // Green
  delay(1000);
  RGB_color(0, 0, 255); // Blue
  delay(1000);
  RGB_color(255, 255, 125); // Raspberry
  delay(1000);
  RGB_color(0, 255, 255); // Cyan
  delay(1000);
  RGB_color(255, 0, 255); // Magenta
  delay(1000);
  RGB_color(255, 255, 0); // Yellow
  delay(1000);
  RGB_color(255, 255, 255); // White
  delay(1000);
}
