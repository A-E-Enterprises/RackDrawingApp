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

namespace RackDrawingApp
{
	/// <summary>
	/// Interaction logic for RackAccessoriesDialog.xaml
	/// </summary>
	public partial class RackAccessoriesDialog : UserControl
	{
		private RackAccessories_ViewModel m_VM = null;

		public RackAccessoriesDialog(RackAccessories_ViewModel vm)
		{
			InitializeComponent();

			m_VM = vm;
			DataContext = m_VM;

			if (CurrentTheme.CurrentColorTheme != null)
				CurrentTheme.CurrentColorTheme.ApplyTheme(this.Resources);
		}
	}
}
