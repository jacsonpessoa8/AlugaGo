﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlugaGo.Models;

namespace AlugaGo.ViewModels
{
    public class CustomerFormViewModel
    {
        
        public Customer Customer { get; set; }

        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Editar Cliente";

                return "Novo Cliente";
            }
        }

    }
}