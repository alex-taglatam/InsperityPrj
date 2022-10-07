using InsperityLibrary;
using System;
using System.Collections.Generic;
using Xunit;

namespace InsperityTests
{
    public class TestCase4
    {
        private ISorter _sorter;
        private IList<string> _inputs;
        private IList<string> _outputs;

        public TestCase4()
        {
            _sorter = new StringSorterByFrequencyAndLexical();

            this.prepare();
        }

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
            for (int i = 0; i < this._inputs.Count; i++)
            {
                string result = _sorter.sort(this._inputs[i]);
                Assert.Equal(this._outputs[i], result);
            }
        }
    }
}
