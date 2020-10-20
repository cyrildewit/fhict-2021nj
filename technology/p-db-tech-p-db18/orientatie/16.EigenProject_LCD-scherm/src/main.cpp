#include <Arduino.h>
#include <LiquidCrystal.h>

const int rs = 12, en = 11, d4 = 4, d5 = 5, d6 = 6, d7 = 7;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);
int contrast = 0;

void setup()
{
  Serial.begin(9600);
  analogWrite(8, contrast);
  lcd.begin(16, 2);
}
void loop()
{
  lcd.setCursor(0, 0);
  lcd.print("hello, world!");
  lcd.setCursor(0, 1);
  lcd.print(millis() / 1000);
  // for (; contrast < 255; contrast++)
  // {
  //   Serial.println(contrast);
  //   delay(500);
  // }
  // delay(5000);
  // lcd.clear();
}
  // // lcd.setCursor(0, 0);
  // // lcd.print("dhruvansh");
  // // lcd.setCursor(0, 1);
  // // lcd.print("kumar");
  // // // delay(750);

  // // put your main code here, to run repeatedly:
  // lcd.clear();                                                       // clear display
  // lcd.print("Hello");                                                // writes to line 0, position 0
  // delay(5000);                                                       // show hello for 5 seconds
  // lcd.clear();                                                       // clear display
  // lcd.print("The quick brown fox jump over the lazy dog  1234567890"); // writes to line 0, starting position 0 uses most ASCII printable characters and may not write all of them on LCD or overwrite some
  // delay(5000); // show it for 5 seconds

// */

// // include the library code:
// #include <Arduino.h>
// #include <LiquidCrystal.h>

// // initialize the library by associating any needed LCD interface pin
// // with the arduino pin number it is connected to
// const int rs = 7, en = 6, d4 = 5, d5 = 4, d6 = 3, d7 = 2;
// LiquidCrystal lcd(rs, en, d4, d5, d6, d7);

// void setup()
// {
//   // set up the LCD's number of columns and rows:
//   lcd.begin(16, 2);
//   // Print a message to the LCD.
//   lcd.print("hello, world!");
// }

// void loop()
// {
//   // // set the cursor to column 0, line 1
//   // // (note: line 1 is the second row, since counting begins with 0):
//   // lcd.setCursor(0, 1);
//   // // // print the number of seconds since reset:
//   // lcd.print(millis() / 1000);

//   lcd.print("hello, world!");
// }
