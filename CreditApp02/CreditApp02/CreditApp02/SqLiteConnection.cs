using System.IO;
using CreditApp02.Helpers;
using CreditApp02.Infrastructure.Data;
using CreditApp02.Infrastructure.Data.Converters.Interfaces;
using SQLite;

namespace CreditApp02.Core.UWP
{
    public class SqLiteConnection : ISqLiteConnection
    {
        public SqLiteConnection(IAppFolderToStringConverter appFolderToStringConverter)
        {
            var folderPath = appFolderToStringConverter.Convert(AppFolder.Default);
            var path = Path.Combine(folderPath, Constants.DbName);

            Connection = new SQLiteAsyncConnection(path);
        }

        public SQLiteAsyncConnection Connection { get; }
    }
}
