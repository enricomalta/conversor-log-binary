using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        Console.WriteLine("Selecione a operação desejada:");
        Console.WriteLine("1 - Converter de texto para binário");
        Console.WriteLine("2 - Converter de binário para texto");
        Console.WriteLine("");
        
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                ConverterDeTextoParaBinario();
                break;
            case "2":
                ConverterDeBinarioParaTexto();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static void ConverterDeTextoParaBinario()
    {
        string pastaOrigem = "txt";
        string pastaDestino = "binary";

        string[] arquivosTxt = Directory.GetFiles(pastaOrigem, "*.txt");
        foreach (string arquivoTxt in arquivosTxt)
        {
            string nomeArquivo = Path.GetFileName(arquivoTxt);
            string nomeArquivoSemExtensao = Path.GetFileNameWithoutExtension(nomeArquivo);
            string binarioFilePath = Path.Combine(pastaDestino, nomeArquivoSemExtensao + ".bin");

            string texto = File.ReadAllText(arquivoTxt);
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(texto);

            // Compactar os dados usando GZIP
            using (FileStream fs = new FileStream(binarioFilePath, FileMode.Create))
            {
                using (GZipStream gz = new GZipStream(fs, CompressionMode.Compress))
                {
                    gz.Write(bytes, 0, bytes.Length);
                }
            }

            Console.WriteLine($"Arquivo {nomeArquivo} convertido para binário com sucesso!");
            Thread.Sleep(1500);
        }
    }

    static void ConverterDeBinarioParaTexto()
    {
        string pastaOrigem = "binary";
        string pastaDestino = "txt";

        string[] arquivosBin = Directory.GetFiles(pastaOrigem, "*.bin");
        foreach (string arquivoBin in arquivosBin)
        {
            string nomeArquivo = Path.GetFileName(arquivoBin);
            string nomeArquivoSemExtensao = Path.GetFileNameWithoutExtension(nomeArquivo);
            string textoFilePath2 = Path.Combine(pastaDestino, nomeArquivoSemExtensao + ".txt");

            // Descompactar os dados usando GZIP
            using (FileStream fs = new FileStream(arquivoBin, FileMode.Open))
            {
                using (GZipStream gz = new GZipStream(fs, CompressionMode.Decompress))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        gz.CopyTo(ms);
                        byte[] bytes2 = ms.ToArray();
                        string texto2 = System.Text.Encoding.UTF8.GetString(bytes2);
                        File.WriteAllText(textoFilePath2, texto2);
                    }
                }
            }

            Console.WriteLine($"Arquivo {nomeArquivo} convertido para texto com sucesso!");
            Thread.Sleep(1500);
        }
    }
}