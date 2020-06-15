using CSharpSpaceXApp.Models;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpaceXApp.Services.Contracts
{
    public interface IFileService
    {
        Document CreatePDF(MemoryStream stream, string title);
        string GetStringOfObject(Launch flight);
        void AddInfoInPDF(Launch flight, StringBuilder stringToPrint, PropertyInfo propertyInfo);
        bool CheckIfNullOrEmpty<T>(T element, StringBuilder stringBuilder);

    }
}
