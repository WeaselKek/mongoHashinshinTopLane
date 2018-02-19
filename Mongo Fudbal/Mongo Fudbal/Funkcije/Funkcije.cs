﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mongo_Fudbal.Funkcije
{
    public class Provera
    {

        public static bool chkIfSelected(DataGridView d)
        {


            if (d.SelectedRows.Count == 0 || d.CurrentRow == null)
            {
                MessageBox.Show("Molimo selektujte neki podatak");
                return false;
            }
            if (d.SelectedRows.Count > 1)
            {
                MessageBox.Show("Molimo selektujte samo jedan red");
                return false;
            }
            return true;

        }
    }
}
