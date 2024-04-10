using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTasks
{
    public partial class FrmTasks : Form
    {
        private TaskScheduler _scheduler;
        public FrmTasks()
        {
            InitializeComponent();
            _scheduler
                = TaskScheduler.FromCurrentSynchronizationContext();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            new Task(() =>
            {
                Task[] tareas =
                {
                    Task.Factory.StartNew(() =>
                IncreaseValue(txtConteo1, pb1, 150, 1),
                CancellationToken.None,
                TaskCreationOptions.LongRunning,
                _scheduler),
                Task.Factory.StartNew(() =>
                IncreaseValue(txtConteo2, pb2, 180, 1),
                CancellationToken.None,
                TaskCreationOptions.LongRunning,
                _scheduler),
                Task.Factory.StartNew(() =>
                IncreaseValue(txtConteo3, pb3, 50, 1),
                CancellationToken.None,
                TaskCreationOptions.LongRunning,
                _scheduler),
                Task.Factory.StartNew(() =>
                IncreaseValue(txtConteo4, pb4, 200, 1),
                CancellationToken.None,
                TaskCreationOptions.LongRunning,
                _scheduler)
                };
                Task.WaitAll(tareas);
            }).Start();
            MessageBox.Show("Se han terminado todas las tareas");
        }

        private void IncreaseValue(TextBox t, ProgressBar p, int r, int c)
        {
            p.Maximum = r;
            for (int i = 0; i < r; i++)
            {
                int result = i * c;
                Thread.Sleep(100);
                UpdateView(t, p, result);
            }
        }

        private void UpdateView(TextBox t, ProgressBar p, int result)
        {
            p.Value = result;
            t.Text += "Conteo: " + result + Environment.NewLine;
            t.SelectionStart = t.Text.Length;
            t.ScrollToCaret();
            Application.DoEvents();
        }
    }
}
