﻿using System;

namespace BusinessEngine.Models
{
    public class Chineur : Entity
    {
        virtual public int Id { get; set; }
        virtual public String Nom { get; set; }
        virtual public String Prenoms { get; set; }
    }
}
