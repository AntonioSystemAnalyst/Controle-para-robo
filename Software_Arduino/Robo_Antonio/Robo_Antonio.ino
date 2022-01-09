// ------------------------------------------------------------------------ Robo -- Bibliotecas
// --- Bibliotecas Auxiliares ---
#include <AFMotor.h>          //Inclui biblioteca AF Motor
#include <Servo.h>            //Inclui biblioteca para controle de Servos
// ------------------------------------------------------------------------ Musicas -- Definições
#define c 261
#define d 294
#define e 329
#define f 349
#define g 391
#define gS 415
#define a 440
#define aS 455
#define b 466
#define cH 523
#define cSH 554
#define dH 587
#define dSH 622
#define eH 659
#define fH 698
#define fSH 740
#define gH 784
#define gSH 830
#define aH 880

// ------------------------------------------------------------------------ Robo -- Ultrasonic
#define   echo        A5                 //Entrada para o pino de echo do sensor
#define   trig        A4                 //Saída para o pino de trigger do sensor
#define   serv        10                 //controle do Servo 1
// ------------------------------------------------------------------------ Robo -- Leds
#define   Ld3         A0                 //Lead3
#define   Ld2         A1                 //Lead2
#define   Ld1         A2                 //Lead1
// ------------------------------------------------------------------------ Robo -- Buzzer
#define Buzzer        A3                 //Buzzer
int speakerPin = A3;

// ------------------------------------------------------------------------ Robo --



// --- Protótipo das Funções Auxiliares ---
float measureDistance();                //Função para medir, calcular e retornar a distância em cm
void trigPulse();                       //Função que gera o pulso de trigger de 10µs
void decision();                        //Função para tomada de decisão. Qual melhor caminho?
void Observacao();                      //Função para observar e decidir.  
void robot_forward (unsigned int v);    //Função para movimentar robô para frente
void robot_backward(unsigned int v);    //Função para movimentar robô para trás
void robot_left (unsigned int v);       //Função para movimentar robô para esquerda
void robot_stop (unsigned int v);       //Função para parar o robô
void robot_right(unsigned int v);       //Função para movimentar robô para direita
void Inicio_Leds ();
void OBS_Leds ();
void ServorRadar_Test ();
void Robo_Normal ();
void descanco ();
void Medirrrrr ();

void Motor1(unsigned int v);
void Motor2(unsigned int v);
void Motor3(unsigned int v);
void Motor4(unsigned int v);

// --- Minhas funções
void ServorRadar1 ();                   //Função que movimenta o servo 1 

// --- Seleção dos Motores ---
AF_DCMotor motor1(1); //Seleção do Motor 1
AF_DCMotor motor2(2); //Seleção do Motor 2

AF_DCMotor motor3(3); //Seleção do Motor 3
AF_DCMotor motor4(4); //Seleção do Motor 4

// --- Variáveis Globais ---
unsigned int velocidade = 255;         //Armazena a velocidade dos motores (8 bits)
float dist_right;                      //Armazena a distância em centímetros da direita
float dist_left;                       //Armazena a distância em centímetros da esquerda
float dist_cm;                         //Armazena a distância em centímetros entre o robô e o obstáculo

int Danger = 0;                        //Verifica se há perigo em 180 graus;    1 - Perigo < 80 // 2 - Perigo > 80  - 0 Nenhum perigo - 3 Totalmente perigoso
int sound = 0;                         //Faz o robo cantar a cada putz
Servo servo1; // Objeto Servo 1
char AD = ' ';
void setup() {
  // put your setup code here, to run once:
  // 30/03/2019 - Robo Program
 
  Serial.begin(9600);
 
  pinMode(trig, OUTPUT);                      //Saída para o pulso de trigger
  pinMode(serv, OUTPUT);                      //Saída para o servo motor
  pinMode(echo, INPUT);                       //Entrada para o pulso de echo

   
  pinMode(Ld1, OUTPUT);                       //Saída para o led1
  pinMode(Ld2, OUTPUT);                       //Saída para o led2
  pinMode(Ld3, OUTPUT);                       //Saída para o led3

  pinMode(Buzzer, OUTPUT);                       //Saída para o led3

  servo1.attach(serv);                         //Objeto servo1 no pino de saída do servo
  digitalWrite(trig, LOW);                     //Pino de trigger inicia em low
  servo1.write(80);                            //Centraliza servo
  delay(500);
  Inicio_Leds ();
  velocidade = 255;                           //Inicia velocidade no valor máximo      
}

