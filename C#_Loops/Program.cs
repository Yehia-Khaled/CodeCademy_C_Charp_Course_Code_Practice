namespace C__Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//While Loop
            Instructions
            Checkpoint 1 Passed
            1.
            You’re really trying to step up your “inbox zero” game and want to build a tool that can help you get there.For your first prototype, you’re just going to delete all the emails.

            Write a while loop that checks to see if there are any emails in your inbox. If there are still emails, decrease the amount of emails by one until there are no emails left.

            If the test runs infinitely, you probably ran into an infinite loop! Refresh the page and make sure your loop is able to terminate.

            Checkpoint 2 Passed
            2.
            It’s a little hard to tell what’s happening in our program, so within the loop have it print a message that it’s deleting an email and how many emails are left.

            Checkpoint 3 Passed
            3.
            When your inbox reaches zero, have your program print out “INBOX ZERO ACHIEVED!” or some other congratulatory message.
            
            int emails = 20;

            while (emails != 0)
            {
                emails--;
                Console.WriteLine($"one email deleted, emails left {emails} one.");
            }
            Console.WriteLine("INBOX ZERO ACHIEVED!");
            */

            //Do...While Loop
            /*Instructions
            Checkpoint 1 Passed
            1.
            You’ve decided to try making another productivity tool. This time you build a pomodoro timer.When the timer finishes, an alarm will ring once. If you don’t click the button to turn it off, the alarm will repeat until it is turned off.

            Write a program that plays the alarm once, and then if the button isn’t clicked(!buttonClick), it will repeat the alarm.To simulate an alarm, you can print something like “Alarm Ringing” to the console.

            When working with loops, if the stopping condition is never met, we will end up with a dreaded infinite loop.When this happens, the program will never exit the loop, stopping it from running anything else !To get out of an infinite loop, refresh the page. Then, inspect and fix your code before running the program again.

            Checkpoint 2 Passed
            2.
            After the loop finishes, the program should print a message telling you to take a break, like:

            "Time for a five minute break."

          
            bool buttonClick = true;

            do
            {
                Console.WriteLine("Alarm Ringing");
            } while (!buttonClick);

            Console.WriteLine("Time for a five minute break.");
            */

            /*//For Loop
            Instructions
            Checkpoint 1 Passed
            1.
            For your next tool, you want to create a template for your weekly team meeting.Rather than rewrite a new one each week, you decide to make all of them at once.

            Write an empty for loop that runs once for each week in your 16 - week - long project.We’ll want to number the weeks 1 through 16, so the iterator variable should begin at 1, 
            and the loop should continue executing until it is more than 16.

            Checkpoint 2 Passed
            2.
            Move the print statements inside of the CreateTemplate function so that they are inside the for loop.The CreateTemplate function is no longer needed.Within the first call to Console.WriteLine(),
            update the argument so that it interpolates the value of the iteration variable so that each week is labeled with the correct number.


            static void CreateTemplate(int week)
                {
                    Console.WriteLine("Announcements: \n \n \n ");
                    Console.WriteLine("Report Backs: \n \n \n");
                    Console.WriteLine("Discussion Items: \n \n \n");
                }
            for (int i = 1; i <= 16; i++)
            {
                Console.WriteLine($"Week {i}");

                CreateTemplate(i);
            }
            */

            /*//For Each Loop
            Instructions
            Checkpoint 1 Passed
            1.
            Now, you want to create a To-Do list to keep track of your tasks.Write an empty loop that will iterate through each item in your todo array.

            Checkpoint 2 Passed
            2.
            Inside the loop, use Console.WriteLine() to print the current task like this:

            [] "task text"
            string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

            foreach (string item in todo)
            {
                Console.WriteLine($"[] {item}.");
            }
            */

            /* //Comparing Loops
             Instructions
             Checkpoint 1 Enabled
             1.
             You want to build an app that blocks websites, so you find some code online and copy and paste it into your text editor.You notice that it uses
                             a while loop to iterate through a websites array, but you know a better way to do that!

             Re - write the loop so that it uses a loop that better suits the objective.
            
            string[] websites = { "twitter", "facebook", "gmail" };

            //int counter = 0;
            //while (counter < websites.Length)
            //{ 
            // Console.WriteLine(websites[counter]); 
            //  counter++; 
            //}
            
            foreach (string website in websites)
            {
                Console.WriteLine(website);
            }
            */

            //Jump Statements

            /*Instructions
            Checkpoint 1 Passed
            1.
            You’ve decided to go back to the pomodoro application.This time, you don’t want the alarm to ring endlessly.Once it rings 3 times, it should shut off even if the button has not been clicked.

            Note that we have temporarily set the initial value of buttonClick to true.Otherwise, running the code as is would result in an infinite loop! You will update the starting value of buttonClick in a later step.

            To start, create a variable that will keep track of how many times the alarm has gone off.

            Create an int variable to hold the count value.Start it equal to zero, since the alarm has not gone off yet.

            Checkpoint 2 Passed
            2.
            Inside the do ...while loop, increase the count every time the alarm goes off.

            Checkpoint 3 Passed
            3.
            The program should break out of the loop if the count variable reaches 3.

            Write a statement that checks if the count variable has reached three, and when it does, have it break out of the do ...while loop.

            Now, you can update the starting value of buttonClick to false to see the alarm ring three times.
            
            bool buttonClick = false;
            int i = 0;
            do
            {
                Console.WriteLine("BLARRRRR");
                i++;
                if (i == 3)
                {
                    break;
                }
            } while (!buttonClick);
            */

            //Review
            /* use this space to write your own short program! 
            Here's what you learned:

            while loop: while(){..} 
            do...while loop: do{...}while();
            for loop: for(int i=0; i<x; i++){}
            foreach loop: foreach(int item in list){}
            jump statements: break, continue, return

            Good luck! */

        }
    }
}
