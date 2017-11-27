using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using GetPersianNameOfAirports.Models;

namespace GetPersianNameOfAirports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAirportsName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Start");

            using ( DBMainTestEntities db = new DBMainTestEntities())
            {
                try
                {
                    HtmlWeb web = new HtmlWeb();
                    string url = "https://www.wego.ir/airports/airport-name/" + txtChar.Text;
                    var htmlDoc = web.Load(url);
                    // root.Descendants("div").Where(q => q.Attributes.Contains("class") && q.Attributes["class"].Value.Contains("bh-photo-grid-thumbs-wrapper")).FirstOrDefault();
                    var root = htmlDoc.DocumentNode.SelectNodes(".//*[@id=\'container']").Descendants("ul").Where(q => q.Attributes.Contains("class") && q.Attributes["class"].Value.Contains("airport-names-by-letter")).FirstOrDefault();

                    var nodes = root.Descendants("a").ToList();//.Where(q => q.Name == "a").ToList();

                    foreach (var item in nodes)
                    {
                        if (item.InnerHtml.Contains("فرودگاه"))
                        {
                            string Code = item.ChildNodes.Where(q => q.Name == "span").FirstOrDefault().InnerText;
                            string name = item.InnerText.Replace(Code, "").Replace("\n", "");

                            PersianAirports airport = new PersianAirports()
                            {
                                Code = Code.Replace("(", "").Replace(")", ""),
                                Name = name

                            };

                            db.PersianAirports.Add(airport);
                            db.SaveChanges();
                        }
                        

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            MessageBox.Show("End");

            MessageBox.Show("Merge Conflict");


        }
    }
}
