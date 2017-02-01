int pwm = 5;
int pwm2 = 6;

void setup() {
  pinMode(pwm, OUTPUT);
  analogWrite(pwm, 255);

  pinMode(pwm2, OUTPUT);
  analogWrite(pwm2, 255);

  Serial.begin(115200);
}

void loop() {
  if(Serial.available() > 1){
    analogWrite(pwm, Serial.read());
    analogWrite(pwm2, Serial.read());
  }
}
