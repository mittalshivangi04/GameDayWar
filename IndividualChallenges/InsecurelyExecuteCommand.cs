public void InsecurelyExecuteCommand()
{
    // Insecure: Executes a command to create a sensitive directory
    Process.Start("cmd.exe", "/c mkdir C:\\Sensitive");
    Console.WriteLine("Executed command to create directory C:\\Sensitive.");
}
