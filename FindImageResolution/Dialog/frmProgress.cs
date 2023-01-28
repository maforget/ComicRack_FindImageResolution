using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindImageResolutionNET.Tools;
//using AmazonScrapper.Web;

namespace FindImageResolutionNET
{
    public partial class frmProgress : Form
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public CancellationToken Token { get => cancellationTokenSource.Token; }
        public event EventHandler BookUpdated;
        public event EventHandler CancelPressed;

        public frmProgress()
        {
            InitializeComponent();
        }

        public frmProgress(int numberOfBooks)
            : this()
        {
            progressBar.Maximum = numberOfBooks;
            btnCancel.Text = $"Cancel ({numberOfBooks} remaining)";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancelPressed(EventArgs.Empty);
            this.Close();
        }

        public void UpdateForm(Image image, string serie, string number)
        {
            if (Token.IsCancellationRequested)
                Token.ThrowIfCancellationRequested();

            if (image != null)
                pbCover.SafeInvoke(x => x.Image = image);

            lblText.SafeInvoke(x => x.Text = $"{serie}{(number == "-1" ? string.Empty : " #" + number)}");
            OnBookUpdated();
        }

        public void IncreaseProgressBarByOne()
        {
            progressBar.SafeInvoke(x => x.Increment(1));
            btnCancel.SafeInvoke(x => x.Text = $"Cancel ({progressBar.Maximum - progressBar.Value} remaining)");
        }

        protected virtual void OnBookUpdated()
        {
            BookUpdated?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnCancelPressed(EventArgs e)
        {
            cancellationTokenSource.Cancel();
            CancelPressed?.Invoke(this, e);
        }

        private void frmProgress_Shown(object sender, EventArgs e)
        {
            Plugin.ProcessBooks();
        }

        private void frmProgress_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnCancelPressed(EventArgs.Empty);
        }
    }
}
