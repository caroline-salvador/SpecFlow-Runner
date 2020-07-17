using MongoDB.Driver.Core.Operations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;

namespace TestProject.Report
{
    static class ManualTestReport
    {
        private static StringBuilder html_buffer = new StringBuilder();
        private static string title_feature = null;
        private static int contp = 0;
        private static int contf = 0;
        private static string align = "right";

        public static void InsertReportData(string feature, string scenario, string tag)
        {
            if (title_feature != feature)
            {
                if (title_feature != null)
                {
                    html_buffer.Append(@"<tr>");
                    html_buffer.Append(@"<th>Succeeded</th>");
                    html_buffer.Append(@"<th>Failed</th>");
                    html_buffer.Append(@"</tr>");

                    /*html_buffer.Append("<style>");
                    html_buffer.Append("tr {");
                    html_buffer.Append("text - align:right;");
                    html_buffer.Append("background-color:#c0c4c1 }");
                    html_buffer.Append("</style>");*/

                    html_buffer.Append($"<tr align={align}>");
                    html_buffer.Append($"<td>{contp}</td>");
                    html_buffer.Append($"<td>{contf}</td>");
                    html_buffer.Append(@"</tr>");

                    html_buffer.Append(@"</table>");
                }

                //header
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
                html_buffer.Append(@"<th>Scenario</th>");
                html_buffer.Append(@"<th>Succeeded</th>");
                html_buffer.Append(@"<th>Failed</th>");
                html_buffer.Append(@"<th>Blocked</th>");
                html_buffer.Append(@"</tr>");

                contp = 0;
                contf = 0;
            }

            title_feature = feature;
            string scenario_color = "blue";

            html_buffer.Append(@"<tr>");
            html_buffer.Append($"<td> <font color={scenario_color}> {scenario} </font> </td>");

            if (tag == "passou")
            {
                scenario_color = "green";
                contp++;
                html_buffer.Append($"<td> <b> <font color={scenario_color}> {tag.ToUpper()} </font> </b> </td>"); //passou
                html_buffer.Append($"<td></td>"); //falhou
                html_buffer.Append($"<td></td>"); //bloqueado
            }
            else if (tag == "falhou")
            {
                scenario_color = "red";
                contf++;
                html_buffer.Append($"<td></td>"); //passou
                html_buffer.Append($"<td> <b> <font color={scenario_color}> {tag.ToUpper()} </font> </b> </td>"); //falhou
                html_buffer.Append($"<td></td>"); //bloqueado
            }
            else if (tag == "bloqueado")
            {
                scenario_color = "purple";
                html_buffer.Append($"<td></td>"); //passou
                html_buffer.Append($"<td></td>"); //falhou
                html_buffer.Append($"<td> <b> <font color={scenario_color}> {tag.ToUpper()} </font> </b> </td>"); //bloqueado
            }
            
            html_buffer.Append(@"</tr>");
        }

        public static string GetReport()
        {
            html_buffer.Append(@"<tr>");
            html_buffer.Append(@"<th>Succeeded</th>");
            html_buffer.Append(@"<th>Failed</th>");
            html_buffer.Append(@"</tr>");

            html_buffer.Append($"<tr align={align}>");
            html_buffer.Append($"<td>{contp}</td>");
            html_buffer.Append($"<td>{contf}</td>");
            html_buffer.Append(@"</tr>");

            html_buffer.Append(@"</table>");
            return html_buffer.ToString();
        }
    }
}
