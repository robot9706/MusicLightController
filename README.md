# MusicLightController
Application for a music controlled LED project

# Description
Used for a project where I recycled an old LED light to make some music controlled LEDs. The LEDs are controlled using a ATmega328P-PU (Ardunio UNO CPU) on a standalone PCB with 2 60V/50A (way overkill) MOSFETs, the LEDs run on 25V and they require 200mA max. The brightness is controlled by PWM (PWM pin 5 and 6).

The sketch and compiled code are in the "Misc" folder: serial_pwm.ino and serial_pwm.ino.hex.

The sounds are recorded realtime from the soundcard output and analysed realtime (with ~50ms delay to the LEDs) using FMOD.

# License
Use the way you want, just give credit.
