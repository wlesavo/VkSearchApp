using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace VkSearchApp
{
    public partial class MainForm : Form
    {
        public static string http_get_url, temp_str, url, text_content;
        public static int likes_count;

        //search parameters
        public static int search_offset = 0;
        public static int page_number = 0;
        public static int batch_size = 20;
        public static int likes_threshold = 100;
        public static string vk_access_token = "your app token";

        public static string vk_owner_id = "-100157872"; //self plagiat check
        public static string[] sources = { "-76495707", "-148376574", "-68670236", "-108531402", "-142046107" }; //public pages for search
        public static string litach_id = "-70854668";    //alternative search

        public static string[] temp;
        public static string[] words;
        public static WallObj vk;
        public static List<string> texts_list = new List<string>() { };
        public static List<string> links_list = new List<string>() { };
        
        public static int results_count = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        public void Search(string owner_id, string author_id) 
        {
            // get all the search results, check for likes threshold and create entry in the table

            if (search_type.SelectedIndex == 0)
            {
                if (tag_textbox.Text.Length > 0)
                {
                    http_get_url = string.Format("https://api.vk.com/method/wall.search?query={0}&owner_id={1}&offset={2}&count={3}&access_token={4}&v=5.95", 
                        tag_textbox.Text, owner_id, search_offset.ToString(), batch_size.ToString(), vk_access_token);
                    using (StreamReader strr = new StreamReader(HttpWebRequest.Create(http_get_url).GetResponse().GetResponseStream(), Encoding.UTF8))
                        temp_str = strr.ReadToEnd();
                    vk = JsonConvert.DeserializeObject<WallObj>(temp_str);
                }
            }
            else
            {
                http_get_url = string.Format("https://api.vk.com/method/wall.get?owner_id={0}&offset={1}&count={2}&access_token={3}&v=5.95", 
                    owner_id, search_offset.ToString(), batch_size.ToString(), vk_access_token);
                using (StreamReader strr = new StreamReader(HttpWebRequest.Create(http_get_url).GetResponse().GetResponseStream(), Encoding.UTF8))
                    temp_str = strr.ReadToEnd();
                vk = JsonConvert.DeserializeObject<WallObj>(temp_str);
            }
            try
            {   
                foreach (var s in vk.response.items)
                {
                    url = "https://vk.com/wall" + owner_id + "_" + s.Id.ToString();
                    likes_count = s.likes.Count;
                    text_content = s.Text;
                    if (likes_count > likes_threshold)
                    {
                        if (s.From_id.ToString() == author_id)
                        {
                            //get text and url, create entry, relevant link and button

                            texts_list.Add(text_content);
                            links_list.Add(url);
                            RowStyle temp = search_results.RowStyles[search_results.RowCount - 1];
                            search_results.RowCount++;
                            search_results.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));

                            Label vk_id_label = new Label();
                            Label vk_likes_label = new Label();
                            LinkLabel vk_url_label = new LinkLabel();

                            vk_url_label.AutoSize = true;
                            vk_id_label.Text = (search_results.RowCount - 2).ToString();
                            vk_likes_label.Text = likes_count.ToString();
                            vk_url_label.Text = url;
                            vk_url_label.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkClicked);

                            search_results.Controls.Add(vk_id_label, 0, search_results.RowCount - 2);
                            search_results.Controls.Add(vk_likes_label, 1, search_results.RowCount - 2);
                            search_results.Controls.Add(vk_url_label, 2, search_results.RowCount - 2);

                            Button vk_copy_button = new Button();
                            vk_copy_button.Text = "Copy";
                            vk_copy_button.MouseClick += CopyButtonClicked;

                            search_results.Controls.Add(vk_copy_button, 3, search_results.RowCount - 2);
                            results_count++;
                        }
                    }
                }
            }
            catch (NullReferenceException e) { MessageBox.Show(e.ToString()); }
        }
        public class WallObj
        {
            public class Response
            {
                [JsonProperty("count")]
                public string Count { get; set; }

                public class Items
                {
                    [JsonProperty("id")]
                    public int Id { get; set; }

                    [JsonProperty("from_id")]
                    public int From_id { get; set; }

                    [JsonProperty("owner_id")]
                    public int Owner_id { get; set; }

                    [JsonProperty("date")]
                    public int Date { get; set; }

                    [JsonProperty("marked_as_ads")]
                    public int Marked_as_ads { get; set; }

                    [JsonProperty("post_type")]
                    public string Post_type { get; set; }

                    [JsonProperty("text")]
                    public string Text { get; set; }

                    public class Attachments
                    {

                    }
                    public class Comments
                    {
                        [JsonProperty("count")]
                        public int Count { get; set; }

                    }
                    public class Likes
                    {
                        [JsonProperty("count")]
                        public int Count { get; set; }

                    }
                    public class Reposts
                    {
                        [JsonProperty("count")]
                        public int Count { get; set; }

                    }
                    public class Views
                    {
                        [JsonProperty("count")]
                        public int Count { get; set; }

                    }

                    [JsonProperty("attachments")]
                    public List<Attachments> attachments { get; set; }

                    [JsonProperty("comments")]
                    public Comments comments { get; set; }

                    [JsonProperty("likes")]
                    public Likes likes { get; set; }

                    [JsonProperty("reposts")]
                    public Reposts reposts { get; set; }

                    [JsonProperty("views")]
                    public Views views { get; set; }

                    [JsonProperty("edited")]
                    public int Edited { get; set; }


                }

                [JsonProperty("items")]

                public List<Items> items { get; set; }
            }


            [JsonProperty("response")]
            public Response response { get; set; }

        }
        private void MainFormLoad(object sender, EventArgs e)
        {
            for (int i = 0; i < source_list.Items.Count; i++)
            {
                source_list.SetItemChecked(i, true);
            }
            search_type.SelectedIndex = 0;
        }
        public void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //start default browser

            int row = search_results.GetRow((LinkLabel)sender);
            System.Diagnostics.Process.Start(links_list[row - 1]);
        }
        private void PageNumberValueChanged(object sender, EventArgs e)
        {
            page_number = Convert.ToInt32(Math.Round(Page_numbox.Value, 0));
            search_offset = batch_size * page_number;
        }
        private void SeclectSearchTypeIndexChanged(object sender, EventArgs e)
        {
            if (search_type.SelectedIndex == 0)
            {
                general_search_panel.Visible = true;
                litach_pan.Visible = false;
            }
            else {
                general_search_panel.Visible = false;
                litach_pan.Visible = true;
            }
        }
        private void SearchButtonClick(object sender, EventArgs e)
        {
            if (search_type.SelectedIndex == 0)
            {
                foreach (int indexChecked in source_list.CheckedIndices)
                {
                    Search(sources[indexChecked], sources[indexChecked]);
                }
                if (different_source.Text.Length > 0)
                {
                    Search(different_source.Text, different_source.Text);
                }
            }
            else
            {
                Search(litach_id, author_id.Text);
            }
        }
        private void ClearButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < search_results.ColumnCount; i++)
            {
                for (int j = 1; j < search_results.RowCount; j++)
                {
                    var control = search_results.GetControlFromPosition(i, j);
                    search_results.Controls.Remove(control);
                }
            }
            texts_list.Clear();
            links_list.Clear();
            search_results.RowCount = 2;
        }
        public void ChangeBuffer(string str)
        {
            //delete hashtags, make relevant replaces, put result into buffer

            var a = str.Split('#');
            var b = 0;
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > b)
                {
                    b = a[i].Length;
                    max = i;
                }
            }
            str = a[max];
            str = str.Replace(".", ". ");
            str = str.Replace(",", ", ");
            str = str.Replace("?", "? ");
            str = str.Replace("!", "! ");
            str = str.Replace(" .", ".");
            str = str.Replace(" ,", ",");
            str = str.Replace(" ?", "?");
            str = str.Replace(" !", "!");
            str = str.Replace(" »", "»");
            str = str.Replace(". \"", ".\"");
            str = str.Replace("! \"", "!\"");
            str = str.Replace("? \"", "?\"");
            str = str.Replace(", \"", ",\"");
            str = str.Replace("—", "-");
            str = str.Replace("–", "-");
            str = str.Replace("\n-", "\n- ");
            str = str.Replace("- ", "-- ");
            str += " #паста #lurkopub #lm";
            str = str.Replace("  ", " ");
            str = str.Replace("  ", " ");
            Clipboard.SetText(str);
        }
        public void CopyButtonClicked(object sender, EventArgs e)
        {
            //refactor text from list

            int row = search_results.GetRow((Button)sender);
            ChangeBuffer(texts_list[row - 1]);
        }
        private void RefactorBufferButtonClick(object sender, EventArgs e)
        {
            //refactor current text from buffer

            ChangeBuffer(Clipboard.GetText());
        }
        private void CopyAuthorLinksButtonClick(object sender, EventArgs e)
        {
            //copy all found links to buffer

            string str1 = string.Join("\n", links_list);
            try
            {
                Clipboard.SetText(str1);
            } catch (ArgumentNullException b) { MessageBox.Show(b.ToString()); }
       }
    }
}
