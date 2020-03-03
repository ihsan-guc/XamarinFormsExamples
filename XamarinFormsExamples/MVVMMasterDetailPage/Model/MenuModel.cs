using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsExamples.MVVMMasterDetailPage.Model
{
    public class MenuModel
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public Type TargetType { get; set; }
    }
}
