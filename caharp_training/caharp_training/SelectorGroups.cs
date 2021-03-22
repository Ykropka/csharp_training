using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caharp_training
{
    public static class SelectorGroups
    {
        //
        //Кнопка NewGroups
        public const string NewGroups = "new";
        //
        //Поле GroupName
        public const string GroupName = "//input[@name='group_name']";
        //
        //Поле GroupHeader
        public const string GroupHeader = "//textarea[@name='group_header']";
        //
        //Поле GroupFooter
        public const string GroupFooter = "//textarea[@name='group_footer']";
        //
        //Кнопка Submit
        public const string Submit = "//input[@name='submit']";
        //
        //Кнопка group page
        public const string ReturnGroupPage = "group page";
    }
}
