﻿using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpheliasOasisOtel
{
    public partial class Yedekleme : Form
    {
        private int dbBackup_Complete;

        public Yedekleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Yedeklenecek yolu belirtiniz.";
            saveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak)|*.bak | Tüm Dosyalar(*.*)|*.*";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox3.Text = saveFileDialog1.FileName;
            }
        }

        private void buttonYedekle_Click(object sender, EventArgs e)
        {
            Server dbServer = new Server(new ServerConnection(textBox1.Text));
            Backup dbBackup = new Backup();
            dbBackup.Action = BackupActionType.Database;
            dbBackup.Database = textBox2.Text;
            dbBackup.Devices.AddDevice(textBox3.Text, DeviceType.File);
            dbBackup.Initialize = false;
            dbBackup.SqlBackup(dbServer);
            dbBackup.Complete += DbBackup_Completed;
            dbBackup.SqlBackup(dbServer);

        }

        private void DbBackup_Completed(object sender, ServerMessageEventArgs e)
        {
           try
            {
                MessageBox.Show("Yedekleme işlemi gerçekleşti.", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }
    }
}
