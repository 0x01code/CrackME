using SKGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackME
{
    internal class SerialKey
    {
        private string secretPhase = "eXmeEKNTF4gHHlmMHy44";
        public string generate(int day)
        {
            Generate generate = new Generate();
            generate.secretPhase = this.secretPhase;
            return generate.doKey(day);
        }

        public int validate(string key)
        {
            Validate validate = new Validate();
            validate.secretPhase = this.secretPhase;
            validate.Key = key;
            if (validate.IsValid == false) {
                return 0;
            }
            return validate.DaysLeft;
        }
    }
}
