namespace Personality
{
    class Program
    {

        static void Main(string[] args)
        {
            int [] answers = new int[3];
            string [] results = new string[3];
            results[0] = "Self-Management You manage yourself well; You take responsibility for your own behavior and well-being.";
            results[1] = "Empathy You are emphatic. You see yourself in someone else’s situation before doing decisions. You tend to listen to other’s voices.";
            results[2] = "Self-Awareness You are conscious of your own character, feelings, motives, and desires. The process can be painful but it leads to greater self-awareness.";
            string [] questions = new string[8];
            questions[0] = "You went to a party last night and when you arrived to school the next day, everybody is talking about something you didn’t do. What will you do? \na. Avoid everything and go with your friends  b. Go and talk with then person that started the rumors  c. Go and talk with the teacher";
            questions[1] = "What quality do you excel the most? \na. Empathy  b. Curiosity  c. Perseverance";
            questions[2] = "You are walking down the street when you see an old lady trying to cross, what will you do? \na. Go and help her  b. Go for a policeman and ask him to help  c. Keep walking ahead";
            questions[3] = "You had a very difficult day at school, you will maintain a ____ attitude \na. Depends on the situation  b. Positive  c. Negative";
            questions[4] = "You are at a party and a friend of yours comes over and offers you a drink, what do you do? \na. Say no thanks  b. Say no thanks  c. Ignore him and get angry at him";
            questions[5] = "You just started in a new school, you will... \na. Go and talk with the person next to you  b. Wait until someone comes over you  c. Not talk to anyone";
            questions[6] = "In a typical Friday, you would like to.. \na. Go out with your close friends to eat  b. Go to a social club and meet more people  c. Invite one of your friends to your house";
            questions[7] = "Your relationship with your parents is.. \na. I like both equally  b. I like both equally  c. I like my Mom the most";

            Random randomizer = new Random();
            var indexes = Enumerable.Range(0,questions.Length).OrderBy(i => randomizer.Next());
            var numbering=1;
            foreach(var index in indexes)
            {
                Console.WriteLine($"{numbering++}." + questions[index]);
                do 
                {        
                    Console.WriteLine("Type your answer:");
                    var a = Console.ReadLine();
                    if (a == "a" ||  a == "b" || a == "c" ) {                
                        if (a == "a") {answers[0] = answers[0] + 1;}
                        if (a == "b") {answers[1] = answers[1] + 1;}
                        if (a == "c") {answers[2] = answers[2] + 1;}
                    break;
                    }
                    Console.WriteLine("a,b,c only");
                }
                while(true);
            }

            
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}count(a) {answers[0]}");
            Console.WriteLine($"{Environment.NewLine}count(b) {answers[1]}");
            Console.WriteLine($"{Environment.NewLine}count(c) {answers[2]}");
            Console.WriteLine($"{Environment.NewLine}Total Answers) {answers[0] + answers[1] + answers[2]}");

            if (answers[0] > answers[1] && answers[0] > answers[2])
            {
                Console.WriteLine($"{Environment.NewLine} {results[1]}");
            }
            else if(answers[1] > answers[0] && answers[1] > answers[2])
            {
                Console.WriteLine($"{Environment.NewLine} {results[2]}");
            }
            else if(answers[2] > answers[0] && answers[2] > answers[1])
            {
                Console.WriteLine($"{Environment.NewLine} {results[0]}");
            }
            else if (answers[0] == answers[1] && answers[0] >= answers[2])
            {
                Console.WriteLine($"{Environment.NewLine} {results[2]}");
            }
            else if(answers[1] >= answers[0] && answers[1] == answers[2])
            {
                Console.WriteLine($"{Environment.NewLine} {results[0]}");
            }
            else if(answers[2] == answers[0] && answers[2]>= answers[1])
            {
                Console.WriteLine($"{Environment.NewLine} {results[1]}");
            }
        }

        
    }
}