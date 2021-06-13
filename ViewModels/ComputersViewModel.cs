using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using computer_store_MVC.Dtos;

namespace computer_store_MVC.ViewModels
{
    public class ComputersViewModel
    {
        public List<ComputerDto> Computers { get; set; }

    }
}