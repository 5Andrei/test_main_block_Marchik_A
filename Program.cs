string[] Request(string msg)
{
    Console.Write(msg);
    return Console.ReadLine().Split("; ");
}
