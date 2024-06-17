class FileFlipperApp
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the path to the file: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            string content = File.ReadAllText(filePath);

            char[] contentArray = content.ToCharArray();
            Array.Reverse(contentArray);
            string reversedContent = new string(contentArray);

            string directory = Path.GetDirectoryName(filePath);
            string filename = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);
            string newFilePath = Path.Combine(directory, $"{filename}_reversed{extension}");

            File.WriteAllText(newFilePath, reversedContent);

            Console.WriteLine($"File content has been reversed and saved to: {newFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
