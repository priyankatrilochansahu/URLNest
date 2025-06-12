using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.searchquery;
using System.Web.Http.Cors;


namespace WebApplication2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SearchController : ApiController
    {
        private static List<searchoutput> allLinks = new List<searchoutput>
        {
            new searchoutput { title = "Angular Docs", url = "https://angular.io/docs" },
            new searchoutput { title = "C# Tutorial", url = "https://learn.microsoft.com/en-us/dotnet/csharp/" },
            new searchoutput { title = "Google", url = "https://www.google.com" },
            new searchoutput { title = "Stack Overflow", url = "https://stackoverflow.com" },
            new searchoutput { title = "Mozilla Developer Network", url = "https://developer.mozilla.org" },
            new searchoutput { title = "W3Schools", url = "https://www.w3schools.com" },
            new searchoutput { title = "GitHub", url = "https://github.com" },
            new searchoutput { title = "FreeCodeCamp", url = "https://www.freecodecamp.org" },
            new searchoutput { title = "GeeksforGeeks", url = "https://www.geeksforgeeks.org" },
            new searchoutput { title = "HackerRank", url = "https://www.hackerrank.com" },
            new searchoutput { title = "LeetCode", url = "https://leetcode.com" },
            new searchoutput { title = "Figma", url = "https://www.figma.com" },
            new searchoutput { title = "Canva", url = "https://www.canva.com" },
            new searchoutput { title = "Coursera", url = "https://www.coursera.org" },
            new searchoutput { title = "National Geographic", url = "https://www.nationalgeographic.com" },
            new searchoutput { title = "The Verge", url = "https://www.theverge.com" },
            new searchoutput { title = "Wired", url = "https://www.wired.com" },
            new searchoutput { title = "TED", url = "https://www.ted.com" },
            new searchoutput { title = "Google Meet", url = "https://meet.google.com" },
            new searchoutput { title = "WhatsApp Web", url = "https://web.whatsapp.com" },
            new searchoutput { title = "ChatGPT", url = "https://chat.openai.com" },
            new searchoutput { title = "Zomato", url = "https://www.zomato.com" },
            new searchoutput { title = "Swiggy", url = "https://www.swiggy.com" },
            new searchoutput { title = "Amazon Prime Video", url = "https://www.primevideo.com" },
            new searchoutput { title = "Flipkart", url = "https://www.flipkart.com" },
            new searchoutput { title = "Meesho", url = "https://www.meesho.com" },
            new searchoutput { title = "Netflix", url = "https://www.netflix.com" },
            new searchoutput { title = "Spotify", url = "https://www.spotify.com" },
            new searchoutput { title = "Visual Studio", url = "https://visualstudio.microsoft.com" },
            new searchoutput { title = "YouTube", url = "https://www.youtube.com" },
            new searchoutput { title = "Instagram", url = "https://www.instagram.com" },
            new searchoutput { title = "Nykaa", url = "https://www.nykaa.com" },
            new searchoutput { title = "Amazon Shopping", url = "https://www.amazon.in" },
            new searchoutput { title = "Myntra", url = "https://www.myntra.com" },
            new searchoutput { title = "LinkedIn", url = "https://www.linkedin.com" },
            new searchoutput { title = "Naukri", url = "https://www.naukri.com" },
            new searchoutput { title = "Apple", url = "https://www.apple.com" }
        };

        [HttpPost]
        [Route("api/search")]
        public IHttpActionResult SearchLinks([FromBody] searchrequest request)
        {
            var results = allLinks
                .Where(link => link.title.ToLower().Contains(request.query.ToLower()))
                .ToList();

            return Ok(results);
        }
    }
}