void loop() 
{
digitalWrite(Ld2, HIGH);
if (Serial.available())
    {
        char data = Serial.read();
        Serial.println(data);
        digitalWrite(Ld2, HIGH);
        switch (data)
        {
                case 'A':
                digitalWrite(Ld2, LOW);
                
                Inicio_Leds ();
                break;

                case 'B': 
                digitalWrite(Ld2, LOW);  
                OBS_Leds ();            
                break;    
                            
                case 'C':    
                digitalWrite(Ld2, LOW); 
                Motor1(velocidade);          
                break;  
               
                case 'D':   
                digitalWrite(Ld2, LOW); 
                Motor2(velocidade);            
                break;  
                
                case 'E':  
                digitalWrite(Ld2, LOW);
                Motor3(velocidade);              
                break;  

                case 'F':  
                digitalWrite(Ld2, LOW); 
                Motor4(velocidade);             
                break;

                case 'G':
                digitalWrite(Ld2, LOW);
                break;

                case 'H':  
                digitalWrite(Ld2, LOW); 
                Serial.println(AD);
                //Serial.clear; 
                Medirrrrr ();           
                break;    
                            
                case 'I':  
                digitalWrite(Ld2, LOW);             
                break;  
               
                case 'J':  
                digitalWrite(Ld2, LOW);             
                break;  
                
                case 'K': 
                digitalWrite(Ld2, LOW);
                march();      
                break;  

                case 'L':  
                digitalWrite(Ld2, LOW); 
                servo1.write(175);            
                break;  
               
                case 'M':  
                digitalWrite(Ld2, LOW);   
                servo1.write(80);             
                break;

                 case 'N':  
                digitalWrite(Ld2, LOW);  
                servo1.write(0);               
                break;  
        }
    }    
}
void Medirrrrr ()
{
  int i, distance;
  double Media = 0, Soma = 0;
  for (i = 0; i < 30; i++)
  {
        distance = measureDistance();
        Soma = Soma + distance;
  }
     Media = Soma / 30;
     Serial.println(Media);
     delay(1000);   
}
// ----------------------------------------------- //
// ----------------------------------------------- //
void descanco ()
{
      digitalWrite(Ld2, HIGH);
      delay(80);
      digitalWrite(Ld2, LOW);
      delay(80);
}

// ----------------------------------------------- //
// ----------------------------------------------- //

