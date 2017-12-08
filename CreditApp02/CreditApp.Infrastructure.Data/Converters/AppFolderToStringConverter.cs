using System;
using System.IO;
using CreditApp02.Helpers;
using CreditApp02.Infrastructure.Data.Converters.Interfaces;
using Xamarin.Forms;

namespace CreditApp02.Infrastructure.Data.Converters
{
    public class AppFolderToStringConverter : IAppFolderToStringConverter
    {
        public string Convert(AppFolder folder)
        {
     
            switch (folder)
            {
                case AppFolder.Default:
                    string relativePath = @"Database\CreditApp.sqlite";
                    var parentdir = Path.GetDirectoryName(Application.Current.ToString());
                    string myString = parentdir.Remove(parentdir.Length - 34, 34);
                    string absolutePath = Path.Combine(myString, relativePath);

                    return absolutePath;
                default:
                    throw new IndexOutOfRangeException();

            }


        }
    }
}
