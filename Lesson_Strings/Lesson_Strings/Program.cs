namespace Lesson_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*//Building Strings
            //First string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune must be in want of a wife.";
            // Second string variable
            string firstSpeech = "My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?";

            // Print variable and newline
            Console.WriteLine(firstSentence);
            Console.WriteLine("\n");
            Console.WriteLine(firstSpeech);

            */
            /*String Concatenation
            // Declare the variables
            string beginning = "Hello evereone how are you";
            string middle = " i am fine";
            string end = " thank you";

            // Concatenate the string and the variables
            string story = beginning + middle + end;

            // Print the story to the console 
            Console.WriteLine(story);
            */
            /*
            String Interpolation
            // Declare the variables
            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story = $"{beginning} {middle} {end}";

            // Print the story to the console 
            Console.WriteLine(story);
            */
            /*
            //Get Info About Strings
            // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;


            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");

            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
            */

            /*
            //Get Parts of Strings
            // DNA strand
            string startStrand = "ATGCGATGAGCTTAC";

            // Find location of "tga"
            int tga = startStrand.IndexOf("TGA");

            // Start point and stop point variables
            int startPoint = 0;
            int length = tga + 3;

            // Define final strand
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine(dna);

            // DNA mutation search
            Console.WriteLine(dna[3]);
            */
            //Manipulate Strings
            // Script line
            /*
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";


            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length);

            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            // Print results
            Console.WriteLine(cameraDirections + " " + sceneDescription);
            */

        }
    }
}
