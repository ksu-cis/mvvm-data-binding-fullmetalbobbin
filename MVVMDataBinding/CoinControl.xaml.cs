﻿/* CoinControl.xaml.cs
 * Author: CIS400
 * Modified by: Amanda Dreesen
 * Description: User control for coins. Dabloons. Purse weight. Clanky currency. 
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        /// <summary>
        /// Dependency Property for the DenominationProperty
        /// </summary>
        public static readonly DependencyProperty DenominationProperty = 
            DependencyProperty.Register(
                "Denomination",
                typeof(Coins),
                typeof(CoinControl),
                new PropertyMetadata(Coins.Penny)
                );

        /// <summary>
        /// Denomination this control displays and modifies
        /// </summary>
        public Coins Denomination
        {
            get { return (Coins)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }


        /// <summary>
        /// Dependency Property for the QuantityProperty
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(CoinControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        /// <summary>
        /// Gets or sets the quantity of coin
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty);  }
            set { SetValue(QuantityProperty, value);  }
        }


        /// <summary>
        /// Initialization
        /// </summary>
        public CoinControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Click event to handle coin increment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Routed event args</param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Click event to handle coin decrement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Routed event args</param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }

    }
}
