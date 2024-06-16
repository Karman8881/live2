using live2.engine;

namespace live2
{
    public partial class Form1 : Form
    {
        private Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private async void formStart(object sender, EventArgs e)
        {
            liveTimer.Start();

        }


        private void formStop(object sender, EventArgs e)
        {
            liveTimer.Stop();
        }

        private void formClean(object sender, EventArgs e)
        {
            liveTimer.Stop();
            controller.clean();
        }

        private void formRandom(object sender, EventArgs e)
        {
            liveTimer.Stop();
            controller.random();
        }

        private void timerTick(object sender, EventArgs e)
        {
            controller.step();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fieldform(object sender, EventArgs e)
        {

        }
    }
}
