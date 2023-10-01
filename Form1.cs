namespace weee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the desired file path and name from a TextBox or any other source
            string filePath = filePathTextBox.Text;

            try
            {
                // Attempt to create the file
                using (FileStream fs = File.Create(filePath))
                {
                    // File created successfully
                    MessageBox.Show($"File '{Path.GetFileName(filePath)}' created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // File creation failed
                MessageBox.Show($"File creation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the file path from a TextBox or any other source
            string filePath = filePathTextBox.Text;

            if (File.Exists(filePath))
            {
                try
                {
                    // Read the contents of the file
                    string fileContents = File.ReadAllText(filePath);

                    // Display the contents in a MessageBox
                    MessageBox.Show($"File Contents:\n\n{fileContents}", "File Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // File reading failed
                    MessageBox.Show($"File reading failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // File does not exist
                MessageBox.Show("The specified file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the directory path where you have been creating files
            string directoryPath = @"C:\YourDirectoryPath"; // Change this to your directory path

            try
            {
                // Get all files in the specified directory
                string[] files = Directory.GetFiles(directoryPath);

                if (files.Length > 0)
                {
                    // Display the list of files in a MessageBox
                    string fileList = string.Join("\n", files);
                    MessageBox.Show($"Files in the directory:\n\n{fileList}", "File List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No files found in the directory.", "File List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Directory access or listing failed
                MessageBox.Show($"Directory listing failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Modify this line to set the desired file path directly
            string filePath = @"E:\Annimation.mkuu"; // Replace with your desired file path

            try
            {
                // Attempt to create the file
                using (FileStream fs = File.Create(filePath))
                {
                    // File created successfully
                    MessageBox.Show($"File '{Path.GetFileName(filePath)}' created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // File creation faile d
                MessageBox.Show($"File creation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
