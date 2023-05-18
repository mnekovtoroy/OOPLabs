using System;
using System.IO;

public class CopyFileUpper
{
	public static void Main()
	{
		string sFrom, sTo;
		StreamReader srFrom;
		StreamWriter swTo;
		Console.Write("Enter input filename: ");
		sFrom = Console.ReadLine();
		Console.Write("Enter output filename: ");
		sTo = Console.ReadLine();
		try {
			srFrom = new StreamReader(sFrom);
			swTo = new StreamWriter(sTo);
			while (srFrom.Peek() != -1) {
				string sBuffer = srFrom.ReadLine();
				swTo.WriteLine(sBuffer.ToUpper());
			}
			srFrom.Close();
			swTo.Close();
		} catch (FileNotFoundException) {
			Console.WriteLine("Either \"{0}\" or \"{1}\" is non-existent.", sFrom, sTo);
		} catch (Exception) {
			Console.WriteLine("c hashtag moment");
		}
	}       
}
