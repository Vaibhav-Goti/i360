int dirpin = 3;
int pulpin = 4;
int enapin = 5;
String mystring;
int mtime = 30;
int t = 0;
void setup() {
  Serial.begin(9600);
  Serial.println("Write Direction (if Left = l, Right = r), Write Angle");
  Serial.println("You Write bellow Direction, Angle & Speed");
  pinMode(dirpin, OUTPUT);
  pinMode(pulpin, OUTPUT);
  pinMode(enapin, OUTPUT);
  digitalWrite(enapin, LOW);
}
void loop() {
  mystring = Serial.readString();
  String xval = getValue(mystring, ',', 0);
  String yval = getValue(mystring, ',', 1);
  String zval = getValue(mystring, ',', 2);
  if (xval == "l") {
    digitalWrite(dirpin, LOW);
    float s1 = yval.toFloat();
    t = zval.toInt();
    t = constrain(t, 1, 9970);
    mtime = (10000 - t);
    startrotation(s1);
  }
  if (xval == "r") {
    digitalWrite(dirpin, HIGH);
    float s1 = yval.toFloat();
    t = zval.toInt();
    t = constrain(t, 1, 9970);
    mtime = (10000 - t);
    startrotation(s1);
  }
}
String getValue(String data, char separator, float index) {
  int found = 0;
  int strIndex[] = { 0, -1 };
  int maxIndex = data.length() - 1;
  for (int i = 0; i <= maxIndex && found <= index; i++) {
    if (data.charAt(i) == separator || i == maxIndex) {
      found++;
      strIndex[0] = strIndex[1] + 1;
      strIndex[1] = (i == maxIndex) ? i + 1 : i;
    }
  }
  return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}
void startrotation(float s1) {
  for (float x = 0.0; x < (s1 / 0.1125); x++) {
    digitalWrite(pulpin, HIGH);
    delayMicroseconds(mtime);
    digitalWrite(pulpin, LOW);
    delayMicroseconds(mtime);
  }
}
Collapse


