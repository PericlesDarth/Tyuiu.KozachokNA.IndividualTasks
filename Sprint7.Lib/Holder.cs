namespace Sprint7.Lib
{
    public class Holder
    {
        private FileIO fio;
        private UserInterface ui;
        public Holder()
        {
            this.fio = new FileIO();
            this.ui = new UserInterface(this.fio);
        }

        public void Run()
        {
            ui.Switcher();
        }

    }
}
