using System;
using System.Text.RegularExpressions;
static class LogLine
{
    public static string Message(string logLine)
    {
    int startIndex = logLine.IndexOf(":") + 1; //Pega os elementos depois de :

       if (startIndex > 0 && startIndex < logLine.Length)
    {
        return logLine.Substring(startIndex).Trim(); //Inicia o índice depois do ":" e retira os espaçoes em branco
    }

    return logLine;
        
    }

    public static string LogLevel(string logLine)
    {
        Match match = Regex.Match(logLine, @"\[([A-Za-z]+)\]"); //pega os elementos que estejam entre []

        if(match.Success && match.Groups.Count > 1){ //se localizar um elemento a quantidade for maior que 1 (Group[0] representa toda a string)
            string level = match.Groups[1].Value.ToLower(); // Deixa primeiro elemento em minúsculo
            return level;
        }

        return string.Empty; //Empty retorna uma string vazia, seria o mesmo que string = ""
    }

    public static string Reformat(string logLine)
    {
         Match match = Regex.Match(logLine, @"\[([A-Z]+)\]: (.+)"); // Separa dois grupos, um entre [], e outro que vem depois

        if(match.Success){  
             return $"{match.Groups[2].Value.Trim()} ({match.Groups[1].Value.ToLower()})";
             //primeiro grupo em minúsculo
             //segundo valor retirando os espaçoes me branco
        }

        // Retorna a linha do log original se o formato não for reconhecido
        return logLine;
    }
}
