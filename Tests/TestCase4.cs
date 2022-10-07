using InsperityLibrary;
using System;
using System.Collections.Generic;
using Xunit;

namespace InsperityTests
{
    /// <summary>
    /// TestCase4 from the PDF file
    /// </summary>
    public class TestCase4
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
        public TestCase4()
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
                "qakmc",
                "rrtbk",
                "vaixn",
                "wmpnj",
                "uproi",
                "btska",
                "ejqwr",
                "elwlg",
                "oaoiy",
                "hrqkn"
            };

            this._outputs = new List<string>(){
                "ackmq",
                "rrbkt",
                "ainvx",
                "jmnpw",
                "iopru",
                "abkst",
                "ejqrw",
                "llegw",
                "ooaiy",
                "hknqr"
            };
        }

        [Fact]
        public void Case10Entries()
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
