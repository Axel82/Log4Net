﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using log4net;

namespace Log4NetTest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Statements
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Constructor
        public MainWindow()
        {
            // Log4Net config
            log4net.Config.XmlConfigurator.Configure();

            // Init
            InitializeComponent();

            // Test Log4Net
            try
            {
                int b = 10;
                double a = b / 0;

            }
            catch (Exception ex)
            {
                Log.Debug(ex);
                //Log.Error(ex);
                //Log.Fatal("Fatal Message", ex);

                //Log.Warn("Warning Message");
                //Log.Info("Info Message");
            }
        }
        #endregion

    }
}
