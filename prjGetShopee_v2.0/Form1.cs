using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prjGetShopee_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetPanasonic_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            iSpanProjectEntities1 dbContext = new iSpanProjectEntities1();
            EdgeOptions edgeOptions = new EdgeOptions();
            edgeOptions.PageLoadStrategy = OpenQA.Selenium.PageLoadStrategy.Normal;
            EdgeDriver driver = new EdgeDriver(edgeOptions);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://shopee.tw/panasonic.tw");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            List<string> itemUrlList = new List<string>();
            int totalPage = Convert.ToInt32(driver.FindElement(By.CssSelector(".shopee-mini-page-controller__total")).Text);
            for (int i = 1; i <= totalPage; i++)
            {
                var itemUrls = driver.FindElements(By.CssSelector(".shop-search-result-view__item>a"));
                foreach (var j in itemUrls)
                {
                    itemUrlList.Add(j.GetAttribute("href"));
                }
                driver.FindElement(By.CssSelector(".shopee-mini-page-controller__next-btn")).Click();
            }

            foreach (var itemUrl in itemUrlList)
            {
                driver.Navigate().GoToUrl(itemUrl);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                var bigTypeName = driver.FindElements(By.CssSelector("a.CyVtI7"))[1].Text;
                var smallTypeName = driver.FindElements(By.CssSelector("a.CyVtI7"))[2].Text;
                int smallTypeID = dbContext.SmallTypes.Where(i => i.BigType.BigTypeName == bigTypeName && i.SmallTypeName == smallTypeName).Select(i => i.SmallTypeID).FirstOrDefault();
                if (smallTypeID > 0)
                {
                    var productName = driver.FindElement(By.CssSelector("div._2rQP1z")).Text;
                    var description = driver.FindElement(By.CssSelector("._2jrvqA")).Text;
                    Product product = new Product
                    {
                        ProductName = productName,
                        SmallTypeID = smallTypeID,
                        MemberID = 11,
                        RegionID = 37,
                        Description = description,
                        ProductStatusID = 0,
                        EditTime = DateTime.Now,
                        CustomizedCategoryID = 1,
                    };
                    dbContext.Products.Add(product);
                    dbContext.SaveChanges();
                    var newProductID = dbContext.Products.OrderByDescending(i => i.ProductID).Select(i => i.ProductID).FirstOrDefault();
                    try
                    {
                        foreach (var j in driver.FindElements(By.CssSelector(".product-variation")))
                        {
                            j.Click();
                            Thread.Sleep(300);
                            string style = j.Text;
                            int quantity = random.Next(10, 101);
                            decimal unitPrice = Convert.ToDecimal(driver.FindElement(By.CssSelector("._2Shl1j")).Text.Replace("$", "").Replace(",", "").Replace("-", "").Replace(" ", ""));
                            var productDetailPicUrl = driver.FindElement(By.CssSelector("._3CXjs-._3DKwBj")).GetAttribute("style").Split('"')[1];
                            HttpClient client = new HttpClient();
                            byte[] photo = await client.GetByteArrayAsync(productDetailPicUrl);
                            ProductDetail productDetail = new ProductDetail
                            {
                                ProductID = newProductID,
                                Style = style,
                                Quantity = quantity,
                                UnitPrice = unitPrice,
                                //Pic = photo,
                            };
                            dbContext.ProductDetails.Add(productDetail);
                        }
                        dbContext.SaveChanges();
                    }
                    catch
                    {
                        string style = "樣式一";
                        int quantity = random.Next(10, 101);
                        decimal unitPrice = Convert.ToDecimal(driver.FindElement(By.CssSelector("._2Shl1j")).Text.Replace("$", "").Replace(",", "").Replace("-", "").Replace(" ", ""));
                        var productDetailPicUrl = driver.FindElement(By.CssSelector("._3CXjs-._3DKwBj")).GetAttribute("style").Split('"')[1];
                        HttpClient client = new HttpClient();
                        byte[] photo = await client.GetByteArrayAsync(productDetailPicUrl);
                        ProductDetail productDetail = new ProductDetail
                        {
                            ProductID = newProductID,
                            Style = style,
                            Quantity = quantity,
                            UnitPrice = unitPrice,
                            //Pic = photo,
                        };
                        dbContext.ProductDetails.Add(productDetail);
                        dbContext.SaveChanges();
                    }
                    
                    driver.FindElement(By.CssSelector("._2_49CO")).Click();
                    Thread.Sleep(1000);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    var productPicUrls = driver.FindElements(By.CssSelector("._1BkYjB._3DKwBj"));
                    List<string> productPicUrlList = new List<string>();
                    foreach (var j in productPicUrls)
                    {
                        string productPicUrl = j.GetAttribute("style").Split('"')[1];
                        if (productPicUrlList.Contains(productPicUrl))
                        {
                            continue;
                        }
                        else
                        {
                            productPicUrlList.Add(productPicUrl);
                        }
                    }
                    foreach (var j in productPicUrlList)
                    {
                        HttpClient client = new HttpClient();
                        byte[] photo = await client.GetByteArrayAsync(j);
                        ProductPic productPic = new ProductPic
                        {
                            ProductID = newProductID,
                            Pic = photo,
                        };
                        dbContext.ProductPics.Add(productPic);
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        private void btnGetSmallTpye_Click(object sender, EventArgs e)
        {
            iSpanProjectEntities1 dbContext = new iSpanProjectEntities1();
            EdgeOptions edgeOptions = new EdgeOptions();
            edgeOptions.PageLoadStrategy = OpenQA.Selenium.PageLoadStrategy.Normal;
            EdgeDriver driver = new EdgeDriver(edgeOptions);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://shopee.tw/all_categories");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            var bigTypes = dbContext.BigTypes.Select(i => i).ToList();
            var bigTypeNames = bigTypes.Select(i => i.BigTypeName).ToList();
            var bigTypeTags = driver.FindElements(By.CssSelector("a.category-grid"));
            List<string> bigTypeUrlList = new List<string>();
            foreach (var i in bigTypeTags)
            {
                try
                {
                    if (bigTypeNames.Contains(i.Text))
                    {
                        bigTypeUrlList.Add(i.GetAttribute("href"));
                    }
                    
                }
                catch
                {
                    continue;
                }
            }
            foreach (var a in bigTypeUrlList)
            {
                driver.Navigate().GoToUrl(a);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                string bigTypeName = driver.FindElement(By.CssSelector(".shopee-category-list__main-category__link")).Text;
                int bigTypeID = dbContext.BigTypes.Where(i => i.BigTypeName == bigTypeName).Select(i=>i.BigTypeID).FirstOrDefault();
                if (bigTypeID < 1)
                {
                    continue;
                }
                try
                {
                    driver.FindElement(By.CssSelector("div.shopee-category-list__toggle-btn")).Click();
                }
                catch
                {

                }
                var smallTypeTaqs = driver.FindElements(By.CssSelector("a.shopee-category-list__sub-category"));
                List<string> smallTypeNameList = new List<string>();
                foreach (var j in smallTypeTaqs)
                {
                    string smallTypeName = j.Text;
                    if (smallTypeName == "")
                    {
                        continue;
                    }
                    var smallType = dbContext.SmallTypes.Where(i => i.BigTypeID == bigTypeID && i.SmallTypeName == smallTypeName).FirstOrDefault();
                    if (smallType == null)
                    {
                        SmallType smallType1 = new SmallType
                        {
                            SmallTypeName = smallTypeName,
                            BigTypeID = bigTypeID,
                        };
                        dbContext.SmallTypes.Add(smallType1);
                    }
                }
            }
            dbContext.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iSpanProjectEntities1 dbContext = new iSpanProjectEntities1();
            ProductDetail productDetail = new ProductDetail
            {
                ProductID = 19,
                Style = "樣式一",
                Quantity = 2,
                UnitPrice = 100,
                
            };
            dbContext.ProductDetails.Add(productDetail);
            dbContext.SaveChanges();
        }
    }
}
