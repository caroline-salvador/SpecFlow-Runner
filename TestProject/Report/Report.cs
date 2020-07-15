using MongoDB.Driver.Core.Operations;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace TestProject.Report
{
    static class ManualTestReport
    {
        private static StringBuilder html_buffer = new StringBuilder();
        private static string title_feature = null;
      
        public static void InsertReportData(string feature, string scenario, string tag)
        {
            if (title_feature != feature)
            {
                if (html_buffer.Capacity > 0) html_buffer.Append(@"</table>");

                //Header
                html_buffer.Append($"<H3> FEATURE: {feature} </H3>");

                //style
                html_buffer.Append(@"<style>");
                html_buffer.Append(@"table, th, td {");
                html_buffer.Append(@"border: 1px solid black;");
                html_buffer.Append(@"border-collapse: collapse; }");
                html_buffer.Append(@"table {");
                html_buffer.Append(@"width: 100 %; }");
                html_buffer.Append(@"</style>");

                //table
                html_buffer.Append(@"<table>");
                html_buffer.Append(@"<tr>");
                html_buffer.Append(@"<th>SCENARIO</th>");
                html_buffer.Append(@"<th>STATUS</th>");
                html_buffer.Append(@"</tr>");
            }

            title_feature = feature;

            string color = "red";
            if (tag == "passou") color = "green";
            else if (tag == "bloqueado") color = "purple";
           
            html_buffer.Append(@"<tr>");
            html_buffer.Append($"<td> {scenario} </td>");
            html_buffer.Append($"<td> <b> <font color={color}> {tag.ToUpper()} </font> </b> </td>");
            html_buffer.Append(@"</tr>");
        }

        public static string GetReport()
        {
            return html_buffer.ToString();
        }
    }
}
