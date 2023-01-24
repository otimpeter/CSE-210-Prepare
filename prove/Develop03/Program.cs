using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
    }
class Scripture
{
    private string reference;
    private string text;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
    }

    public Scripture(string reference, string text, int startVerse, int endVerse)
    {
        this.reference = reference + ":" + startVerse + "-" + endVerse;
        this.text = text;
    }

    public string Reference { get { return reference; } }
    public string Text { get { return text; } }
}

class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(string reference)
    {
        var splitReference = reference.Split(':');
        book = splitReference[0];
        var chapterAndVerse = splitReference[1].Split('-');
        chapter = int.Parse(chapterAndVerse[0]);
        if (chapterAndVerse.Length == 1)
        {
            startVerse = int.Parse(chapterAndVerse[0]);
            endVerse = startVerse;
        }
        else
        {
            startVerse = int.Parse(chapterAndVerse[0]);
            endVerse = int.Parse(chapterAndVerse[1]);
        }
    }

    public string Book { get { return book; } }
    public int Chapter { get { return chapter; } }
    public int StartVerse { get { return startVerse; } }
    public int EndVerse { get { return endVerse; } }
}

class Word
{
    private string word;
    private bool hidden;

    public Word(string word)
    {
        this.word = word;
        hidden = false;
    }

    public string Text { get { return word; } }
    public bool Hidden { get { return hidden; } set { hidden = value; } }
}

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        var reference = new Reference(scripture.Reference);
        var words = scripture.Text.Split(' ').Select(w => new Word(w)).ToList();

        while (words.Any(w => !w.Hidden))
        {
            Console.Clear();
            Console.WriteLine(scripture.Reference);

            foreach (var word in words)
            {
                Console.Write(word.Hidden ? "_____ " : word.Text + " ");
            }

            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            var nextWordToHide = words[new Random().Next(words.Count)];
            nextWordToHide.Hidden = true;
         }
      }
   }
}