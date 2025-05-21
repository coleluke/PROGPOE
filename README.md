**Cybersecurity Awareness Bot**
A console-based C# chatbot designed to educate users on best practices for cybersecurity. The bot provides helpful tips on password safety, phishing, online privacy, malware protection, and more. It uses simple text input/output and audio feedback to engage the user.

** Features**
**Voice greeting and farewell using .wav files.**

🎨 **ASCII art for a fun, interactive start.**

🤖 **Responds to user queries on:**

Password safety

Phishing awareness

Malware protection

Safe browsing

Online privacy

Social media security

 **Supports emotional recognition phrases like “worried”, “curious”, etc.**

 **Remembers topics you're interested in for future reminders.**

 **Beep feedback for successful or unrecognized input.**

 **Requirements**
.NET SDK (version 6.0 or newer recommended)

Audio support for SoundPlayer (System.Media)

Console environment (Windows for best compatibility due to SoundPlayer)

 **Files**
Program.cs (or ChatBot.cs): Main source code for the chatbot.

welcome.wav: Audio file for the welcome greeting.

goodbye.wav: Audio file for the goodbye message.

 **How to Run**
Clone or download the repository.

Place welcome.wav and goodbye.wav audio files in the same directory as the executable.

Build and run the project:

bash
Copy
Edit
dotnet build
dotnet run
 **Example Interaction**
text
Copy
Edit
Welcome to the Cybersecurity Awareness Bot!
What's your name? Alice
Hello, Alice! I'm here to help you stay safe online.

Here are some questions you can ask:
1. How are you?
2. What's your purpose?
3. Tell me about password safety
...
Enter the number of your question or type a topic: 3
Your password should include numbers, symbols, and upper/lowercase letters.
 **Notes**
If audio playback fails, make sure .wav files are correctly named and placed.

This is a console application, so graphical elements are displayed via ASCII.

The bot does not access the internet or store data externally.

 **License**
This project is open-source and available under the MIT License.

 **Author**
Developed by [Your Name] – feel free to customize or expand!
