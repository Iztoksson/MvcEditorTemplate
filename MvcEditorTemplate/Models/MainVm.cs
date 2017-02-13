namespace MvcEditorTemplate.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class MainVm
    {
        public MainVm()
        {
            this.PersonsList = new List<PersonVm>();
        }
        public List<PersonVm> PersonsList { get; set; }
    }
}