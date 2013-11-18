﻿using System;
using System.Linq;
using DynamicSPARQLSpace;
using Should.Fluent;
using VDS.RDF;
using VDS.RDF.Query;
using Xunit.Extensions;

namespace LINQtoSPARQLSpace.Tests
{
    public class LimitFixture
    {
        [Theory(DisplayName = "Limit & offset "),
        InlineData(@"@prefix dc:   <http://purl.org/dc/elements/1.1/> .
                @prefix :     <http://example.org/book/> .
                @prefix ns:   <http://example.org/ns#> .

                :book1  dc:title  ""SPARQL Tutorial"" .
                :book1  ns:price  42 .
                :book2  dc:title  ""The Semantic Web"" .
                :book2  ns:price  23 .")]
        public void TestLimit1(string data)
        {
            var query = TestDataProvider.GetQuerable<dynamic>(data);
            var list = query.Match("?x ns:price ?price").And(p: "dc:title", o: "?title")
                .Select("?title ?price")
                .OrderBy("desc(?price)")
                .Limit(1)
                .Offset(1)
                .Prefix("dc:", "http://purl.org/dc/elements/1.1/")
                .Prefix("ns:", "http://example.org/ns#")
                .AsEnumerable()
                .ToList();

            list.Count.Should().Equal(1);
            ((int)list.First().price).Should().Equals(23);

        }
    }
}
