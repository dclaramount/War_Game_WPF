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

namespace Book_App_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Construction
        public MainWindow()
        {
            InitializeComponent();

            RegisterEvents();
        }
        #endregion

        #region Methods

        private void RegisterEvents()
        {
            //Handle what happens when mouse enters main menu buttons
            btn_newGame.MouseEnter  += btn_newGame_MouseEnter;
            btn_rules.MouseEnter    += btn_rules_MouseEnter;
            btn_exitGame.MouseEnter += btn_exitGame_MouseEnter;

            //Handle what happens when mouse leaves main menu buttons
            btn_newGame.MouseLeave  += btn_newGame_MouseLeave;
            btn_rules.MouseLeave    += btn_rules_MouseLeave;
            btn_exitGame.MouseLeave += btn_exitGame_MouseLeave;
        }



        #endregion


        #region Event Handling



        private void btn_newGame_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Handle the click of the new game button
        }

        private void btn_rules_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Handle the click of the rules button
        }

        private void btn_exitGame_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Handle the click of the exit button
        }

        void MainMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            //Clear out the test from the info text box.
            txtBlk_info.Text = string.Empty;
        }

        void btn_newGame_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlk_info.Text = "Start New Game";
        }

        void btn_newGame_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        void btn_rules_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlk_info.Text = "View War Rules";
        }

        void btn_rules_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        void btn_exitGame_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlk_info.Text = "Exit the Game";
        }

        void btn_exitGame_MouseLeave(object sender, MouseEventArgs e)
        {

        }
        #endregion
    }
}
