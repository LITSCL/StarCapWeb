﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel
{
    public partial class Cliente
    {
        public string NivelTxt
        {
            get
            {
                string texto = "";
                switch (nivel)
                {
                    case 1:
                        texto = "Silver";
                        break;
                    case 2:
                        texto = "Gold";
                        break;
                    case 3:
                        texto = "Platinum";
                        break;
                }
                return texto;
            }
        }
    }
}
