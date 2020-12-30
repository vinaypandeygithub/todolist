using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToDoUnitTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using ToDo.Models;

    [TestClass]
    public class TasksAPI_GetAllStories
    {
        string ApiURL = "http://localhost:51567/api/tasks";
        [TestMethod]
        public async Task GetAllStories_ShouldReturnRecords_BecauseOfHardCodedData()
        {
            CommomFunctions commonFunctions = new CommomFunctions();
            List<Story> stories =await commonFunctions.GetJsonAsync<List<Story>>(ApiURL);
            Assert.IsTrue(stories.Count > 0);
        }

       
    }
}
