using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SellIt
{
    class dataManipulate
    {
        public static bool delete(string tableName, string fieldName, DataGridView grd)
        {
            bool sucess = false;
            
            if (grd.SelectedRows.Count > 1)
            {
                string records="";
                for (int i = 0; i < grd.SelectedRows.Count; i++)
                {
                    records += grd.SelectedRows[i].Cells[0].EditedFormattedValue.ToString() + "\n";
                }
                if (MessageBox.Show("You have selected multiple rows.\n" + records + "\nWill be deleted. Do you want to continue",  "SellIt-Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return false;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "SellIt-Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return false;
            }
                    OleDbCommand cmd;
                    int c = 0;
                    for (c = 0; c < grd.SelectedRows.Count; c++)
                    {
                        try
                        {
                            cmd = new OleDbCommand("DELETE FROM " + tableName + " WHERE " + fieldName + " =@id", frmMain.con);
                            cmd.Parameters.AddWithValue("@id", grd.SelectedRows[c].Cells[0].EditedFormattedValue.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex) { dataManipulate.showError(ex); }
                    }
                    sucess = true;
                    MessageBox.Show(c.ToString() + " Branch(es) Deleted", "sellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            return sucess;
        }

        public static bool deleteFromTwoTables(string tableName1,string tableName2, string fieldName1,string fieldName2, DataGridView grd)
        {
            bool sucess = false;

            if (grd.SelectedRows.Count > 1)
            {
                string records = "";
                for (int i = 0; i < grd.SelectedRows.Count; i++)
                {
                    records += grd.SelectedRows[i].Cells[0].EditedFormattedValue.ToString() + "\n";
                }
                if (MessageBox.Show("You have selected multiple rows.\n" + records + "\nWill be deleted. Do you want to continue", "SellIt-Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return false;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "SellIt-Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return false;
            }
            OleDbCommand cmd,cmd2;
            int c = 0;
            for (c = 0; c < grd.SelectedRows.Count; c++)
            {
                try
                {
                    cmd = new OleDbCommand("DELETE FROM " + tableName1 + " WHERE " + fieldName1 + " =@id", frmMain.con);
                    cmd2 = new OleDbCommand("DELETE FROM " + tableName2 + " WHERE " + fieldName2 + " =@id", frmMain.con);
                    cmd.Parameters.AddWithValue("@id", grd.SelectedRows[c].Cells[0].EditedFormattedValue.ToString());
                    cmd2.Parameters.AddWithValue("@id", grd.SelectedRows[c].Cells[0].EditedFormattedValue.ToString());
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
            sucess = true;
            MessageBox.Show(c.ToString() + " Branch(es) Deleted", "sellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return sucess;
        }
        public static void showError(Exception ex)
        {
            frmMessage ms = new frmMessage(ex);
            ms.ShowDialog();
        }
    }
}
