public class ManagerFile
{
    
    public static void Read(int index)
    {
        string[] files = ListFile();
        string file = files[index - 1];
        Console.WriteLine("Name: "+Path.GetFileName(file) + "\nPath: "+Path.GetFullPath(file));
        string[] lines = File.ReadAllLines(file);

         Console.WriteLine("=~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~");
        if (lines.Length > 0)
        {
            int linha=1;
            foreach (string line in lines)
            {
                Console.Write("- "+linha+"    ");
                Console.WriteLine(line);
                linha++;
            }
        }
        else
        {
            Console.WriteLine("FILE IS EMPTY");
        }
         Console.WriteLine("=~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~==~=~");
        
    }

      public static void Delete(int index)
    {
        string[] files = ListFile();
        string file = files[index - 1];
        File.Delete(file);
        Console.WriteLine("File deleted successfully!");
    }

    public static void Update(int index, int option)
    {
        string[] files = ListFile();
        string file = files[index - 1];

        switch (option){
            case 1:{
                // Lê todas as linhas do arquivo
                string[] lines = File.ReadAllLines(file);
                
                Console.Write("Line: ");
                int indexLine = Input.Index();
                if(indexLine == 0 || indexLine <= 0){
                    Console.WriteLine("Error: Index invalid, please try again!");
                    Thread.Sleep(2500);
                    Update(index, option);         
                }

                // Verifica se a linha a ser excluída está dentro do intervalo válido
                indexLine -= 1;
                
                if (indexLine >= 0 && indexLine < lines.Length)
                {
                    // Cria um arquivo temporário para escrever
                    string tempFilePath = Path.GetTempFileName();
                    
                    // Escreve todas as linhas, exceto a linha a ser excluída, no arquivo temporário
                    using (StreamWriter writer = new StreamWriter(tempFilePath))
                    {
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (i != indexLine)
                            {
                                writer.WriteLine(lines[i]);
                            }
                        }
                    }

                    // Substitui o arquivo original pelo arquivo temporário
                    File.Delete(file);
                    File.Move(tempFilePath, file);

                    Console.WriteLine("Line exclused successfully!");
                    char optionContinue = Input.Continue();
                    if(optionContinue == 'y'){
                        Console.Clear();
                        Read(index);
                        Update(index, option);
                    
                    }

                }
                else
                {
                    Console.WriteLine("Error: Index inválido, please try again.");
                    Update(index, option);
                }
                break;
            }

            case 2:{
                 
                 try{
                        string[] lines = File.ReadAllLines(file);
                        // Abrir o arquivo para adicionar conteúdo ao final
                        using (StreamWriter writer = File.AppendText(file))
                        {
                            // Conteúdo a ser adicionado
                            string conteudo = Input.Text(lines.Length+1);

                            // Escrever o conteúdo no arquivo
                            writer.WriteLine(conteudo);
                        }

                        Console.WriteLine("Conteúdo adicionado com sucesso.");
                    }catch (Exception ex){
                        Console.WriteLine("Ocorreu um erro: " + ex.Message);
                    }
                break;
            }

            case 3:{
                File.WriteAllText(file, string.Empty);
                Console.WriteLine("File cleared successfully!");            
                break;
            }
        }
    }

    public static bool Salve(string name, string text)
    {
        
        // Obtém o diretório de execução do programa
        string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

        // Cria o caminho completo para o arquivo
        string filePath = Path.Combine(directoryPath, @"..\..\..\app\database\file", $"{name}.txt");

        try{

            using StreamWriter file = new StreamWriter(filePath);
            Console.Clear();
            file.WriteLine(text);
            return true;
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
            return false;
        }
    }

  
    public static  string[] ListFile()
    {
            
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(directoryPath, @"..\..\..\app\database\file\");
            // Obtém todos os arquivos na pasta
            return Directory.GetFiles(folderPath);
                 
    }
}