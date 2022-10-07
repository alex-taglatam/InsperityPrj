using InsperityLibrary;
using System;
using System.Collections.Generic;
using Xunit;

namespace InsperityTests
{
    /// <summary>
    /// TestCase5 from the PDF file
    /// </summary>
    public class TestCase6
    {
        //instance of the sorter logic
        private ISorter _sorter;

        //list of input strings
        private IList<string> _inputs;

        //list of output strings
        private IList<string> _outputs;

        /// <summary>
        /// constructor
        /// </summary>
        public TestCase6()
        {
            //create a logic instance
            _sorter = new StringSorterByFrequencyAndLexical();

            //prepare the environment
            this.prepare();
        }

        /// <summary>
        /// prepare environment
        /// </summary>
        void prepare()
        {
            this._inputs = new List<string>(){
                "xqycs",
                "beoax",
                "afkso",
                "bldit",
                "gwrys"
            };

            this._outputs = new List<string>(){
                "cqsxy",
                "abeox",
                "afkos",
                "bdilt",
                "grswy"
            };
        }

        [Fact]
        public void Case5Entries()
        {
            //for each input string
            for (int i = 0; i < this._inputs.Count; i++)
            {
                //execute sort
                string result = _sorter.sort(this._inputs[i]);

                //compare result with the desired output
                Assert.Equal(this._outputs[i], result);
            }
        }
    }
}
