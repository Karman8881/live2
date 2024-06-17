using live2.engine;

namespace live2
{

    public partial class Form1 : Form
    {

        private Controller controller = new Controller();
        private Model model = new Model();

        private Thread worker;
        private static volatile bool stopr = false;

        public Form1()
        {
            InitializeComponent();
        }

        private async void formStart(object sender, EventArgs e)
        {
            liveTimer.Start();
            stopr = false;
            worker = new Thread(panel1_Paint);
            worker.Start();
        }

        private void formStop(object sender, EventArgs e)
        {
            liveTimer.Stop();
            stopr = true;
            worker.Join();
        }

        private void formClean(object sender, EventArgs e)
        {
            liveTimer.Stop();
            controller.clean();

            for (int i = 0; i < model.heigh; i++)
            {
                for (int j = 0; j < model.widt; j++)
                {
                    model.a[i, j] = 0;
                }
            }
            model.a = model.b;
        }

        private void formRandom(object sender, EventArgs e)
        {
            liveTimer.Stop();
            controller.random();
            Random random = new Random();

            for (int i = 0; i < model.heigh; i++)
            {
                for (int j = 0; j < model.widt; j++)
                {
                    model.a[i, j] = random.Next(0, 1);
                }
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            controller.step();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            while (!stop)
            {

                for (int i = 0; i < model.heigh; i++)
                {
                    for (int j = 0; j < model.widt; j++)
                    {
                        int n = 0;
                        if (model.a[--i, --j] == 1)
                        {
                            n++;
                        }
                        if (model.a[--i, j] == 1)
                        {
                            n++;
                        }
                        if (model.a[--i, ++j] == 1)
                        {
                            n++;
                        }
                        if (model.a[i, --j] == 1)
                        {
                            n++;
                        }
                        if (model.a[i, ++j] == 1)
                        {
                            n++;
                        }
                        if (model.a[++i, --j] == 1)
                        {
                            n++;
                        }
                        if (model.a[++i, j] == 1)
                        {
                            n++;
                        }
                        if (model.a[++i, ++j] == 1)
                        {
                            n++;
                        }
                        if (model.a[i, j] == 0)
                        {
                            if (n == 3)
                            {
                                model.b[i, j] = 1;
                            }
                        }
                        else if (model.b[i, j] == 1)
                        {
                            model.a[i, j] = 1;
                        }

                    }
                }
                model.a = model.b;
            }
        }

        private void fieldform(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