// --------------------------------------------------------------------------------- // Inteligencia
// --------------------------------------------------------------------------------- // Inteligencia
void Observacao()
{
  int i;
  float Soma = 0, Ax = 0, Media = 0;
  Serial.print ("\n");
  Serial.print (" ======================== ");
  Serial.print ("\n");
  Serial.print (" Observacao");
  Serial.print ("\n");
  Serial.print (" ======================== ");
  Serial.print ("\n");
  robot_stop(velocidade);
   OBS_Leds ();
  for (i=0; i < 300; i++)
  {
    Ax = measureDistance();
    Serial.print (" Medida: ");
    Serial.print (Ax);
    Serial.print ("\n");
    Soma = Soma + Ax;
  }
  Media = Soma / 300;
  Serial.print (" ======================== ");
  Serial.print ("\n");
  Serial.print (" Media: ");
  Serial.print (Media);
  Serial.print ("\n");
  Serial.print (" ======================== ");
  Serial.print ("\n");
  
  if(Media < 20) //distância menor que 20 cm?
  {          
     decision();
  }
 
}
void ServorRadar1 ()
{
   int i, cont1 = 0, cont2 = 0, Ax = 0;
   Serial.print (" ======================== ");
   Serial.print ("\n");
   Serial.print (" Radar 1");
   Serial.print ("\n");
   Serial.print (" ======================== ");
   Serial.print ("\n");
    for (i=0; i<175; i++) 
    {
      if (i%2 == 0)
      {
          digitalWrite(Ld1, HIGH);
          delay(80);
          digitalWrite(Ld1, LOW);
          delay(80);
      }
      if (i%35 == 0)
      {
        tone(Buzzer, 500);
        delay(200);
        noTone(Buzzer);
      }
      Ax =  measureDistance();
      if (Ax < 35 && i > 80)
      {
        cont1 = cont1 + 1;
      }
       if (Ax < 35 && i < 80)
      {
        cont2 = cont2 + 1;
      }
       Serial.print (" Medida: ");
       Serial.print (Ax);
       Serial.print ("\n");
       servo1.write(i);
      delay(50);
    }
    for (i=0; i<9; i++)
    {
      digitalWrite(Ld1, HIGH);
      digitalWrite(Ld2, HIGH);
      digitalWrite(Ld3, HIGH);
      delay(100);
      digitalWrite(Ld1, LOW);
      digitalWrite(Ld2, LOW);
      digitalWrite(Ld3, LOW);
      delay(100);
    }
    servo1.write(80);                        //Centraliza servo
    if (cont1 >= 15 && cont2 >= 15)
    {
      Danger = 3;
      digitalWrite(Ld3, HIGH);
      delay(80);
      digitalWrite(Ld3, LOW);
      delay(80);
    }
    else
    {
      if (cont1 >= 15 && cont2 == 0)
      {
        Danger = 2;
        digitalWrite(Ld2, HIGH);
        delay(80);
        digitalWrite(Ld2, LOW);
        delay(80);
      }
      else
      {
        if (cont2 >= 15 && cont1 == 0)
        {
           Danger = 1;
          digitalWrite(Ld1, HIGH);
          delay(80);
          digitalWrite(Ld1, LOW);
          delay(80);
        }
        else
        {
           Danger = 0;
        }
      }
    }
    Serial.print (" ======================== ");
    Serial.print ("\n");
    Serial.print (" Resultado: ");
    Serial.print ("\n");
    Serial.print (" Cont1: ");
    Serial.print (cont1);
    Serial.print ("\n");
    Serial.print (" Cont2: ");
    Serial.print (cont2);
    Serial.print ("\n");
    Serial.print (" Danger: ");
    Serial.print (Danger);
    Serial.print ("\n");
    Serial.print (" ======================== ");
}
void ServorRadar_Test ()
{
   int i;
   
   servo1.write(0);                           //Move sensor para direita através do servo
   delay(1000);                                //Aguarda 500ms   
   servo1.write(175);                         //Move sensor para esquerda através do servo
   delay(1000);  
   servo1.write(80);
   delay(1000);    
   
    for (i=0; i<175; i++) 
    {
      if (i%2 == 0)
      {
        digitalWrite(Ld1, HIGH);
        delay(80);
        digitalWrite(Ld1, LOW);
        delay(80);
        servo1.write(i);
        delay(10); 
      }
       if (i%3 == 0)
      {
        digitalWrite(Ld3, HIGH);
        delay(80);
        digitalWrite(Ld3, LOW);
        delay(80);
        servo1.write(i);
        delay(10);
      }
    }
     servo1.write(80); 
}
void decision()                              //Compara as distâncias e decide qual melhor caminho a seguir
{
   Serial.print ("\n");
   Serial.print (" ======================== ");
   Serial.print ("\n");
   Serial.print (" Decisão ");
   Serial.print ("\n");
   Serial.print (" ======================== ");
   Serial.print ("\n");
   robot_stop(velocidade);                    //Para o robô
   delay(500);                                //Aguarda 500ms
   servo1.write(0);                           //Move sensor para direita através do servo
   delay(500);                                //Aguarda 500ms
   dist_right = measureDistance();            //Mede distância e armazena em dist_right
   Serial.print (" Direita: ");
   Serial.print (dist_right);
   Serial.print ("\n");
   delay(2000);                               //Aguarda 2000ms
   servo1.write(175);                         //Move sensor para esquerda através do servo
   delay(500);                                //Aguarda 500ms
   dist_left = measureDistance();             //Mede distância e armazena em dis_left
   Serial.print (" Esquerda: ");
   Serial.print (dist_left);
   Serial.print ("\n");
   delay(2000);                               //Aguarda 2000ms
   servo1.write(80);                          //Centraliza servo
   delay(500);
   if(dist_right > dist_left)                 //Distância da direita maior que da esquerda?
   {                                          //Sim...
      robot_backward(velocidade);             //Move o robô para trás
      delay(600);                             //Por 600ms
      robot_right(velocidade);                //Move o robô para direita
      delay(2000);                            //Por 2000ms
      robot_forward(velocidade);              //Move o robô para frente
   } //end if
   else                                       //Não...
   {
    robot_backward(velocidade);               //Move o robô para trás
      delay(600);                             //Por 600ms
      robot_left(velocidade);                 //Move o robô para esquerda
      delay(2000);                            //Por 2000ms
      robot_forward(velocidade);              //Move o robô para frente
   } //end else
   Serial.print (" ======================== ");
} //end decision
// --------------------------------------------------------------------------------- // Leds 
// --------------------------------------------------------------------------------- // Leds
void Inicio_Leds ()
{
   int i;
    digitalWrite ( Ld1, HIGH);
    delay(1000);
    digitalWrite ( Ld2, HIGH);
    delay(1000);
    digitalWrite ( Ld3, HIGH); 
    delay(1000);
    tone(Buzzer, 500);
    delay(1000);
    noTone(Buzzer);
    digitalWrite ( Ld1, LOW);
    digitalWrite ( Ld2, LOW);
    digitalWrite ( Ld3, LOW);  
   for (i=0; i <20; i++)
   {
      digitalWrite ( Ld1, HIGH);
      delay(100);
      digitalWrite ( Ld1, LOW);
      digitalWrite ( Ld2, HIGH);
      delay(100);
      digitalWrite ( Ld2, LOW);
      digitalWrite ( Ld3, HIGH);
      delay(100);
      digitalWrite ( Ld3, LOW);
   }
    digitalWrite ( Ld1, LOW);
    digitalWrite ( Ld2, LOW);
    digitalWrite ( Ld3, LOW);  
}
// --------------------------------------------------------------------------------- // Leds 
// --------------------------------------------------------------------------------- // Leds
void OBS_Leds ()
{
   int i; 
   for (i=0; i <20; i++)
   {
      digitalWrite ( Ld1, HIGH);
      digitalWrite ( Ld2, HIGH);
      digitalWrite ( Ld3, HIGH);
      delay(100);
      if (i%5 == 0)
      {
        tone(Buzzer, 500);
        delay(200);
        noTone(Buzzer);
      }
      digitalWrite ( Ld1, LOW);
      digitalWrite ( Ld2, LOW);
      digitalWrite ( Ld3, LOW);
      delay(100);  
   }
    digitalWrite ( Ld1, LOW);
    digitalWrite ( Ld2, LOW);
    digitalWrite ( Ld3, LOW);  
}
// --------------------------------------------------------------------------------- // Ultrasonic 
// --------------------------------------------------------------------------------- // Ultrasonic 
float measureDistance()                       //Função que retorna a distância em centímetros
{
  float pulse;                                //Armazena o valor de tempo em µs que o pino echo fica em nível alto
  trigPulse();                                //Envia pulso de 10µs para o pino de trigger do sensor
  pulse = pulseIn(echo, HIGH);                //Mede o tempo em que echo fica em nível alto e armazena na variável pulse
  return (pulse/58.82);                       //Calcula distância em centímetros e retorna o valor
} //end measureDistante

