using FileManagerWPF.Models;
using FileManagerWPF.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileManagerMSTestTests
{
    [TestClass]
    public class FileManagerMSTestTests
    {
        private string ActualString, ExpectedString;
        private long ActualLong, ExpectedLong;

        private MainWindowViewModel mainWindowViewModel;

        [TestMethod]
        public void GetSize_TestFolder_280b_returned()
        {
            ExpectedString = "280 α";
            mainWindowViewModel = new MainWindowViewModel();
            ActualString = mainWindowViewModel.SizeConversion(mainWindowViewModel.GetDirSize("C:\\Test"));
            Assert.AreEqual(ExpectedString, ActualString);
        }

        [TestMethod]
        public void SizeConversion_1024b_1kb_returned()
        {
            ExpectedString = "1 Κα";
            mainWindowViewModel = new MainWindowViewModel();
            ActualString = mainWindowViewModel.SizeConversion(1024);
            Assert.AreEqual(ExpectedString, ActualString);
        }

        [TestMethod]
        public void GetSize_TestFolder_return280b()
        {
            ExpectedLong = 280;
            mainWindowViewModel = new MainWindowViewModel();
            ActualLong = mainWindowViewModel.GetDirSize("C:\\Test");
            Assert.AreEqual(ExpectedLong, ActualLong);
        }

        [TestMethod]
        public void Open_Folder()
        {
            ExpectedString = "C:\\";
            mainWindowViewModel = new MainWindowViewModel();
            ActualString = mainWindowViewModel.GetItemsInfoFromPath("C:\\");
            Assert.AreEqual(ExpectedString, ActualString);
        }

        [TestMethod]
        public void Open_Test_Folder_1st_lvl()
        {
            ExpectedString = "C:\\Test";
            mainWindowViewModel = new MainWindowViewModel();
            ActualString = mainWindowViewModel.GetItemsInfoFromPath("C:\\Test");
            Assert.AreEqual(ExpectedString, ActualString);
        }

        [TestMethod]
        public void Open_Test_Folder_2nd_lvl()
        {
            ExpectedString = "C:\\Test\\test";
            mainWindowViewModel = new MainWindowViewModel();
            ActualString = mainWindowViewModel.GetItemsInfoFromPath("C:\\Test\\test");
            Assert.AreEqual(ExpectedString, ActualString);
        }

        [TestMethod]
        public void Open_Test_Folder_3nd_lvl()
        {
            ExpectedString = "C:\\Test\\test2\\test2.2";
            mainWindowViewModel = new MainWindowViewModel();
            ActualString = mainWindowViewModel.GetItemsInfoFromPath("C:\\Test\\test2\\test2.2");
            Assert.AreEqual(ExpectedString, ActualString);
        }

    }
}
