﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Borsa
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "ctbii2hr01qvslqukgt0ctbii2hr01qvslqukgtg"; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            await GetStockPrices(); 
        }

        private async Task GetStockPrices()
        {
            string[] symbols = { "AAPL", "MSFT", "AMZN", "TSLA", "META", "V" }; 
            TextBox[] textBoxes = { txtApple, txtMicrosoft, txtAmazon, txtTesla, txtFacebook, txtVisa }; 

            using (HttpClient client = new HttpClient())
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    string url = $"https://finnhub.io/api/v1/quote?symbol={symbols[i]}&token={ApiKey}";
                    try
                    {
                        string response = await client.GetStringAsync(url);
                        string stockData = ExtractStockData(response); 
                        textBoxes[i].Text = stockData; 
                    }
                    catch (Exception ex)
                    {
                        textBoxes[i].Text = "Hata: " + ex.Message; 
                    }
                }
            }
        }

        private string ExtractStockData(string jsonResponse)
        {
            try
            {
                var data = JObject.Parse(jsonResponse);
                string currentPrice = data["c"].ToString(); 
                return currentPrice;
            }
            catch (Exception ex)
            {
                return "Veri çekilemedi. Hata: " + ex.Message;
            }
        }

        private void txtApple_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMicrosoft_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAmazon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTesla_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFacebook_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtVisa_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
