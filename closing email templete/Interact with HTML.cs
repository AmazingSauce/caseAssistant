// for reference of trying to interact with HTMl
// http://msdn.microsoft.com/en-us/library/system.net.httpwebrequest.aspx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using NUnit.Framework;
using WatiN.Core;


namespace closing_email_templete
{
    [TestFixture]
    class Interact_with_HTML
    {

        [Test]
        [RequiresSTA]
        public void Should_Start_Google()
        {
            using (var browser = new IE("google.com"))
            {

                browser.TextField(Find.ByName("q")).TypeText("Hello World");
                browser.Button(Find.ByName("btnG")).Click();
            }

        }
    }
}