void trigPulse()                             //Função para gerar o pulso de trigger para o sensor HC-SR04
{
   digitalWrite(trig,HIGH);                  //Saída de trigger em nível alto
   delayMicroseconds(10);                    //Por 10µs ...
   digitalWrite(trig,LOW);                   //Saída de trigger volta a nível baixo
} //end trigPulse
// --------------------------------------------------------------------------------- // Motores 
// --------------------------------------------------------------------------------- // Motores 
void robot_forward(unsigned int v)
{
     motor1.setSpeed(v);
     motor1.run(FORWARD);
     motor2.setSpeed(v);
     motor2.run(FORWARD);
     motor3.setSpeed(v);
     motor3.run(FORWARD);
     motor4.setSpeed(v);
     motor4.run(FORWARD);
} //end robot forward

void robot_backward(unsigned int v)
{
     motor1.setSpeed(v);
     motor1.run(BACKWARD);
     motor2.setSpeed(v);
     motor2.run(BACKWARD);
     motor3.setSpeed(v);
     motor3.run(BACKWARD);
     motor4.setSpeed(v);
     motor4.run(BACKWARD);
} //end robot backward

void robot_left(unsigned int v)
{
     motor1.setSpeed(v);
     motor1.run(FORWARD);
     motor2.setSpeed(v);
     motor2.run(FORWARD);
     motor3.setSpeed(v);
     motor3.run(BACKWARD);
     motor4.setSpeed(v);
     motor4.run(BACKWARD);
} //end robot left

