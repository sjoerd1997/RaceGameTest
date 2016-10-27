using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Data.Xml.Dom;


namespace System.Diagnostics.Autism
{

}

namespace RaceGameTest
{
    sealed class MyXmlReader
    {
        public async Task ReadXmlFile()
        {
            //var folder = await StorageFolder.GetFolderFromPathAsync("C:\\Users\\sjoer\\Desktop");
            //var document = await XmlDocument.LoadFromFileAsync(
            //    await folder.CreateFileAsync("data.xml"));

            //System.Diagnostics.Debug.WriteLine(
            //    document.GetElementsByTagName("info")[0]
            //    .InnerText);

            var picker = new FileOpenPicker();
            picker.FileTypeFilter.Add(".xml");
            StorageFile file = await picker.PickSingleFileAsync();

            if (file == null)
            {
                return;
            }



            var document = await XmlDocument.LoadFromFileAsync(file);
            var content = document.GetElementsByTagName("Info")[0].InnerText;

            System.Diagnostics.Debug.WriteLine(content);


            //System.Diagnostics.Debug.WriteLine(
            //    document.GetElementsByTagName("info")[0]
            //    .InnerText);
        }
    }
}
