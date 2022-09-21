using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Part_1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
        }

        //List for Call Numbers
        List<string> callNumbs = new List<string>();

        //List for author names
        List<string> authors = new List<string>();

        //List for sorted Call Numbers
        List<string> sortedList = new List<string>();

        //List for users
        List<string> userList = new List<string>();

        //Sorting method for List
        private void bubbleSort(List<string> stList)
        {
            for (int i = 0; i < stList.Count - 1; i++)
            {   //10, 5, 21, 7, 13
                for (int k = (i + 1); k < stList.Count; k++)
                {
                    if (stList[i].CompareTo(stList[k]) == 1)
                    {
                        string temp = stList[i];
                        stList[i] = stList[k];
                        stList[k] = temp;
                    }
                }
            }
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please Select Replace Books Option");
        }

        private void btnReplace_Click(object sender, RoutedEventArgs e)
        {
            userList.Clear();
            sortedList.Clear();
            callNumbs.Clear();
            lsbResult.Items.Clear();
            lsbOutput.Items.Clear();

            //Random object to create random numbers
            Random rnd = new Random();

            //Adding authors to author list
            authors.Add("GOL");
            authors.Add("CHA");
            authors.Add("JAN");
            authors.Add("WIL");
            authors.Add("HOM");
            authors.Add("SOC");
            authors.Add("ARI");
            authors.Add("MAR");
            authors.Add("FRI");
            authors.Add("MAC");
            authors.Add("SAL");
            authors.Add("KAF");
            authors.Add("GAR");
            authors.Add("WES");
            authors.Add("MAL");
            authors.Add("CAR");
            authors.Add("MIL");
            authors.Add("TRA");
            authors.Add("JEN");
            authors.Add("MIC");
            authors.Add("GLO");
            authors.Add("OKA");


            //Adding random numbers to Call Number List
            for (int i =0; i < 10; i++)
            {
                int ran = rnd.Next(1, 99);

                string rd = ran.ToString();

                if (rd.Length == 2)
                {
                    string temp = rd;
                    rd = "0" + temp; 
                } else if (rd.Length == 1)
                {
                    string temp = rd;
                    rd = "00" + temp;
                }

                callNumbs.Add(rd + authors[rnd.Next(1, 22)]);
            }

            //Displaying the Call Numbers
            foreach(string item in callNumbs)
            {
                lsbOutput.Items.Add(item);
            }

            //Sorting of Call Numbers
            sortedList = callNumbs;
            bubbleSort(sortedList);
            

            //Disabling other options and swtching to Replace books Feature
            btnIdentify.IsEnabled = false;
            btnFind.IsEnabled = false;
            Menu.SelectedIndex = 1;
        }

        private void btnIdentify_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please Select Replace Books Option");
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            //Getting all items in the listbox and adding them to the user List
            for (int i = 0; i < lsbResult.Items.Count; i++)
            {
                string item = lsbResult.Items[i].ToString();

                userList.Add(item);
            }

            int count = 0;
            if (userList.Count == sortedList.Count)
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i] == userList[i])
                    {
                        count++;
                    }
                }
            }

            if (count == sortedList.Count)
            {
                MessageBox.Show("CORRECT");
            }
            else
            {
                MessageBox.Show("INCORRECT", "Student Application", 
                MessageBoxButton.OK, MessageBoxImage.Error);          
            }
        }

        private void lstUnsorted_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(this, lsbOutput.SelectedItem.ToString(), DragDropEffects.Move);
            }
     
        }

        private void lstSorted_Drop(object sender, DragEventArgs e)
        {
            var myObj = e.Data.GetData(DataFormats.Text);
            lsbOutput.Items.Remove(lsbOutput.SelectedItem);
            lsbResult.Items.Add(myObj);

            if (lsbResult.Items.Contains(lsbResult.SelectedItem))
            {
                lsbResult.Items.Remove(lsbOutput.SelectedItem);
                lsbResult.Items.Remove(lsbResult.SelectedItem);
            }

            if (lsbResult.Items.Count > 0)
            {
                btnCheck.IsEnabled = true;
            }
        }

        private void lstSorted_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(this, lsbResult.SelectedItem.ToString(), DragDropEffects.Move);
            }

        }

        private void lstUnsorted_Drop(object sender, DragEventArgs e)
        {
            var myObj = e.Data.GetData(DataFormats.Text);
            lsbResult.Items.Remove(lsbResult.SelectedItem);
            lsbOutput.Items.Add(myObj);

            if (lsbOutput.Items.Contains(lsbOutput.SelectedItem))
            {
                lsbOutput.Items.Remove(lsbResult.SelectedItem);
                lsbOutput.Items.Remove(lsbOutput.SelectedItem);
            }



            if (lsbResult.Items.Count < 1)
            {
                btnCheck.IsEnabled = false;
            }

        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Drag and drop the items in the first box to the second in ascending order");
        }
    }
}
