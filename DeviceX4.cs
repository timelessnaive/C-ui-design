using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WpfApplication1 {
	public class DeviceX4 : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string Name) {
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(Name));
		}

		private double _X;
		private double _Y;
		private double _Z;

		public double X {
			get { return _X; }
			set {
				_X = value;
				OnPropertyChanged("X"); //通知程序，X轴属性被更改了
			}
		}

		public double Y {
			get { return _Y; }
			set {
				_Y = value;
				OnPropertyChanged("Y"); //通知程序，Y轴属性被更改了
			}
		}

		public double Z {
			get { return _Z; }
			set {
				_Z = value;
				OnPropertyChanged("Z"); //通知程序，Z轴属性被更改了
			}
		}
	}
}