void robot_right(unsigned int v)
{
     motor1.setSpeed(v);
     motor1.run(BACKWARD);
     motor2.setSpeed(v);
     motor2.run(BACKWARD);
     motor3.setSpeed(v);
     motor3.run(FORWARD);
     motor4.setSpeed(v);
     motor4.run(FORWARD);
} //end robot right

void robot_stop(unsigned int v)
{
     motor1.setSpeed(v);
     motor1.run(RELEASE);
     motor2.setSpeed(v);
     motor2.run(RELEASE);
     motor3.setSpeed(v);
     motor3.run(RELEASE);
     motor4.setSpeed(v);
     motor4.run(RELEASE);
} //end robot stop
// ----------------------------------------------------- //
// ----------------------------------------------------- //
void Motor1(unsigned int v)
{
     motor1.setSpeed(v);
     motor1.run(FORWARD);
     delay (10000);
      motor1.run(RELEASE);
}
void Motor2(unsigned int v)
{
     motor2.setSpeed(v);
     motor2.run(FORWARD);
     delay (10000);
      motor2.run(RELEASE);
}
void Motor3(unsigned int v)
{
     motor3.setSpeed(v);
     motor3.run(FORWARD);
     delay (10000);
      motor3.run(RELEASE);
}
void Motor4(unsigned int v)
{
     motor4.setSpeed(v);
     motor4.run(FORWARD);
     delay (10000);
      motor4.run(RELEASE);
}

