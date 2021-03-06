﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEngine.Models
{
    public class SessionCaisse : Entity
    {
        virtual public int Id { get; set; }
        virtual public string Code { get; set; }
        virtual public DateTime DateOuverture { get; set; }
        virtual public DateTime? DateCloture { get; set; }
        virtual public decimal FondDeCaisse { get; set; }
        public decimal TotalEspeceFermeture { get; set; }
        virtual public bool IsClosed { get; set; }
        virtual public string Observation { get; set; }

        virtual public Caisse Caisse { get; set; }
        virtual public User User { get; set; }

        //N'utilise pas la DB
        public decimal SortiesDeCaisse { get; set; }
        public decimal TotalPaiement { get; set; }
        public decimal TotalEspeceTheorique { get; set; }
        public decimal DifferenceTheoriqueEtFermeture { get; set; }

    }
}
