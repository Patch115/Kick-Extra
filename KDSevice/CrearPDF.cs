using System;
using System.Collections.Generic;
using System.Text;
using KDControl;
using Microsoft.AspNetCore.Hosting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Globalization;

namespace KDSevice
{
    public static class CrearPDF
    {
        public static MemoryStream Crearpdf(IList<SupervisorS> supervisors)
        {
            Document document = new Document(PageSize.A4);
            MemoryStream stream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            PdfPTable table = new PdfPTable(8);
            document.Open();
            document.AddTitle("Supervisores");
            table.AddCell("Nombre");
            table.AddCell("Apellido paterno");
            table.AddCell("Apellido Materno");
            table.AddCell("Usuario");
            table.AddCell("Contraseña");
            table.AddCell("Fecha de registro");
            table.AddCell("Fecha de modificación");
            table.AddCell("Estado");
            
            foreach (var item in supervisors)
            {
                table.AddCell(item.Nombre);
                table.AddCell(item.Apellido_paterno);
                table.AddCell(item.Apellido_materno);
                table.AddCell(item.Usuario);
                table.AddCell(item.Contraseña);
                table.AddCell(item.CreateAT.ToShortDateString());
                table.AddCell(item.UpdateAT.ToString());
                table.AddCell(item.Status.ToString());
                //if (item.Status)
                //{
                //    table.AddCell("Activo");
                //}
                //else
                //{
                //    table.AddCell("Inactivo");
                //}
            }
            document.Add(table);
            writer.CloseStream = false;
            document.Close();
            stream.Position = 0;
            return stream;
        }
    }
}
