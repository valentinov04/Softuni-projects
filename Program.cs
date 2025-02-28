int N = int.Parse(Console.ReadLine());
Queue<string> queue = new Queue<string>();
string commands = Console.ReadLine();
string[] tokens = commands.Split().ToArray();
string firstCommand = tokens[0];
int counter = 0;
while (firstCommand != "end")
{
    if (firstCommand != "green")
    {
        queue.Enqueue(commands);
    }
    else if (firstCommand == "green")
    {
        if (queue.Count < N)
        {
            for (int i = 0; i < queue.Count + 1; i++)
            {
                Console.WriteLine($"{queue.Dequeue()} passed!");
                counter++;
            }
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{queue.Dequeue()} passed!");
                counter++;
            }
        }
    }
    commands = Console.ReadLine();
    firstCommand = tokens[0];
    tokens = commands.Split().ToArray();
    firstCommand = tokens[0];
}
Console.WriteLine($"{counter} cars passed the crossroads.");