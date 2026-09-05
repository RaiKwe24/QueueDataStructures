namespace QueueDataStructures
{
    public partial class Form1 : Form
    {
        private readonly Queue<string> expressQueue = new Queue<string>();
        private readonly Queue<string> premiumQueue = new Queue<string>();
        private readonly Queue<string> standardQueue = new Queue<string>();
        private readonly Queue<string> sameDayQueue = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
            UpdateQueueList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var service = cmbService.SelectedItem?.ToString() ?? "Standard";
            var customer = string.IsNullOrWhiteSpace(txtCustomer.Text) ? "(no name)" : txtCustomer.Text.Trim();
            var entry = $"{customer} - {DateTime.Now:HH:mm:ss}";

            switch (service)
            {
                case "Express":
                    expressQueue.Enqueue(entry);
                    break;
                case "Premium":
                    premiumQueue.Enqueue(entry);
                    break;
                case "Standard":
                    standardQueue.Enqueue(entry);
                    break;
                case "Same day delivery":
                    sameDayQueue.Enqueue(entry);
                    break;
                default:
                    standardQueue.Enqueue(entry);
                    break;
            }

            txtCustomer.Clear();
            UpdateQueueList();
        }

        private void btnServe_Click(object sender, EventArgs e)
        {
            string served = null;

            // Prioritised by default: Express, Premium, Standard, Same day delivery
            if (expressQueue.Count > 0)
                served = "Express: " + expressQueue.Dequeue();
            else if (premiumQueue.Count > 0)
                served = "Premium: " + premiumQueue.Dequeue();
            else if (standardQueue.Count > 0)
                served = "Standard: " + standardQueue.Dequeue();
            else if (sameDayQueue.Count > 0)
                served = "Same day delivery: " + sameDayQueue.Dequeue();

            if (served != null)
            {
                MessageBox.Show($"Now serving: {served}", "Serving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No items in queue.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateQueueList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            expressQueue.Clear();
            premiumQueue.Clear();
            standardQueue.Clear();
            sameDayQueue.Clear();
            UpdateQueueList();
        }

        private void UpdateQueueList()
        {
            lstQueue.BeginUpdate();
            lstQueue.Items.Clear();

            // Show in priority order with headers
            if (expressQueue.Count > 0)
            {
                lstQueue.Items.Add("-- Express --");
                foreach (var it in expressQueue) lstQueue.Items.Add(it);
            }
            if (premiumQueue.Count > 0)
            {
                lstQueue.Items.Add("-- Premium --");
                foreach (var it in premiumQueue) lstQueue.Items.Add(it);
            }
            if (standardQueue.Count > 0)
            {
                lstQueue.Items.Add("-- Standard --");
                foreach (var it in standardQueue) lstQueue.Items.Add(it);
            }
            if (sameDayQueue.Count > 0)
            {
                lstQueue.Items.Add("-- Same day delivery --");
                foreach (var it in sameDayQueue) lstQueue.Items.Add(it);
            }

            lblCounts.Text = $"Counts: E:{expressQueue.Count} P:{premiumQueue.Count} S:{standardQueue.Count} SD:{sameDayQueue.Count}";
            lstQueue.EndUpdate();
        }
    }
}
