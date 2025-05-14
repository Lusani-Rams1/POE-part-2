# Console_POE
PART 1 OF THE POE

Project Details
1:Project name: poe
2:Netframework: 4.7.2
3:Template: Console App C# NetFrameWork

Featured files
User_Interface.cs
Logo.cs
playNow.cs
Program.cs
Logo.jpg
Chatbot.wav

User Guide
1: When you execute application
- A voice greeting is going to execute under a .wav format
-  If sound doesn't play which means Application didn't find sound and it's going to show 
  an error
- The application is meant to play the sound automatically
- If sound doesn't work try replacing the file path

2: Application is going to display logo
- The logo is design to display as an ASCII image
- If logo is not found, the system will display an error message
- if logo is not found try replacing the file path

3: System will dispaly a greeting/welcome message
- The message that will dispaly is "Welcome to the Chatbot".

4: System will prompt user to enter their Name
- This name will be used by the Chatbot while it addresses you after inputing it

5: shortly after the user will be able to ask a question  about cybersecurity until they decide to exit 
   the application
    - Passoword
    - Cybersecurity
    - Phishing and more...
    Example of asking question:
    Enter your question
    User-> scam
    Phishing scams trick users into revealing sensitive information.
    ===========================
    Ask another question!
    Enter your question
    User->

  - You can search the question by using keywords like 'scam'
    
6: when you insert void question app will show error message telling you to input correct question

lastly you can exit app by inputting exit.


**Part 2 Updates **

Featured files
User_Interface.cs
Memory_Recall
Logo.cs
playNow.cs
Program.cs
Logo.jpg
Chatbot.wav

1: Memory_recall
The chatbot will recall memory whether the code is closed or stil running.

2: Sentiment
This is what will show up if you input positive or negative word:

            if (positiveCount > negativeCount)
                Console.WriteLine("Sentiment: That's great to hear! I love positive energy. 😊");
            else if (negativeCount > positiveCount)
                Console.WriteLine("Sentiment: I understand how you feel. If you need advice or support, let me know. 🙁");
            else
                Console.WriteLine("Sentiment: Hmm, I'm sensing a neutral vibe. Let's chat and see where we go! 😐");

3: Keywords
You can now use keywords to search for quiries in the chatbot like 2fa, security, phishing, authentication, wifi and cybersecurity.

4: Random responses
Chatbot will generate and execute a random cybersecurity tip at the top of the code after the voice greeting and logo.

