using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace E_PupilStdMgt.src.utill
{
    class GenerateCSV
    {
        public void ToCsV(DataGridView dGV, string filename)
        {
            if (dGV.Rows.Count > 0)
            {
                string stOutput = "";
                // Export titles:
                string sHeaders = "";

                for (int j = 0; j < dGV.Columns.Count; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + ",";
                stOutput += sHeaders + "\r\n";
                // Export data.
                for (int i = 0; i < dGV.RowCount; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    {
                        string cellValue = Convert.ToString(dGV.Rows[i].Cells[j].Value);
                        if (cellValue.Contains(","))
                        {
                            cellValue = cellValue.Replace(",", string.Empty);
                        }

                        if (cellValue.Contains(Environment.NewLine))
                        {
                            cellValue = cellValue.Replace(Environment.NewLine, " ");
                        }
                        stLine = stLine.ToString() + cellValue.ToString() + ",";
                    }

                    stOutput += stLine + "\r\n";
                }
                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length); //write the encoded file
                bw.Flush();
                bw.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("No Record To Generete!", "Info");
            }
        }
    }
}
