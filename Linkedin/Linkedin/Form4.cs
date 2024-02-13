using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Linkedin
{
    public partial class Form4 : Form
    {
        private List<Article> articles;

        public Form4()
        {
            InitializeComponent();
            InitializeArticles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Centered Form";

            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DisplayArticles();
        }

        private void InitializeArticles()
        {
            articles = new List<Article>
{
    new Article("Construction Software", "Did you know that 98% percent of the 2,300+ reviews that Procore has received on G2 has been either a 4 or 5 (out of 5) ⭐rating? This is more than just a statistic, It's proof of the trust and satisfaction that our valued customers have in us. \r\nYou can see what more of our customers, like Mike S, are saying about Procore and what makes us standout from the rest of the pack, on our G2 page here: https://ow.ly/tt4150QvXQV\r\n"),
    new Article("Autonomous Revolution: 5 Ways It's Reshaping Industry ROI", "The industrial world is on the brink of a major shift, thanks to autonomous technology. A recent survey involving over 160 industry leaders, reveals how autonomy is redefining ROI in construction, agriculture, and mining. \r\n\r\nA striking 87% of these companies, having invested in autonomy in 2022, anticipate a full ROI within five years, with nearly half expecting it in just 1-3 years. Moreover, 94% plan to continue their investments in autonomous technology, signaling a strong belief in its long-term value and impact.\r\n\r\nKey findings? 📊\r\n\r\n1. Time Savings: Automation leads to more work in less time.\r\n2. Quality & Consistency: Autonomous tech reduces errors and enhances output quality.\r\n3. Labor Cost Reductions: Fewer people needed, with a focus on more critical tasks.\r\n4. New Revenue Opportunities: Autonomy opens doors to new projects and services.\r\n5. Safety Improvements: Significant reduction in on-site injuries.\r\n\r\nThis isn't just a trend; it's the future unfolding before us. Dive into the details and discover how autonomous technology is not just an efficiency booster but a growth catalyst in heavy industries.\r\n\r\n👇 Read the full report below 👇 \r\nhttps://lnkd.in/eRKrBhCi"),
    new Article("insights on labor", "Looking for insights on labor, construction spending, material cost trends and more? Join Procore and AGC for an exclusive webinar on February 1, as we delve into the market conditions of civil and infrastructure. \r\n\r\nRegister now -> https://ow.ly/gFUu30sziPX\r\n"),
    new Article("🚀 Ever wondered why you learn better in certain environments? It's all about your unique learning style!", "\U0001f9e0 Understanding your learning style not only maximizes your potential but also transforms your educational and professional journey. From Hierarchical Individual to Distributed Collective learning, each style offers a unique approach to absorbing knowledge.\r\n\r\n🌟 Benefits of Knowing Your Learning Style:\r\n\r\n✅ Academic: Tailor your learning for better results and reduced stress.\r\n✅ Personal: Boost self-confidence and enjoy every learning experience.\r\n✅ Professional: Stay ahead in your career with effective team management and persuasive skills.\r\n\r\n💡 Whether you're a structured solo learner or thrive in dynamic group settings, identifying your style can revolutionize how you learn and grow.\r\n\r\n🔗 Dive into the different learning styles and discover which one resonates with you. Embrace your strengths and turn your learning power into earning power!"),
    new Article("🌟 Happy 2024 🌟", "As we step into this new year, let's embrace the power of goal setting without overcomplicating it. To assist you on this journey, I'm thrilled to offer a FREE goal-setting template! 📝\r\n\r\nSetting goals shouldn't be a complex task. However, it's important to be SMART about them - Specific, Measurable, Achievable, Relevant, and Time-bound. This template is crafted to help you create goals that are straightforward yet impactful. 🎯\r\n\r\nLet's make 2024 a great year. Make a copy of the template, set your SMART goals, and let's motivate each other with our progress and achievements! 🚀\r\n\r\nTemplate here:https://lnkd.in/e8QWxQMN"),
    new Article("🚧 CONSTRUCTION INDUSTRY BOOMS BUT LABOR SHORTAGE LOOMS 🚧 ", "After the Travelers webinar \"Tackling Rising Claim Costs in the Wake of Labor Shortages\". I had a few takeaways. \r\n\r\n❌ Unemployment rate at a record low of 3.6%. \r\n❌ Virtually no skilled workers are available \r\n❌ Significant labor shortage impacting the industry. \r\n\r\nWAGES SOAR TO ATTRACT AND RETAIN TALENT\r\n❌ Average employee pay increased by 5.4% last year \r\n❌ 19% increase since 2020 highlighting strong demand \r\n❌ Companies invest heavily in the workforce to remain competitive\r\n\r\n🌟 The good news is there are some strategies to help overcome labor shortages ⬇ ⬇ ⬇ ⬇ "),
    new Article("With Procore,", "customers can better connect their field and office teams, enabling them to share more accurate information that may have previously led to cost errors and overruns. Watch this video and hear from a few of Procore's customers to learn how they leverage Procore financial tools to connect their teams and eliminate financial data silos. "),
    new Article("Today at Procore Technologies,", "we took another step toward our vision: 📈 \r\n\r\n\"to improve the lives of everyone in construction\" 👀 \r\n\r\nHow, you ask?? 🤔\r\n\r\nBy partnering with LinkedIn Learning to launch 🚀 the Procore Construction Management Professional Certificate, I truly enjoy working for a company that is committed to supporting individuals in their journey toward professional excellence.🌟 \r\n\r\n\r\nhttp://ow.ly/Ztyk1053QMO "),
    new Article("A quick thought on data... ", "🤔 When Procore Technologies announced Procore Copilot and how it's leveraging all our data to work for us, it really got me thinking: What is the true cost of data? 💭\r\n\r\nI started at the cost of bad data... 📉\r\n\r\nI wonder how much bad data or non-existent data costs companies? 🏢💸\r\n\r\nAccording to an article (linked in the comments) published in 2016, it's over 3 trillion dollars per year in the US alone. 😲\r\n\r\nMakes you think about the next time you half-heartedly enter info into Salesforce or your everyday database... \U0001f9d0\r\n\r\nWhat are your best tips for keeping data clean and correct? 🌟"),
    new Article("Did you know that modern", "modern contractors are now turning to data analytics to revolutionize the way they manage projects? This shift is not just about keeping up with the times; it's about actively reducing risks and enhancing efficiency. 📊🛠️\r\n\r\nImagine being able to predict potential project delays before they happen, or identifying cost overruns in real-time. That's the kind of proactive approach we're seeing more and more in the industry. It's all about making informed decisions that save time, money, and a lot of headaches! 💡💼\r\n\r\nCheck out this article that talks about how leveraging data has a ripple effect on the entire project lifecycle. From planning to execution, data is becoming the backbone of successful project management. 📈🔍\r\n"),
    new Article("📈 Breaking the Glass Ceiling Boosts the Bottom Line!", "Just read a fascinating article from the FT about how gender-balanced companies are changing the game. According to a BlackRock study, companies with more gender-balanced workforces outperformed their peers significantly between 2013 and 2022. This isn't just a small margin – we're talking a 2 percentage points annual difference in performance! 🚀\r\n\r\nAlso want to take this opportunity to shout out some amazing front-line leaders who are making a huge impact here at Procore Technologies! \r\n\r\nJessica Uzmann, Katherine Hathaway, Alex Wilson, Alexandra Horrell, Maddie Ruvin, Madison Todd, Kimberly Ricciotti, and many more y'all are amazing!! \r\n\r\nCheck the article out for yourself and shout out some impactful women below!"),
    new Article("📗 Just finished Part One of", "\"Greenlights\" by Matthew McConaughey, titled \"Outlaw Logic: A Wednesday Night, 1974,\" ⭐ \r\n\r\nA couple things stood out... Can't wait for part 2... "),
    new Article("Project Engage 2024 registration", " is NOW OPEN! Are you ready to take your leadership skills to the next level with this 6-month program designed in partnership with AGC of California and Procore Technologies? Learn more and register before the December 15, 2023 deadline -> https://ow.ly/KNwm50Q4481"),
   
};

        }

        private void DisplayArticles()
        {
            richTextBoxArticles.Clear(); // Clear existing content first, if needed.

            foreach (var article in articles)
            {
                AppendText(article.Title + "\n", Color.DarkBlue, FontStyle.Bold);
                AppendText(article.Content + "\n\n", Color.Black, FontStyle.Regular);
            }

            // After adding all articles, reset the scroll position to the top.
            richTextBoxArticles.SelectionStart = 0;
            richTextBoxArticles.ScrollToCaret(); // Ensure the control scrolls to the caret position, which is now at the start.
        }


        private void AppendText(string text, Color color, FontStyle fontStyle)
        {
            richTextBoxArticles.SelectionStart = richTextBoxArticles.TextLength;
            richTextBoxArticles.SelectionLength = 0;
            richTextBoxArticles.SelectionColor = color;
            richTextBoxArticles.SelectionFont = new Font(richTextBoxArticles.Font, fontStyle);
            richTextBoxArticles.AppendText(text);
            richTextBoxArticles.SelectionColor = richTextBoxArticles.ForeColor;
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Article(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
