using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SellIt.Reports;

namespace SellIt
{
    public partial class frmReportViewer : Form
    {
        string rpt;
        int key;
        string sdate,edate,txfrom,txto,branch;
        public frmReportViewer(string rptName)
        {
            InitializeComponent();
            Text += "[" + rptName + " Report]";
            MdiParent = frmMain.Desk;
            rpt = rptName;
        }
        public frmReportViewer(string rptName, string sdt, string edt)
        {
            InitializeComponent();
            Text += "[" + rptName + " Report]";
            MdiParent = frmMain.Desk;
            rpt = rptName;
            sdate = sdt;
            edate = edt;
        }
        public frmReportViewer(string rptName, int k)
        {
            InitializeComponent();
            MdiParent = frmMain.Desk;
            rpt = rptName;
            key = k;
        }
        public frmReportViewer(string rptName, int k,string br)
        {
            InitializeComponent();
            MdiParent = frmMain.Desk;
            rpt = rptName;
            key = k;
            branch = br;
        }
        public frmReportViewer(string rptName, int k,string fr,string to)
        {
            InitializeComponent();
            MdiParent = frmMain.Desk;
            rpt = rptName;
            key = k;
            txfrom = fr;
            txto = to;
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            if (rpt == "GON"||rpt=="SRN")
            {
                try
                {
                    rptGoodsOrdNote g=null;
                    OleDbCommand cmd=null;
                    
                    if (rpt == "GON")
                    {
                        SellIt.Reports.dsRptGoodsOrdNoteTableAdapters.GoodsOrdNoteTableAdapter ad = new SellIt.Reports.dsRptGoodsOrdNoteTableAdapters.GoodsOrdNoteTableAdapter();
                        g = new rptGoodsOrdNote();
                        g.SetDataSource((DataTable)ad.GetData(key));

                        rptVw.ReportSource = g;
                        g.SetParameterValue("prep", "Prepared By " + frmMain.username);
                        cmd = new OleDbCommand("SELECT name FROM branches WHERE [id]=" + frmMain.branchcode, frmMain.con);

                        Text = "Goods Order Note";
                        g.SetParameterValue("title", "Goods Order Note");
                        g.SetParameterValue("branch", "From " + cmd.ExecuteScalar().ToString() + " Branch");
                    }
                    else if (rpt == "SRN")
                    {
                        OleDbDataAdapter ad = new OleDbDataAdapter("SELECT 'SRN' + Mid([SRN Header].SRNID + 10000000, 2) AS SRNID, [SRN Header].[Date], [SRN Header].[Time], [SRN Header].[Total Amount], 'P' + Mid([SRN Details].ProductID + 100000, 2) AS [Product ID], Products.Name AS [Product Name], [SRN Details].Qty, [SRN Details].CostPrice, [SRN Details].Amount FROM (([SRN Header] INNER JOIN [SRN Details] ON [SRN Header].SRNID = [SRN Details].SRNID) INNER JOIN Products ON [SRN Details].ProductID = Products.ID) WHERE [SRN Header].SRNID = "+key, frmMain.con);
                        DataSet ds = new DataSet();
                        
                        ad.Fill(ds,"GoodsOrdNote");
                        g = new rptGoodsOrdNote();
                        g.SetDataSource(ds);
                        rptVw.ReportSource = g;
                        Text = "Stock Requisition Note";
                        g.SetParameterValue("title", "Stock Requisition Note");
                        g.SetParameterValue("prep", "Prepared By " + frmMain.username);
                        cmd = new OleDbCommand("select name from branches where [id]=" + frmMain.branchcode, frmMain.con);
                        g.SetParameterValue("branch", "By " + cmd.ExecuteScalar().ToString() + " Branch, Requesting From " + branch + " Branch");
                    }
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
            else if (rpt == "GRN")
            {
                
                try
                {
                    Text = "Goods Receive Note";
                    OleDbDataAdapter ad = new OleDbDataAdapter("SELECT id as prodcode,name as prodnm,description as descr,qty as recievedstock from products,grndetails where products.id=grndetails.productid and grnid=" + key, frmMain.con);
                    dsRptGRN ds = new dsRptGRN();
                    ad.Fill(ds, "GRN");
                    rptGRN g = new rptGRN();
                    g.SetDataSource(ds);

                    rptVw.ReportSource = g;
                    g.SetParameterValue("prep", "Prepared By " + frmMain.username);
                    OleDbCommand cmd = new OleDbCommand("SELECT name FROM branches WHERE [id]=" + frmMain.branchcode, frmMain.con);
                    g.SetParameterValue("br", "From " + cmd.ExecuteScalar().ToString() + " Branch");
                    g.SetParameterValue("gonid", "Ref GON "+branch);
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
            else if (rpt == "Sales Invoice")
            {
                try
                {
                    Text = rpt;
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM SalesInvoice", frmMain.con);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("SELECT product AS [Code],products.name AS [Name],products.description AS [Description], products.price AS [Unit Price], [sales details].quantity AS Quantity, [sales details].price AS Total FROM products,sales,[sales details] WHERE products.[id]=[sales details].product AND sales.[id]=[sales details].sale AND sales.[id]=" + key, frmMain.con);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cmd = new OleDbCommand("INSERT INTO SalesInvoice(code,name,description,[unit price],quantity,total) VALUES(@p0,@p1,@p2,@p3,@p4,@p5)", frmMain.con);
                        cmd.Parameters.AddWithValue("@p0", rd.GetInt32(0));
                        cmd.Parameters.AddWithValue("@p1", rd.GetString(1));
                        cmd.Parameters.AddWithValue("@p2", rd.GetString(2));
                        cmd.Parameters.AddWithValue("@p3", rd.GetDecimal(3));
                        cmd.Parameters.AddWithValue("@p4", rd.GetDecimal(5));
                        cmd.Parameters.AddWithValue("@p5", rd.GetInt32(4));
                        cmd.ExecuteNonQuery();
                    }

                    Text = rpt;
                    dsSalesInvoice ds = new dsSalesInvoice();
                    OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM SalesInvoice", frmMain.con);
                    ad.Fill(ds, "SalesInvoice");

                    rptSalesInvoice inv = new rptSalesInvoice();
                    inv.SetDataSource(ds);
                    rptVw.ReportSource = inv;
                    cmd = new OleDbCommand("SELECT name from branches WHERE [id]=" + frmMain.branchcode, frmMain.con);
                    inv.SetParameterValue("br", cmd.ExecuteScalar().ToString() + " Branch");
                    inv.SetParameterValue("user", "Prepared By " + frmMain.username);
                    cmd = new OleDbCommand("SELECT discount from sales WHERE [id]=" + (key), frmMain.con);
                    inv.SetParameterValue("discount", cmd.ExecuteScalar());
                    inv.SetParameterValue("invno", "Inv. No SL" + key.ToString().PadLeft(6, '0'));
                }
                catch (Exception ex) { dataManipulate.showError(ex); }

            }
            else if (rpt == "Daily Sales" || rpt == "Today Sales" || rpt == "Monthly Sales")
            {
                try
                {
                    OleDbCommand cmd;
                    cmd = new OleDbCommand("DELETE FROM rptsales", frmMain.con);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("SELECT 'P' & Mid(Products.ID+100000,2) AS [Product ID], Products.Name, Products.Description, Products.Price, Sum([Sales Details].Quantity) AS [Sum Of Quantity], Sum([Sales Details].Price*[Quantity]) AS Income FROM Sales RIGHT JOIN (Products RIGHT JOIN [Sales Details] ON Products.ID=[Sales Details].Product) ON Sales.ID=[Sales Details].Sale WHERE sales.date BETWEEN @dt1 AND @dt2 GROUP BY 'P' & Mid(Products.ID+100000,2), Products.Name, Products.Description, Products.Price", frmMain.con);
                    cmd.Parameters.AddWithValue("@dt1", sdate);
                    cmd.Parameters.AddWithValue("@dt2", edate);
                    OleDbDataReader rd = cmd.ExecuteReader();

                    if (!rd.HasRows)
                    {
                        MessageBox.Show("No data to generate report", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    while (rd.Read())
                    {
                        cmd = new OleDbCommand("INSERT INTO rptSales VALUES(@p0,@p1,@p2,@p3,@p4,@p5)", frmMain.con);
                        cmd.Parameters.AddWithValue("@p0", rd.GetString(0));
                        cmd.Parameters.AddWithValue("@p1", rd.GetString(1));
                        cmd.Parameters.AddWithValue("@p2", rd.GetString(2));
                        cmd.Parameters.AddWithValue("@p3", rd.GetDecimal(3));
                        cmd.Parameters.AddWithValue("@p4", rd.GetValue(4));
                        cmd.Parameters.AddWithValue("@p5", rd.GetValue(5));
                        cmd.ExecuteNonQuery();
                    }

                    OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM rptsales", frmMain.con);
                    dsRptSales ds = new dsRptSales();
                    ad.Fill(ds, "rptsales");

                    rptSales sl = new rptSales();
                    sl.SetDataSource(ds);

                    rptVw.ReportSource = sl;
                    if (rpt == "Today Sales" || (rpt == "Daily Sales" && sdate == edate))
                        sl.SetParameterValue("Date", "As at " + sdate);

                    else if (rpt == "Daily Sales" && sdate != edate)
                        sl.SetParameterValue("Date", "From " + sdate + " To " + edate);

                    else if (rpt == "Monthly Sales")
                    {
                        DateTime month = Convert.ToDateTime(sdate);
                        string[] months ={ "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                        sl.SetParameterValue("Date", "As at " + months[month.Month - 1] + " ," + month.Year);
                    }

                    sl.SetParameterValue("prep", frmMain.username);
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
            else if (rpt == "Daily Orders" || rpt == "Today Orders" || rpt == "Monthly Orders")
            {
                try
                {
                    SellIt.Reports.dsRptOrdersTableAdapters.rptOrdersTableAdapter ad = new SellIt.Reports.dsRptOrdersTableAdapters.rptOrdersTableAdapter();
                    rptOrders r = new rptOrders();
                    r.SetDataSource((DataTable)ad.GetData(sdate,edate));
                    rptVw.ReportSource = r;

                    if (rpt == "Today Orders" || (rpt == "Daily Orders" && sdate == edate))
                        r.SetParameterValue("Date", "As at " + sdate);

                    else if (rpt == "Daily Orders" && sdate != edate)
                        r.SetParameterValue("Date", "From " + sdate + " To " + edate);

                    else if (rpt == "Monthly Orders")
                    {
                        DateTime month = Convert.ToDateTime(sdate);
                        string[] months ={ "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                        r.SetParameterValue("Date", "As at " + months[month.Month - 1] + " ," + month.Year);
                    }

                    r.SetParameterValue("prep", frmMain.username);
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
            else if (rpt == "Reorder")
            {
                Reports.dsRptReorderTableAdapters.ReportTableAdapter ad = new Reports.dsRptReorderTableAdapters.ReportTableAdapter();
                Reports.dsRptReorder.ReportDataTable tbl = new dsRptReorder.ReportDataTable();

                ad.Fill(tbl);

                rptReorder rep = new rptReorder();
                rep.SetDataSource((DataTable)tbl);
                rptVw.ReportSource = rep;
                rep.SetParameterValue("prep", "Prepared By " + frmMain.username);
            }
            else if (rpt == "OrdersCust")
            {
                SellIt.Reports.dsRptOrdersCustTableAdapters.OrdersCustTableAdapter ad = new SellIt.Reports.dsRptOrdersCustTableAdapters.OrdersCustTableAdapter();
                rptOrdersCust r = new rptOrdersCust();
                r.SetDataSource((DataTable)ad.GetData(key.ToString()));
                rptVw.ReportSource = r;
            }
            else if (rpt == "Full Stock")
            {
                SellIt.Reports.dsRptStocksTableAdapters.Report_StockTableAdapter ad = new Reports.dsRptStocksTableAdapters.Report_StockTableAdapter();
                Reports.dsRptStocks.Report_StockDataTable tbl = new Reports.dsRptStocks.Report_StockDataTable();
                
                ad.Fill(tbl);
                
                rptStocks rep = new rptStocks();
                rep.SetDataSource((DataTable)tbl);
                rptVw.ReportSource = rep;
                rep.SetParameterValue("par", "Full Stocks");
                rep.SetParameterValue("prep", "Prepared By "+ frmMain.username);
            }

            else if (rpt == "Stock Transfer" || rpt=="StockTxByID")
            {
                try
                {
                    OleDbDataAdapter ad = new OleDbDataAdapter("SELECT [id],name,description,qty,value FROM products INNER JOIN [transfer details] ON products.[id]=[transfer details].product WHERE [transfer details].Txid=" + key, frmMain.con);
                    dsRptStockTx ds = new dsRptStockTx();

                    ad.Fill(ds, "tblStockTx");
                    rptStockTx tt = new rptStockTx();
                    tt.SetDataSource(ds);
                    rptVw.ReportSource = tt;
                    tt.SetParameterValue("prep", "Prepared by " + frmMain.username);
                    tt.SetParameterValue("txed", "Transferred from " + txfrom + " branch To " + txto + " branch");
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
            //else if (rpt == "StockTxByDate")
            //{
            //    OleDbDataAdapter ad = new OleDbDataAdapter("SELECT products.[id],products.name,description,branches.name as [Transferrd to] ,qty,value FROM products, [transfer details], [stock transfers],branches WHERE products.[id]=[transfer details].product AND [stock transfers].[txid]=[transfer details].txid AND branches.[id]=[stock transfers].branch and  [stock transfers].date between @p1 and @p2 order by branches.name", frmMain.con);
            //    ad.SelectCommand.Parameters.Add("@p1", sdate);
            //    ad.SelectCommand.Parameters.Add("@p2", edate);
            //    dsRptStockTxByDate ds = new dsdsRptStockTxByDate();

            //    ad.Fill(ds, "tblStockTx");
            //    rptStockTx tt = new rptStockTx();
            //    tt.SetDataSource(ds);
            //    rptVw.ReportSource = tt;
            //    tt.SetParameterValue("prep", "Prepared by " + frmMain.username);
            //}

            else if (rpt == "Payments")
            {
                SellIt.Reports.rptPaymentsTableAdapters.PaymentsTableAdapter ad = new SellIt.Reports.rptPaymentsTableAdapters.PaymentsTableAdapter();
                rptPayment p = new rptPayment();
                p.SetDataSource((DataTable)ad.GetData(sdate,edate));
                rptVw.ReportSource=p;
            }
            else if (rpt == "User By Date")
            {
                SellIt.Reports.dsRptUserLoginTableAdapters.UserLogByDateTableAdapter ad = new SellIt.Reports.dsRptUserLoginTableAdapters.UserLogByDateTableAdapter();
                rptUserLogByDate r = new rptUserLogByDate();
                r.SetDataSource((DataTable)ad.GetData(sdate, edate));
                rptVw.ReportSource = r;
                if (sdate == edate)
                    r.SetParameterValue("day", "For the day - " + sdate);
                else
                    r.SetParameterValue("day", "From " + sdate + " To " + edate);
            }

            else if (rpt == "User By Name" || rpt == "User By ID")
            {
                SellIt.Reports.dsRptUserLoginTableAdapters.UserLogByUserTableAdapter ad = new SellIt.Reports.dsRptUserLoginTableAdapters.UserLogByUserTableAdapter();
                rptUserLogByUser u = new rptUserLogByUser();
                u.SetDataSource((DataTable)ad.GetData(key));
                rptVw.ReportSource = u;
            }
            else if (rpt == "Order Invoice")
            {
                Text = rpt;
                try
                {
                    OleDbDataAdapter ad = new OleDbDataAdapter("SELECT [Order Details].Product AS Code, Products.Name, Products.Description, Products.Price AS [Unit Price], [Order Details].Quantity, [Order Details].Price AS Total FROM ((Products INNER JOIN [Order Details] ON Products.ID = [Order Details].Product) INNER JOIN Orders ON [Order Details].[Order] = Orders.ID) WHERE Orders.ID =" + key, frmMain.con);
                    dsOrderInvoice ds = new dsOrderInvoice();

                    OleDbCommand cmd = new OleDbCommand("SELECT Customers.FirstName, Customers.LastName, Branches.Name AS Branch, Orders.[Placement Date], Orders.[Order Date], Orders.Total, Orders.Discount, Payments.Amount FROM  ((((Customers INNER JOIN Orders ON Customers.ID = Orders.Customer) INNER JOIN Users ON Orders.[User] = Users.ID) INNER JOIN Branches ON Orders.Branch = Branches.ID) INNER JOIN payments ON Payments.ID = Orders.Payment) WHERE Orders.ID =" + key, frmMain.con);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    rd.Read();

                    ad.Fill(ds, "tblOrderInv");
                    rptOrderInvoice inv = new rptOrderInvoice();
                    inv.SetDataSource(ds);

                    rptVw.ReportSource = inv;
                    inv.SetParameterValue("cd", "kkkk");
                    inv.SetParameterValue("prep", "Prepared by " + frmMain.username);
                    inv.SetParameterValue("cust", "To Customer : " + rd.GetString(0) + " " + rd.GetString(1));
                    inv.SetParameterValue("branch", rd.GetValue(2) + " Branch");
                    inv.SetParameterValue("place_dt", "Orderd on " + Convert.ToDateTime(rd.GetValue(3)).ToShortDateString());
                    inv.SetParameterValue("order_dt", "Deliverd on " + Convert.ToDateTime(rd.GetValue(4)).ToShortDateString());
                    inv.SetParameterValue("GT", rd.GetValue(5));
                    inv.SetParameterValue("discount", rd.GetValue(6));
                    inv.SetParameterValue("payment", rd.GetValue(7));
                    inv.SetParameterValue("invno", "Inv. No: OR" + key.ToString().PadLeft(6, '0'));


                    rd.Close();
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
            else if (rpt == "Debtors")
            {
                SellIt.Reports.dsRptDebtorsTableAdapters.OverDueCustomersTableAdapter ad = new SellIt.Reports.dsRptDebtorsTableAdapters.OverDueCustomersTableAdapter();
                rptDebtors rp = new rptDebtors();
                rp.SetDataSource((DataTable)ad.GetData());
                rptVw.ReportSource = rp;
            }
            else if (rpt == "Customers")
            {
                SellIt.Reports.dsRptCustomersTableAdapters.CustomersTableAdapter ad = new SellIt.Reports.dsRptCustomersTableAdapters.CustomersTableAdapter();
                rptCustomers c = new rptCustomers();
                c.SetDataSource((DataTable)ad.GetData());
                rptVw.ReportSource = c;
            }
            else if (rpt == "Sales Returns")
            {
                SellIt.Reports.dsRptSalesReturnsTableAdapters.SalesReturnsTableAdapter ad = new SellIt.Reports.dsRptSalesReturnsTableAdapters.SalesReturnsTableAdapter();
                rptSalesReturns r = new rptSalesReturns();
                r.SetDataSource((DataTable)ad.GetData(sdate, edate));
                rptVw.ReportSource = r;
            }
            else if (rpt == "Order Returns")
            {
                SellIt.Reports.dsRptOrderReturnsTableAdapters.OrderReturnsTableAdapter ad = new SellIt.Reports.dsRptOrderReturnsTableAdapters.OrderReturnsTableAdapter();
                rptOrderReturns r = new rptOrderReturns();
                r.SetDataSource((DataTable)ad.GetData(sdate, edate));
                rptVw.ReportSource = r;
            }
            else if (rpt == "Products")
            {
                SellIt.Reports.dsRptProductsTableAdapters.ProductsTableAdapter ad = new SellIt.Reports.dsRptProductsTableAdapters.ProductsTableAdapter();
            SellIt.Reports.rptProducts r = new SellIt.Reports.rptProducts();

            r.SetDataSource((DataTable)ad.GetData());
            rptVw.ReportSource = r;
            }

        }
    }
}