﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsExamples.MVVMTabbedPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleView : ContentPage
    {
        public PeopleView()
        {
            InitializeComponent();
        }
    }
}