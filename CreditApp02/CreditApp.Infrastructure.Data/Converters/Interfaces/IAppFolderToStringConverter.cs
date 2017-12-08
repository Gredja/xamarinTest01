using System;
using CreditApp02.Helpers;

namespace CreditApp02.Infrastructure.Data.Converters.Interfaces
{
   public interface IAppFolderToStringConverter
    {
        string Convert(AppFolder folder);
    }
}
