using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiliPublisherDeveloperChallange.Infrastructure
{
    public class XmlSelector
    {
        public static string GetSelectedXmlPath()
        {
            OpenFileDialog _fileDialogObj = new OpenFileDialog();
            _fileDialogObj.Title = "Open XML File";
            _fileDialogObj.Filter = "XML files|*.xml";
            _fileDialogObj.InitialDirectory = @"C:\";
            Nullable<bool> resultOfDialog = _fileDialogObj.ShowDialog();
            if (resultOfDialog == true)
            {
                try
                {
                    return _fileDialogObj.FileName;
                }
                catch (Exception ex)
                {
                    return $"Exception: {ex.Message}\n\n Details:\n\n{ex.StackTrace}";
                }
            }
            return "";

        }
    }
}
