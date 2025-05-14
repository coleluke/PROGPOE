using System;
using System.Collections.Generic;
using System.Media;
using System.IO;

public class ChatBot
{
    private static string userName = "";
    private static string userInterest = "";
    private static readonly Random rand = new Random();

    static readonly List<string> phishingTips = new List<string>
    {
        "Be cautious of emails asking for personal information.",
        "Never click on links in suspicious emails.",
        "Scammers often disguise themselves as trusted organisations.",
        "Look for spelling errors in suspicious emails — it's a giveaway!"
    };

    static readonly List<string> passwordTips = new List<string>
    {
        "Use a different password for each account.",
        "Your password should include numbers, symbols, and upper/lowercase letters.",
        "Avoid using names, birthdates, or common words in passwords.",
        "Consider using a password manager to store your credentials securely."
    };

    public static void Main(string[] args)
    {
        Console.Clear();

        PlayVoiceGreeting("welcome.wav");
        DisplayImage();

        PrintSeparator();
        GreetUser();
        PrintSeparator();

        StartChatLoop();
    }

    static void PlayVoiceGreeting(string audioFilePath)
    {
        if (File.Exists(audioFilePath))
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(audioFilePath))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while playing the audio: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"The audio file {audioFilePath} is missing.");
        }
    }

    static void PlayResponseSound()
    {
        try
        {
            Console.Beep(1000, 200);
        }
        catch { }
    }

    static void DisplayImage()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"
 .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.   
| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |  
| |    _______   | || |  _________   | || |  ____  ____  | || |  ____  ____  | || |  _______     | || |  _________   | || |  ________    | || |  ________    | |  
| |   /  ___  |  | || | |_   ___  |  | || | |_  _||_  _| | || | |_  _||_  _| | || | |_   __ \    | || | |_   ___  |  | || | |_   ___ `.  | || | |_   ___ `.  | |  
| |  |  (__ \_|  | || |   | |_  \_|  | || |   \ \  / /   | || |   \ \  / /   | || |   | |__) |   | || |   | |_  \_|  | || |   | |   `. \ | || |   | |   `. \ | |  
| |   '.___`-.   | || |   |  _|  _   | || |    > `' <    | || |    \ \/ /    | || |   |  __ /    | || |   |  _|  _   | || |   | |    | | | || |   | |    | | | |  
| |  |`\____) |  | || |  _| |___/ |  | || |  _/ /'`\ \_  | || |    _|  |_    | || |  _| |  \ \_  | || |  _| |___/ |  | || |  _| |___.' / | || |  _| |___.' / | |  
| |  |_______.'  | || | |_________|  | || | |____||____| | || |   |______|   | || | |____| |___| | || | |_________|  | || | |________.'  | || | |________.'  | |  
| |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | |  
| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |  
 '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'   
        ");
        Console.ResetColor();
    }

    static void GreetUser()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!");
        Console.ResetColor();

        Console.Write("What's your name? ");
        userName = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Hello, {userName}! I'm here to help you stay safe online.");
        Console.ResetColor();
    }

    static void DisplayQuestionMenu()
    {
        Console.WriteLine("\nHere are some questions you can ask:");
        Console.WriteLine("1. How are you?");
        Console.WriteLine("2. What's your purpose?");
        Console.WriteLine("3. Tell me about password safety");
        Console.WriteLine("4. What should I know about phishing?");
        Console.WriteLine("5. How can I protect against malware?");
        Console.WriteLine("6. What are safe browsing practices?");
        Console.WriteLine("7. How can I improve my online privacy?");
        Console.WriteLine("8. What's important for social media security?");
        Console.WriteLine("9. Exit");
        Console.Write("\nEnter the number of your question or type a topic: ");
    }

    static void HandleUserQuery(string userInput)
    {
        userInput = userInput.ToLower();

        if (userInput.Contains("worried") || userInput.Contains("scared"))
        {
            PlayResponseSound();
            Console.WriteLine("It's okay to feel worried. You're taking the right step by learning how to stay safe.");
        }
        else if (userInput.Contains("curious"))
        {
            PlayResponseSound();
            Console.WriteLine("Curiosity is great! I'm ready to answer your questions.");
        }
        else if (userInput.Contains("frustrated") || userInput.Contains("confused"))
        {
            PlayResponseSound();
            Console.WriteLine("I get it — cybersecurity can be complex. Let's break it down together.");
        }
        else if (userInput.Contains("how are you") || userInput == "1")
        {
            PlayResponseSound();
            Console.WriteLine("I'm great, thank you! How can I assist you today?");
        }
        else if (userInput.Contains("what's your purpose") || userInput == "2")
        {
            PlayResponseSound();
            Console.WriteLine("I help you stay safe online by providing cybersecurity tips!");
        }
        else if (userInput.Contains("password") || userInput == "3")
        {
            PlayResponseSound();
            Console.WriteLine(passwordTips[rand.Next(passwordTips.Count)]);
        }
        else if (userInput.Contains("phishing") || userInput == "4")
        {
            PlayResponseSound();
            Console.WriteLine(phishingTips[rand.Next(phishingTips.Count)]);
        }
        else if (userInput.Contains("malware") || userInput == "5")
        {
            PlayResponseSound();
            Console.WriteLine("Keep your software updated and avoid suspicious downloads to prevent malware infections.");
        }
        else if (userInput.Contains("safe browsing") || userInput == "6")
        {
            PlayResponseSound();
            Console.WriteLine("Only visit trusted websites, look for HTTPS, and avoid clicking unknown links.");
        }
        else if (userInput.Contains("online privacy") || userInput == "7")
        {
            PlayResponseSound();
            Console.WriteLine("Use 2FA, manage your privacy settings, and avoid oversharing on public platforms.");
        }
        else if (userInput.Contains("social media security") || userInput == "8")
        {
            PlayResponseSound();
            Console.WriteLine("Use strong passwords, limit access to your posts, and don’t share personal info.");
        }
        else if (userInput.Contains("interested in"))
        {
            int index = userInput.IndexOf("interested in") + "interested in".Length;
            userInterest = userInput.Substring(index).Trim();
            PlayResponseSound();
            Console.WriteLine($"Great! I'll remember that you're interested in {userInterest}.");
        }
        else if (userInput.Contains("remind me"))
        {
            if (!string.IsNullOrEmpty(userInterest))
            {
                PlayResponseSound();
                Console.WriteLine($"As someone interested in {userInterest}, remember to review your security settings regularly.");
            }
            else
            {
                Console.WriteLine("Sure! Please let me know what topic you're interested in first.");
            }
        }
        else if (userInput.Contains("exit") || userInput == "9")
        {
            PlayVoiceGreeting("goodbye.wav");
            Console.WriteLine("Goodbye! Stay safe online.");
            Environment.Exit(0);
        }
        else
        {
            Console.Beep(300, 500);
            Console.WriteLine("I didn't quite understand that. Could you rephrase?");
        }
    }

    static void StartChatLoop()
    {
        while (true)
        {
            DisplayQuestionMenu();
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.Beep(200, 300);
                Console.WriteLine("Please enter a valid question number or keyword.");
            }
            else
            {
                HandleUserQuery(userInput);
            }

            PrintSeparator();
        }
    }

    static void PrintSeparator()
    {
        Console.WriteLine(new string('-', 50));
    }
}
