/* BillControl.xaml.cs
 * Author: CIS400
 * Modified by: Amanda Dreesen
 * Description: User control for bills. Da papah. Green. Floppy currency.
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
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {

        /// <summary>
        /// Dependency Property for the DenominationProperty
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                "Denomination",
                typeof(Bills),
                typeof(BillControl),
                new PropertyMetadata(Bills.One)
                );

        /// <summary>
        /// Denomination this control displays and modifies
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }


        /// <summary>
        /// Dependency Property for the QuantityProperty
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(BillControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        /// <summary>
        /// Gets or sets the quantity of bill
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        /// <summary>
        /// Initialization
        /// </summary>
        public BillControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Click event to handle bill increment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Routed event args</param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Click event to handle bill decrement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Routed event args</param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }


    }
}
