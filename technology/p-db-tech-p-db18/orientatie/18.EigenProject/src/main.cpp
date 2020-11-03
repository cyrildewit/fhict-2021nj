#include <Arduino.h>
#include "DHT.h"
#include <LiquidCrystal.h>

#define DHT_PIN 8
#define DHT_TYPE DHT11

const int RS = 12, EN = 11, D4 = 4, D5 = 5, D6 = 6, D7 = 7;
const int LCD_WIDTH = 16, LCD_HEIGHT = 2;

DHT dht(DHT_PIN, DHT_TYPE);
LiquidCrystal lcd(RS, EN, D4, D5, D6, D7);

unsigned long startMillis = 0;
unsigned long currentMillis = 0;

float humidity = 0;
float temperature = 0;

/**
 * Retrieve and store the current sensor data.
 *
 * @return void
 */
void retrieveSensorData()
{
  humidity = dht.readHumidity();
  temperature = dht.readTemperature();
}

/**
 * Check if the the stored sensor data is valid.
 *
 * @return bool Returns true if everthing is okey.
 */
bool isSensorDataValid()
{
  return !(isnan(humidity) || isnan(temperature));
}

void printSensorData()
{
  lcd.clear();

  lcd.setCursor(0, 0);
  lcd.print("Temp = ");
  lcd.print((long)temperature, DEC);
  lcd.print("C");

  lcd.setCursor(0, 1);
  lcd.print("Humidity = ");
  lcd.print((long)humidity, DEC);
  lcd.print("%");

  Serial.println("Temp = ");
  Serial.println(temperature);

  Serial.println("Humidity = ");
  Serial.println(humidity);
}

void setup()
{
  Serial.begin(9600);

  dht.begin();
  lcd.begin(LCD_WIDTH, LCD_HEIGHT);

  startMillis = millis();
}

void loop()
{
  currentMillis = millis();

  // Update sensor data every second
  if (currentMillis - startMillis >= 1000)
  {
    retrieveSensorData();

    if (isSensorDataValid())
    {
      printSensorData();
    }
    else
    {
      lcd.clear();

      Serial.println("Failed to read data from DHT sensor!");
    }

    startMillis = currentMillis;
  }
}
