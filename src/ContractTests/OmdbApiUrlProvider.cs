using System;
using System.Collections;

namespace ContractTests
{
    public class OmdbApiUrlProvider : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            //            yield return Environment.GetEnvironmentVariable("ContractTestRealServices") == "true"
            yield return  "http://www.omdbapi.com/";
//                : "http://localhost:5842/";
        }
    }
}