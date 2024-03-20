using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight.Model;
namespace Flight.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());

            LoginPanel loginPanel = new LoginPanel();
            loginPanel.form = new LoginForm(loginPanel);
            MainPanel mainPanel = new MainPanel();
            mainPanel.form = new MainForm(mainPanel);
            RegisterPanel registerPanel = new RegisterPanel();
            registerPanel.form = new RegisterForm(registerPanel);
            AddPanel addPanel = new AddPanel();
            addPanel.form = new AddForm(addPanel);
            ModifyPanel modifyPanel = new ModifyPanel();
            modifyPanel.form = new ModifyForm(modifyPanel);
            RemovePanel removePanel = new RemovePanel();
            removePanel.form = new RemoveForm(removePanel);
            ReservationPanel reservationPanel = new ReservationPanel();
            reservationPanel.form = new ReservationForm(reservationPanel);
            SeatReservationPanel seatReservationPanel = new SeatReservationPanel();
            seatReservationPanel.form = new SeatReservationForm(seatReservationPanel);
            ListFlightsPanel listFlightsPanel = new ListFlightsPanel();
            listFlightsPanel.form = new ListFlightsForm(listFlightsPanel);
            SearchPanel searchPanel = new SearchPanel();
            searchPanel.form = new SearchForm(searchPanel);
            BuySeatsPanel buySeatsPanel = new BuySeatsPanel();
            buySeatsPanel.form = new BuySeatsForm(buySeatsPanel);
            HelpPanel helpPanel = new HelpPanel();
            helpPanel.form = new HelpForm(helpPanel);
            ExitPanel exitPanel = new ExitPanel();
            Session session = new Session();
            session.AddPanel(loginPanel, PanelType.Login);
            session.AddPanel(mainPanel, PanelType.Main);
            session.AddPanel(registerPanel, PanelType.Register);
            session.AddPanel(addPanel, PanelType.Adaugare);
            session.AddPanel(modifyPanel, PanelType.Modificare);
            session.AddPanel(removePanel, PanelType.Eliminare);
            session.AddPanel(reservationPanel, PanelType.Rezervare);
            session.AddPanel(seatReservationPanel, PanelType.RezervaLoc);
            session.AddPanel(listFlightsPanel, PanelType.Lista);
            session.AddPanel(searchPanel, PanelType.Cautare);
            session.AddPanel(buySeatsPanel, PanelType.Cumparare);
            session.AddPanel(helpPanel, PanelType.Help);
            session.AddPanel(exitPanel, PanelType.Exit);
            session.AddTransition(PanelType.Login, 3, PanelType.Main);
            session.AddTransition(PanelType.Login, 2, PanelType.Register);
            session.AddTransition(PanelType.Register, 1, PanelType.Login);
            session.AddTransition(PanelType.Main, 1, PanelType.Adaugare);
            session.AddTransition(PanelType.Main, 2, PanelType.Modificare);
            session.AddTransition(PanelType.Main, 3, PanelType.Eliminare);
            session.AddTransition(PanelType.Main, 4, PanelType.Rezervare);
            session.AddTransition(PanelType.Main, 5, PanelType.Cumparare);
            session.AddTransition(PanelType.Main, 6, PanelType.Cautare);
            session.AddTransition(PanelType.Main, 7, PanelType.Lista);
            session.AddTransition(PanelType.Main, 8, PanelType.RezervaLoc);
            session.AddTransition(PanelType.Main, 9, PanelType.Help);
            session.AddTransition(PanelType.Main, 10, PanelType.Exit);
            session.AddTransition(PanelType.Adaugare, 1, PanelType.Modificare);
            session.AddTransition(PanelType.Modificare, 1, PanelType.Eliminare);
            session.AddTransition(PanelType.Eliminare, 1, PanelType.Main);
            session.AddTransition(PanelType.Rezervare, 1, PanelType.RezervaLoc);
            session.AddTransition(PanelType.RezervaLoc, 1, PanelType.Main);
            session.AddTransition(PanelType.Lista, 1, PanelType.Main);
            session.AddTransition(PanelType.Cautare, 1, PanelType.Main);
            session.AddTransition(PanelType.Cautare, 2, PanelType.Cumparare);
            session.AddTransition(PanelType.Cumparare, 1, PanelType.Main);
            session.AddTransition(PanelType.Help, 1, PanelType.Main);
            session.InitialPanel = PanelType.Login;
            session.Execute();

        }
    }
}