// ----------------------------------------------------- //
// ----------------------------------------------------- //
// --------------------------------------------------------------------------------- // Musicas
// --------------------------------------------------------------------------------- // Musicas
void beep (unsigned char speakerPin, int frequencyInHertz, long timeInMilliseconds)
{ 
    digitalWrite(Ld1, HIGH);  
    digitalWrite(Ld2, HIGH);  
    digitalWrite(Ld3, HIGH);   
    //use led to visualize the notes being played
    
    int x;   
    long delayAmount = (long)(1000000/frequencyInHertz);
    long loopTime = (long)((timeInMilliseconds*1000)/(delayAmount*2));
    for (x=0;x<loopTime;x++)   
    {    
        digitalWrite(speakerPin,HIGH);
        delayMicroseconds(delayAmount);
        digitalWrite(speakerPin,LOW);
        delayMicroseconds(delayAmount);
    }    
    
    digitalWrite(Ld1, LOW);
    digitalWrite(Ld2, LOW);
    digitalWrite(Ld3, LOW); 
    
    delay(100);
}    
void Robo_Normal ()
{
  sound = sound + 1;
     if (sound == 500)
     {
      robot_stop(velocidade); //Para o robô
      march();
      ServorRadar1 ();     
     }
     else
     {
      if (sound == 1000)
      {
        robot_stop(velocidade); //Para o robô
        sound = 0;
        ServorRadar1 ();     
      }
     }
     robot_forward(velocidade);
     delay(80);
     dist_cm = measureDistance();
     Serial.print ("\n");
     Serial.print (" ======================== ");
     Serial.print ("\n");
     Serial.print (" Main - Program");
     Serial.print ("\n");
     Serial.print (" ======================== ");
     Serial.print ("\n");
     Serial.print (" Distancia: ");
     Serial.print (dist_cm);
     Serial.print ("\n");
     Serial.print ("Sound: ");
     Serial.print (sound);
     Serial.print ("\n");
     Serial.print (" ======================== ");
     Serial.print ("\n");
     if(dist_cm < 20) //distância menor que 20 cm?
     {
         Observacao();          
     }                      
}
void march()
{    
    beep(speakerPin, a, 500); 
    beep(speakerPin, a, 500);     
    beep(speakerPin, a, 500); 
    beep(speakerPin, f, 350); 
    beep(speakerPin, cH, 150);
    
    beep(speakerPin, a, 500);
    beep(speakerPin, f, 350);
    beep(speakerPin, cH, 150);
    beep(speakerPin, a, 1000);
    //first bit
    
    beep(speakerPin, eH, 500);
    beep(speakerPin, eH, 500);
    beep(speakerPin, eH, 500);    
    beep(speakerPin, fH, 350); 
    beep(speakerPin, cH, 150);
    
    beep(speakerPin, gS, 500);
    beep(speakerPin, f, 350);
    beep(speakerPin, cH, 150);
    beep(speakerPin, a, 1000);
    //second bit...
    
    beep(speakerPin, aH, 500);
    beep(speakerPin, a, 350); 
    beep(speakerPin, a, 150);
    beep(speakerPin, aH, 500);
    beep(speakerPin, gSH, 250); 
    beep(speakerPin, gH, 250);
    
    beep(speakerPin, fSH, 125);
    beep(speakerPin, fH, 125);    
    beep(speakerPin, fSH, 250);
    delay(250);
    beep(speakerPin, aS, 250);    
    beep(speakerPin, dSH, 500);  
    beep(speakerPin, dH, 250);  
    beep(speakerPin, cSH, 250);  
    //start of the interesting bit
    
    beep(speakerPin, cH, 125);  
    beep(speakerPin, b, 125);  
    beep(speakerPin, cH, 250);      
    delay(250);
    beep(speakerPin, f, 125);  
    beep(speakerPin, gS, 500);  
    beep(speakerPin, f, 375);  
    beep(speakerPin, a, 125); 
    
    beep(speakerPin, cH, 500); 
    beep(speakerPin, a, 375);  
    beep(speakerPin, cH, 125); 
    beep(speakerPin, eH, 1000); 
    //more interesting stuff (this doesn't quite get it right somehow)
    
    beep(speakerPin, aH, 500);
    beep(speakerPin, a, 350); 
    beep(speakerPin, a, 150);
    beep(speakerPin, aH, 500);
    beep(speakerPin, gSH, 250); 
    beep(speakerPin, gH, 250);
    
    beep(speakerPin, fSH, 125);
    beep(speakerPin, fH, 125);    
    beep(speakerPin, fSH, 250);
    delay(250);
    beep(speakerPin, aS, 250);    
    beep(speakerPin, dSH, 500);  
    beep(speakerPin, dH, 250);  
    beep(speakerPin, cSH, 250);  
    //repeat... repeat
    
    beep(speakerPin, cH, 125);  
    beep(speakerPin, b, 125);  
    beep(speakerPin, cH, 250);      
    delay(250);
    beep(speakerPin, f, 250);  
    beep(speakerPin, gS, 500);  
    beep(speakerPin, f, 375);  
    beep(speakerPin, cH, 125); 
           
    beep(speakerPin, a, 500);            
    beep(speakerPin, f, 375);            
    beep(speakerPin, c, 125);            
    beep(speakerPin, a, 1000);       
    //and we're done \ó/    
}

