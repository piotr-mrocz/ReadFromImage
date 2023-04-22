
// See https://aka.ms/new-console-template for more information
using Patagames.Ocr;

Console.WriteLine("Hello, World!");

var image = @"D:\Nauka\Repos\ReadTetFromImage\ReadTetFromImage\photo.png";

using (var objOcr = OcrApi.Create())
{
    objOcr.Init(Patagames.Ocr.Enums.Languages.English);
    var text = objOcr.GetTextFromImage(image);
    Console.WriteLine(text);
}