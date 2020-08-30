using LeetCode.Learn.Foundation;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.Learn.ArrayAndString.TestCases
{
    //xUnit Framework : https://xunit.net/
    public class DiagonalTraverseTestCases 
    {
        public DiagonalTraverseTestCases()
        {

        }

        //Load the required data and apply the required configuration
        public void Initliaze()
        {
            //TODO Need to implement later
        }

        [Fact]
        public void CanMatrixTraverseDiagonal()
        {
            var testDataSets = JsonDataLoader.GetJsonFileData<List<int[][]>>(@"TestData\DiagonalTraverse.json");

        }
    }
}
