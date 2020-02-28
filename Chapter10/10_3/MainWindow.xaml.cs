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

namespace _10_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Member> list = new List<Member>();
        Member member;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            member = new Member();
            member.NAME = textBoxName.Text;
            member.PHONE = textBoxPhone.Text;

            list.Add(member);
            labelNumberOfMember.Content = list.Count;
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            foreach(Member item in list)
            {
                string tmpName = item.NAME;
                string tmpName2 = textBoxPhoneSearch.Text;
                if (tmpName == tmpName2)
                {
                    labelPhoneName.Content = item.PHONE;
                }
                else
                {
                    labelPhoneName.Content = "그런 회원 없음";
                }
            }
        }
    }
}
