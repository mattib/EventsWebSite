using EventsWebSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventWebSite.Utilities
{
    public static class CustomExtentions
    {
        //public static HtmlString ShowTestGrid(this HtmlHelper htmlHelper)
        //{
        //    var pairs = new KeyValuePair<string, string>[3];
        //    for (var i = 0; i < 3; i++)
        //    {
        //        pairs[i] = new KeyValuePair<string, string>("Key" + i, "Vlaue" + i);
        //    }

        //    var stringWriter = new StringWriter();

        //    using (var writer = new HtmlTextWriter(stringWriter))
        //    {
        //        writer.RenderBeginTag(HtmlTextWriterTag.Table);

        //        foreach (var keyValuePair in pairs)
        //        {
        //            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
        //            writer.RenderBeginTag(HtmlTextWriterTag.Td);
        //            writer.Write(keyValuePair.Key);
        //            writer.RenderEndTag();
        //            writer.RenderBeginTag(HtmlTextWriterTag.Td);
        //            writer.Write(keyValuePair.Value);
        //            writer.RenderEndTag();
        //            writer.RenderEndTag();
        //        }
        //        writer.RenderEndTag();
        //    }

        //    return new HtmlString(stringWriter.ToString());
        //}

        public static HtmlString EventsGrid(this HtmlHelper htmlHelper, Event[] events)
        {

            var stringWriter = new StringWriter();

            using (var writer = new HtmlTextWriter(stringWriter))
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Table);

                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Event Id");
                writer.RenderEndTag();
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Event Text");
                writer.RenderEndTag();
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Event Type number");
                writer.RenderEndTag();
                writer.RenderEndTag();

                foreach(var item in events)
                {
                    writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                    writer.RenderBeginTag(HtmlTextWriterTag.Td);
                    writer.Write(item.Id.ToString());
                    writer.RenderEndTag();
                    writer.RenderBeginTag(HtmlTextWriterTag.Td);
                    writer.Write(item.Text);
                    writer.RenderEndTag();
                    writer.RenderBeginTag(HtmlTextWriterTag.Td);
                    writer.Write(item.EventType.ToString());
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                }
                writer.RenderEndTag();
            }

             return new HtmlString(stringWriter.ToString());
        }


        //public static HtmlString Render(HtmlTextWriter htmlWriter)
        //{
        //    htmlWriter.NewLine = String.Empty;
        //    htmlWriter.BeginRender();
        //    //if (CssClass.NotNullOrEmpty())
        //    //{
        //    //    htmlWriter.AddAttribute(HtmlTextWriterAttribute.Class, CssClass);
        //    //}

        //    //if (Id.NotNullOrEmpty())
        //    //{
        //    //    htmlWriter.AddAttribute(HtmlTextWriterAttribute.Id, Id);
        //    //}

        //    //AddMetadataAttributes(m_metadataBuilder);
        //    //if (m_metadataBuilder.Metadata.Count > 0)
        //    //{
        //    //    m_metadataBuilder.Metadata.ForEach(
        //    //        keyValue => htmlWriter.AddAttribute("data-" + keyValue.Key, keyValue.Value));
        //    //}
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Div);

        //    RenderTable(htmlWriter);

        //    htmlWriter.RenderEndTag();

        //    htmlWriter.EndRender();


        //    var html = htmlWriter.ToString();
        //    return new HtmlString(html);
        //}

        //private static void RenderTable(HtmlTextWriter htmlWriter)
        //{
        //    //    htmlWriter.AddAttribute(HtmlTextWriterAttribute.Cellpadding, "0");
        //    //    htmlWriter.AddAttribute(HtmlTextWriterAttribute.Cellspacing, "0");
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Table);
        //    //RenderTableHeader(htmlWriter);

        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Tbody);
        //    htmlWriter.RenderEndTag();

        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Tfoot);
        //    // stats
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Tr);

        //    htmlWriter.AddAttribute(HtmlTextWriterAttribute.Class, "Stats");
        //    //htmlWriter.AddAttribute(HtmlTextWriterAttribute.Colspan, ListMetadata.Columns.Length.ToString());
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Td);
        //    //htmlWriter.Write("GridView.Stats.Displaying".LocalizeByKey());
        //    htmlWriter.AddAttribute(HtmlTextWriterAttribute.Class, "StartIndex");
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Span);
        //    htmlWriter.RenderEndTag();
        //    //htmlWriter.Write("GridView.Stats.To".LocalizeByKey());
        //    htmlWriter.AddAttribute(HtmlTextWriterAttribute.Class, "EndIndex");
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Span);
        //    htmlWriter.Write("0");
        //    htmlWriter.RenderEndTag();
        //    // htmlWriter.Write("GridView.Stats.Of".LocalizeByKey());
        //    htmlWriter.AddAttribute(HtmlTextWriterAttribute.Class, "TotalCount");
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Span);
        //    htmlWriter.Write("0");
        //    htmlWriter.RenderEndTag();
        //    //htmlWriter.Write("GridView.Stats.LastRefresh".LocalizeByKey());
        //    htmlWriter.AddAttribute(HtmlTextWriterAttribute.Class, "LastRefresh");
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Span);
        //    //htmlWriter.Write(DateTime.UtcNow.ToShortTimeDisplayString());
        //    htmlWriter.RenderEndTag();

        //    htmlWriter.RenderEndTag();
        //    htmlWriter.RenderEndTag();

        //    // paging
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Tr);
        //    //htmlWriter.AddAttribute(HtmlTextWriterAttribute.Colspan, ListMetadata.Columns.Length.ToString());
        //    htmlWriter.RenderBeginTag(HtmlTextWriterTag.Td);
        //    htmlWriter.RenderEndTag();
        //    htmlWriter.RenderEndTag();

        //    htmlWriter.RenderEndTag();
        //    htmlWriter.RenderEndTag();
        //}

    }


}