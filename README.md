# Light-Term Encryption NDV (Non Developer Version)
An advanced .NET Class Library for hardware-bound encryption. This engine doesn't just encrypt your data with a password, it "locks" the data to the physical components of your computer.

The data contains a file called "Decryptme.data". I ask anyone who enjoys this sort of thing to try decrypting it and send me an email to my profile with the contents of the file.

Warning: This is not possible.

## Core Security Features
Hardware-DNA Fusion: Combines CPU ProcessorID and Network MAC Address to create a unique hardware fingerprint.

Military Grade Encryption: Utilizes AES-256 (Advanced Encryption Standard) in CBC mode.

Brute-Force Protection: Implements PBKDF2 Key Stretching with 50,000 SHA-256 iterations.

Obfuscation Layers: Custom transformation chain

## CRITICAL WARNINGS (READ BEFORE USE)
CAUTION 

1. HARDWARE LOCK-IN
This library creates an encryption key tied to your specific hardware. Result: A file encrypted on "PC A" CANNOT be decrypted on "PC B", even with the correct password. If you replace your CPU or Motherboard, your encrypted data will be permanently inaccessible.

2. NO RECOVERY POSSIBLE
There is no "Password Recovery" or "Backdoor". If the password is lost or the hardware identity changes, the data is mathematically impossible to recover. Always keep a plaintext backup of vital information in a separate secure location.

A USB image for XELA/MELA will be available to unlock locked systems. However, this will only be for developers and will not be freely available.

## Installation & Requirements
Prerequisites
.NET Framework 4.8+ or .NET 6.0/8.0+ (Windows only)

NuGet Package: System.Management (Will soon merge with Fintou Resources)

The program must be run as administrator. Otherwise, the system will repeatedly fail during decryption. I will fix this so that the program will only start if it has administrator privileges.

## Setup
Download the Light-Term Engine.dll.

Add the DLL as a Reference in your Visual Studio project.

Install the System.Management package via NuGet.


Ensure the Windows Management Instrumentation (WMI) service is running on the host machine.

## License
This project is for educational and private use. Use at your own risk. The developer is not responsible for data loss due to hardware failure or forgotten passwords.
