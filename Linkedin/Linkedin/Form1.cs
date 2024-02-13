using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Linkedin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Centered Form";

            this.FormBorderStyle = FormBorderStyle.FixedDialog; // 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            // Show Form2
            form3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenChrome()
        {
            try
            {
                // Set ChromeDriver path
                string driverPath = "\\\\Mac\\Home\\Desktop\\Personalized\\Linkedin\\chromedriver.exe";
                // Initialize ChromeDriver
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized"); // Maximize the browser window
                IWebDriver driver = new ChromeDriver(driverPath, options);

                // Navigate to a website
                driver.Navigate().GoToUrl("https://www.linkedin.com/login?fromSignIn=true&trk=guest_homepage-basic_nav-header-signin");

                // Close the browser after 5 seconds
                Thread.Sleep(9000);

                IWebElement emailInput = driver.FindElement(By.Id("username")); // Replace "email" with the actual ID of the input field

                // Type the email address using SendKeys()
                emailInput.SendKeys("zaeem18929@gmail.com");
                Thread.Sleep(2000);

                IWebElement passInput = driver.FindElement(By.Id("password")); // Replace "password" with the actual ID of the input field

                // Type the password address using SendKeys()
                passInput.SendKeys("Tesla@6575669");

                Thread.Sleep(3000);

                // Find the button using XPath
                IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div[2]/div[1]/form/div[3]/button")); // Replace with the XPath expression that matches your button
                Thread.Sleep(3000);
                // Click on the button
                button.Click();


                Thread.Sleep(4000);
                driver.Navigate().GoToUrl("https://www.linkedin.com/in/jacobweaver155/recent-activity/all/");
                Thread.Sleep(3000);


                // Create Actions object
                Actions actions = new Actions(driver);

                // Scroll down until the end of the page
                while (true)
                {
                    // Press the Page Down key
                    actions.SendKeys(OpenQA.Selenium.Keys.PageDown).Perform();

                    // You may need to add a small delay here to allow the page to scroll and load content
                    System.Threading.Thread.Sleep(3000); // Adjust the delay as needed

                    // Check if the scroll bar has reached the end
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    long scrollHeight = (long)js.ExecuteScript("return document.documentElement.scrollHeight;");
                    long clientHeight = (long)js.ExecuteScript("return document.documentElement.clientHeight;");
                    long scrollTop = (long)js.ExecuteScript("return document.documentElement.scrollTop;");

                    if (scrollTop + clientHeight >= scrollHeight)
                    {
                        // End of page reached, break the loop
                        break;
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Create a thread to perform Selenium operations
            Thread seleniumThread = new Thread(OpenChrome);
            seleniumThread.IsBackground = true; // Set the thread as background to prevent blocking the form
            seleniumThread.Start();
        }
    }
}
