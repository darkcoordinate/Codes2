using System;
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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace WpfApplication1
{
  /// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		static data session = new data();
		static datasheet present_session = new datasheet();
		static string Message;
		public MainWindow()
		{
			InitializeComponent();
		}


		private string DisplayData(string input)
		{
			String s = input + '\n';
			if ((input == "Sabji") || (input == "sabji"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaysabji + "\n";
				}
				s = s + session.Getsumof("sabji");
			}
			else if ((input == "Fruits") || (input == "FRUIT") || (input == "fruit") || (input == "fruits") || (input == "FRUITS"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodayfruits + "\n";
				}
				s = s + session.Getsumof("fruit");
			}
			else if ((input == "Edible") || (input == "EDIBLE") || (input == "edible") || (input == "kitchen edible") || (input == "Kitchen edible"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodayedible + "\n";
				}
				s = s + session.Getsumof("edible");
			}
			else if ((input == "NonEdible") || (input == "NONEDIBLE") || (input == "Non Edibles") || (input == "Non Edible") || (input == "NON EDIBLE"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  " + session.GetPoint(i).adtodaynonedible + "\n";
				}
				s = s + session.Getsumof("nonedible");
			}
			else if ((input == "Household") || (input == "HOUSEHOLD") || (input == "House Hold") || (input == "Households") || (input == "households"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodayhouseholds + "\n";
				}
				s = s + session.Getsumof("household");
			}
			else if ((input == "stationary") || (input == "STATIONARY") || (input == "Stationary"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaystationary + "\n";
				}
				s = s + session.Getsumof("stationary");
			}
			else if ((input == "Petrol") || (input == "PETROL") || (input == "petrol"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaypetrol + "\n";
				}
				s = s + session.Getsumof("petrol");
			}
			else if ((input == "Mobile") || (input == "MOBILE") || (input == "mobile"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaymobile + "\n";
				}
				s = s + session.Getsumof("mobile");
			}
			else if ((input == "Maintainence") || (input == "maintainence") || (input == "MAINTAINANCE"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaymaintinance + "\n";
				}
				s = s + session.Getsumof("maintainence");
			}
			else if ((input == "cmo") || (input == "CMO"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaycmo + "\n";
				}
				s = s + session.Getsumof("cmo");
			}
			else if ((input == "generator") || (input == "GENERATOR") || (input == "Generator"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaygenerator + "\n";
				}
				s = s + session.Getsumof("generator");
			}
			else if ((input == "Divya") || (input == "DIVYA") || (input == "divya"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaydivya + "\n";
				}
				s = s + session.Getsumof("divya");
			}
			else if ((input == "Medication") || (input == "MEDICATION") || (input == "medication"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaymedication + "\n";
				}
				s = s + session.Getsumof("medication");
			}
			else if ((input == "milk") || (input == "MILK") || (input == "Milk"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaymilk + "\n";
				}
				s = s + session.Getsumof("milk");
			}
			else if ((input == "news") || (input == "NEWS") || (input == "News"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaynews + "\n";
				}
				s = s + session.Getsumof("news");
			}
			else if ((input == "dth") || (input == "DTH"))
			{
				for (int i = 1; i <= session.Length; i++)
				{
					s = s + session.GetPoint(i).Currentdate.ToString()+"  "+ session.GetPoint(i).adtodaydth + "\n";
				}
				s = s + session.Getsumof("dth");
			}
			return s;
		}

		private void Save_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			Console.WriteLine("Left botton is clicked");
			save_data(session);
		}

		private void Submit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			try
			{
				Console.WriteLine("trying to submit the entries");
				try
				{
					present_session.adtodaysabji = Convert.ToDouble(Box_Sabji1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaysabji = 0;
				}
				try
				{
					present_session.adtodayfruits = Convert.ToDouble(Box_Fruits1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodayfruits = 0;
				}
				try
				{
					present_session.adtodayedible = Convert.ToDouble(Box_Edible1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodayedible = 0;
				}
				try
				{
					present_session.adtodaynonedible = Convert.ToDouble(Box_NonEdible1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaynonedible = 0;
				}
				try
				{
					present_session.adtodayhouseholds = Convert.ToDouble(Box_Household1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodayhouseholds = 0;
				}
				try
				{
					present_session.adtodaystationary = Convert.ToDouble(Box_Stationary1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaystationary = 0;
				}
				try
				{
					present_session.adtodaypetrol = Convert.ToDouble(Box_Petrol1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaypetrol = 0;
				}
				try
				{
					present_session.adtodaymobile = Convert.ToDouble(Box_Mobile1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaymobile = 0;
				}
				try
				{
					present_session.adtodaymaintinance = Convert.ToDouble(Box_Maintainence1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaymaintinance = 0;
				}
				try
				{
					present_session.adtodaycmo = Convert.ToDouble(Box_CMO1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaycmo = 0;
				}
				try
				{
					present_session.adtodaygenerator = Convert.ToDouble(Box_Generator1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaygenerator = 0;
				}
				try
				{
					present_session.adtodaydivya = Convert.ToDouble(Box_Divya1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaydivya = 0;
				}
				try
				{
					present_session.adtodaymedication = Convert.ToDouble(Box_Medication1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaymedication = 0;
				}
				try
				{
					present_session.adtodaymilk = Convert.ToDouble(Box_Milk1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaymilk = 34.5;
				}
				try
				{
					present_session.adtodaynews = Convert.ToDouble(Box_News1.Text);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaynews = 5.5;
				}
				try
				{
					present_session.adtodaydth = Convert.ToDouble(Box_DTH1.Text);
				}
				catch(FormatException ex)
				{
					Console.WriteLine(ex.Message);
					present_session.adtodaydth = 0;
				}

				to_Textbox(present_session);
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.Message);
				Message = ex.Message;
				f();
			}
		}

		private void See_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				string s = See_Box.Text;
				Message = DisplayData(s);
				f();
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.Message);
				Message = ex.Message;
				f();
			}
		}

		private void buffer_data(data k, DateTime g)
		{
			k.GotoFirst();
			do
			{
				try
				{
					Console.WriteLine("in buffer trying to go to next");
					k.ToNext();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
					f();
					break;
				}
			}
			while (!(k.GetPoint().Currentdate.Equals(g)));
			send(k.GetR());
		}

		private void de_buffer_date(data k, DateTime g)
		{
			Console.WriteLine("try to debuffer the data");
			k.GotoFirst();
			do
			{
				Console.WriteLine("checking the equaly of data  of date {0}", k.GetPoint().Currentdate.ToString());
				k.ToNext();
			}
			while (!(k.GetPoint().Currentdate.Equals(g)));
			send_back(k.GetR());
		}


		private string check_month(PresentScen list, DateTime ck_mont)
		{
			string s = "h";
			list.GotoFirst();
			for (int i = 1; i <= list.Length; i++)
			{
				if (((int)list.GetPoint(i).Present.Month == (int)ck_mont.Month) && ((int)list.GetPoint(i).Present.Year == (int)ck_mont.Year))
				{
					s = list.GetPoint(i).Location;
				}
			}
			return s;
		}


		private void save_data(data k)
		{
			try
			{
				Console.WriteLine("Saving Data is initiated");
				de_buffer_date(session,DateLoader.SelectedDate.Value);
				FileStream ff = File.Open("File[" + DateLoader.SelectedDate.Value.Month.ToString() + "][" + DateLoader.SelectedDate.Value.Year.ToString() + "].ksi", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(ff,k);
				Message = "FileSaved";
				f();
				ff.Close();
			}
			catch(SerializationException ex)
			{
				Console.WriteLine(ex.Message);
				Message = ex.Message;
				f();
			}
			catch(IOException ex)
			{
				Console.WriteLine(ex.Message);
				Message=ex.Message;
				f();
			}
		}

		private DateTime first_date(data s)
		{
			s.GotoFirst();
			return s.GetPoint().Currentdate;
		}

		private data add_data(data k)
		{
			Console.WriteLine("try to add data");
			k.GotoFirst();
			for (DateTime m = new DateTime((int)DateLoader.SelectedDate.Value.Year, (int)DateLoader.SelectedDate.Value.Month, 1); m.CompareTo(DateLoader.SelectedDate.Value) < 0; m = m.AddDays(1))
			{
				try
				{
					Console.WriteLine("moving to date {0}", m.ToString());
					k.ToNext();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					k.Addpoint(new datasheet());
					k.GetPoint(k.Length).Currentdate = m.AddDays(1);
				}
			}
			return k;
		}

		private void send(int i)
		{
			try
			{
				i = Convert.ToInt16(DateLoader.SelectedDate.Value.Day);
			}
			catch (System.FormatException e)
			{
				Console.WriteLine(e.Message);
				Message = e.Message;
				i = 1;
				f();
			}
			if ((i != 0) && (i <= session.Length))
			{
				Console.WriteLine("Sending the data");
				present_session.adtodaysabji = session.GetPoint(i).adtodaysabji;
				present_session.adtodayfruits = session.GetPoint(i).adtodayfruits;
				present_session.adtodayedible = session.GetPoint(i).adtodayedible;
				present_session.adtodaynonedible = session.GetPoint(i).adtodaynonedible;
				present_session.adtodayhouseholds = session.GetPoint(i).adtodayhouseholds;
				present_session.adtodaystationary = session.GetPoint(i).adtodaystationary;
				present_session.adtodaypetrol = session.GetPoint(i).adtodaypetrol;
				present_session.adtodaymobile = session.GetPoint(i).adtodaymobile;
				present_session.adtodaymaintinance = session.GetPoint(i).adtodaymaintinance;
				present_session.adtodaycmo = session.GetPoint(i).adtodaycmo;
				present_session.adtodaygenerator = session.GetPoint(i).adtodaygenerator;
				present_session.adtodaydivya = session.GetPoint(i).adtodaydivya;
				present_session.adtodaymedication = session.GetPoint(i).adtodaymedication;
				present_session.adtodaymilk = session.GetPoint(i).adtodaymilk;
				present_session.adtodaynews = session.GetPoint(i).adtodaynews;
				present_session.adtodaydth = session.GetPoint(i).adtodaydth;
			}
			to_Textbox(present_session);
		}

		private void send_back(int i)
		{
			try
			{
				i = Convert.ToInt16(DateLoader.SelectedDate.Value.Day);
			}
			catch (System.FormatException e)
			{
				Console.WriteLine(e.Message);
				Message = e.Message;
				i = 1;
				f();
			}
			if ((i != 0) && (i <= session.Length))
			{
				Console.WriteLine("Sending back the data");
				session.GetPoint(i).adtodaysabji = present_session.adtodaysabji;
				session.GetPoint(i).adtodayfruits = present_session.adtodayfruits;
				session.GetPoint(i).adtodayedible = present_session.adtodayedible;
				session.GetPoint(i).adtodaynonedible = present_session.adtodaynonedible;
				session.GetPoint(i).adtodayhouseholds = present_session.adtodayhouseholds;
				session.GetPoint(i).adtodaystationary = present_session.adtodaystationary;
				session.GetPoint(i).adtodaypetrol = present_session.adtodaystationary;
				session.GetPoint(i).adtodaymobile = present_session.adtodaymobile;
				session.GetPoint(i).adtodaymaintinance = present_session.adtodaymaintinance;
				session.GetPoint(i).adtodaycmo = present_session.adtodaycmo;
				session.GetPoint(i).adtodaygenerator = present_session.adtodaygenerator;
				session.GetPoint(i).adtodaydivya = present_session.adtodaydivya;
				session.GetPoint(i).adtodaymedication = present_session.adtodaymedication;
				session.GetPoint(i).adtodaymilk = present_session.adtodaymilk;
				session.GetPoint(i).adtodaynews = present_session.adtodaynews;
				session.GetPoint(i).adtodaydth = present_session.adtodaydth;
			}
			to_Textbox(present_session);
		}


		private void f()
		{
			Side_Bar1.Text = Message;
		}

		private void to_Textbox(datasheet m)
		{
			try
			{
				Console.WriteLine("writing on the box");
				Side_Rec_Sabji1.Text = Convert.ToString(m.adtodaysabji);
				Side_Rec_Fruits1.Text = Convert.ToString(m.adtodayfruits);
				Side_Rec_Edible1.Text = Convert.ToString(m.adtodayedible);
				Side_Rec_NonEdible1.Text = Convert.ToString(m.adtodaynonedible);
				Side_Rec_Household1.Text = Convert.ToString(m.adtodayhouseholds);
				Side_Rec_Stationary1.Text = Convert.ToString(m.adtodaystationary);
				Side_Rec_Petrol1.Text = Convert.ToString(m.adtodaypetrol);
				Side_Rec_Mobile1.Text = Convert.ToString(m.adtodaymobile);
				Side_Rec_Maintainence1.Text = Convert.ToString(m.adtodaymaintinance);
				Side_Rec_CMO1.Text = Convert.ToString(m.adtodaycmo);
				Side_Rec_Generator1.Text = Convert.ToString(m.adtodaygenerator);
				Side_Rec_Divya1.Text = Convert.ToString(m.adtodaydivya);
				Side_Rec_Medication1.Text = Convert.ToString(m.adtodaymedication);
				Side_Rec_Milk1.Text = Convert.ToString(m.adtodaymilk);
				Side_Rec_News1.Text = Convert.ToString(m.adtodaynews);
				Side_Rec_DTH1.Text = Convert.ToString(m.adtodaydth);
				Total.Text = "Todays Total is\n" + Convert.ToString(m.getotalday());
			}
			catch (FormatException e)
			{
				Message = e.Message;
				f();
			}
		}


		private void DateLoader_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
		{
			Message = "dateLoaded";
			f();
			Console.WriteLine("Loading the data");
			if ((int)session.GetPoint().Currentdate.Month == (int)DateLoader.SelectedDate.Value.Month)
			{
				add_data(session);
				buffer_data(session, DateLoader.SelectedDate.Value);
				to_Textbox(present_session);
			}
			else
			{
				try
				{
					FileStream ff = File.Open("File[" + DateLoader.SelectedDate.Value.Month.ToString() + "][" + DateLoader.SelectedDate.Value.Year.ToString() + "].ksi", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
					BinaryFormatter bf = new BinaryFormatter();
					session = (data)bf.Deserialize(ff);
					ff.Close();
				}
				catch (IOException ex)
				{
					Console.WriteLine(ex.Message);
				}
				catch (SerializationException ex)
				{
					Console.WriteLine(ex.Message);
					FileStream ff = File.Open("File[" + DateLoader.SelectedDate.Value.Month.ToString() + "][" + DateLoader.SelectedDate.Value.Year.ToString() + "].ksi", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
					BinaryFormatter bf = new BinaryFormatter();
					data maker = new data();
					maker.GetPoint(1).Currentdate = new DateTime((int)DateLoader.SelectedDate.Value.Year, (int)DateLoader.SelectedDate.Value.Month, 1);
					bf.Serialize(ff, maker);
					session = maker;
					ff.Close();
				}
				finally
				{
					add_data(session);
					buffer_data(session, DateLoader.SelectedDate.Value);
					to_Textbox(present_session);
				}
			}

		}
	}
}


