using Microsoft.VisualBasic.CompilerServices;
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
        private static StringBuilder html_summary = new StringBuilder();

        private static string title_feature = null;
        private static int contp = 0;
        private static int contf = 0;

        private static string align_right = "right";
        private static string align_left = "left";
        private static string background = "#DCDCDC";
        private static string style_table = "width: 100%";

        public static void InsertReportData(string feature, string scenario, string tag)
        {
            if (title_feature != feature)
            {
                if (title_feature != null)
                {
                    html_summary.Append($"<tr>");
                    html_summary.Append($"<td>{title_feature}</td>");
                    html_summary.Append($"<td align={align_right}>{contp + contf}</td>");
                    html_summary.Append($"<td align={align_right}>{contp}</td>");
                    html_summary.Append($"<td align={align_right}>{contf}</td>");
                    html_summary.Append(@"</tr>");

                    html_buffer.Append(@"</table>");
                }

                //header
                html_buffer.Append($"<H3> FUNCIONALIDADE: {feature} </H3>");

                //style
                html_buffer.Append(@"<style>");
                html_buffer.Append(@"table, th, td {");
                html_buffer.Append(@"border: 1px solid black;");
                html_buffer.Append(@"border-collapse: collapse; }");
                html_buffer.Append(@"</style>");

                //table
                html_buffer.Append($"<table style={style_table}>");
                html_buffer.Append(@"<tr>");
                html_buffer.Append($"<th bgcolor={background}>Cenário</th>");
                html_buffer.Append($"<th bgcolor={background} >Estado</th>");

                html_buffer.Append(@"</tr>");

                contp = 0;
                contf = 0;
            }

            title_feature = feature;
            string scenario_color = "blue";

            string tag_color = "";
            if (tag =="passou")
            {
                tag_color = "green";
                contp++;
            }
            if (tag == "falhou")
            {
                tag_color = "red";
                contf++;
            }
            else if (tag == "bloqueado")
            {
                tag_color = "purple";
            }

            html_buffer.Append(@"<tr>");
            html_buffer.Append($"<td> <font color={scenario_color}> {scenario} </font> </td>");
            html_buffer.Append($"<td> <b> <font color={tag_color}> {tag.ToUpper()} </font> </b> </td>");
            html_buffer.Append(@"</tr>");
        }

        public static string GetReport()
        {
            html_summary.Append($"<tr>");
            html_summary.Append($"<td>{title_feature}</td>");
            html_summary.Append($"<td align={align_right}>{contp + contf}</td>");
            html_summary.Append($"<td align={align_right}>{contp}</td>");
            html_summary.Append($"<td align={align_right}>{contf}</td>");
            html_summary.Append(@"</tr>");
            html_summary.Append(@"</table>");

            html_buffer.Append(@"</table>");
            
            StringBuilder html = new StringBuilder();

            html.Append(@"<H3> RESUMO </H3>");
            html.Append(@"<style>");
            html.Append(@"table, th, td {");
            html.Append(@"border: 1px solid black;");
            html.Append(@"border-collapse: collapse; }");
            html.Append(@"</style>");
            html.Append($"<table style={style_table}>");
            html.Append(@"<tr>");
            html.Append($"<th align={align_left}, bgcolor={background}>Funcionalidade</th>");
            html.Append($"<th bgcolor={background}>Cenários</th>");
            html.Append($"<th bgcolor={background}>Sucesso</th>");
            html.Append($"<th bgcolor={background}>Falhou</th>");
            html.Append(@"</tr>");

            return html.ToString() + html_summary.ToString() + html_buffer.ToString();
        }
    }
}
