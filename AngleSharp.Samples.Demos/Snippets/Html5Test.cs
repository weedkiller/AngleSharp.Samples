﻿namespace AngleSharp.Samples.Demos.Snippets
{
    using AngleSharp.Scripting.JavaScript;
    using System;
    using System.Threading.Tasks;

    // Not used at the moment (wait for more to be integrated)
    class Html5Test// : ISnippet
    {
#pragma warning disable CS1998
        public async Task Run()
#pragma warning restore CS1998
        {
            // We require a custom configuration
            var config = new Configuration();

            // Including the scripting
            config.WithJavaScript();

            // Including the styling
            config.WithCss();

            var document = DocumentBuilder.Html(new Uri("http://html5test.com/"), config);
            var points = document.QuerySelector("#score > .pointsPanel > h2 > strong").TextContent;
            Console.WriteLine("AngleSharp received {0} points form HTML5Test.com", points);
        }
    }
}
