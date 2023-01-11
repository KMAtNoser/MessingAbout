using E_App.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializeThings
{
    internal class SerializeLearnMoreProductsList
    {
        static public void Run()
        {
            var list = new List<LearnMoreItemData>
                {
                    new LearnMoreItemData
                    {
                        ProductImage = "proQ.png",
                        BlueText = $"Optiflex® Pro Q: color change in 35{Environment.NewLine}Seconds!",
                        HyperlinkURL = "https://noser-group.ch/wp-content/uploads/2020/04/PR_NoserManagement_April20.pdf", // "http://www.gemapowdercoating.com/en/",
                        HyperLinkPageName = "Pro Q",
                        ProductDesc = $"Without big investments you can reduce{Environment.NewLine}idle times and maximize your{Environment.NewLine} productivity",
                        ProductInfoPageBtnText = "more information",
                        ProductInfoPageIcon = "paired.png",
                    },
                    new LearnMoreItemData
                    {
                        ProductImage = "proB.png",
                        BlueText = $"Optiflex® Pro B: Perfect for{Environment.NewLine}frequent color changes",
                        HyperlinkURL = "http://www.gemapowdercoating.com/en/",
                        HyperLinkPageName = "Pro B",
                        ProductDesc = $"It takes the powder directly from the{Environment.NewLine}original box. No need to replace and{Environment.NewLine}clean hoppers at color change",
                        ProductInfoPageBtnText = "more information",
                        ProductInfoPageIcon = "paired.png",
                    },
                    new LearnMoreItemData
                    {
                        ProductImage = "proS.png",
                        BlueText = $"Optiflex® Pro S: the best solution{Environment.NewLine}for difficult powders",
                        HyperlinkURL = "http://www.gemapowdercoating.com/en/",
                        HyperLinkPageName = "Pro S",
                        ProductDesc = $"The uniques design is ideal to feed hard-{Environment.NewLine}to-fluidize or dry-blended materials",
                        ProductInfoPageBtnText = "more information",
                        ProductInfoPageIcon = "paired.png",
                    },
                    new LearnMoreItemData
                    {
                        ProductImage = "proF.png",
                        BlueText = $"Optiflex® Pro F Spray: designed for{Environment.NewLine}high powder outputs",
                        HyperlinkURL = "http://www.gemapowdercoating.com/en/",
                        HyperLinkPageName = "Pro F",
                        ProductDesc = $"The usage of OptiSpray AP01 application{Environment.NewLine}pumps ensures best coating results for{Environment.NewLine}high film builds with a powder output of{Environment.NewLine}up to 600 g/min",
                        ProductInfoPageBtnText = "more information",
                        ProductInfoPageIcon = "paired.png",
                    }
                };

            var filePath = @"C:\Temp\products.xml";
            Write(filePath, list);

            var list2 = Read(filePath);

        }

        static List<LearnMoreItemData> Read(string filePath)
        {
            var list = new List<LearnMoreItemData>();
            var serializer = new XmlSerializer(typeof(List<LearnMoreItemData>));
            using (var reader = new System.IO.StreamReader(filePath))
            {
                list = (List<LearnMoreItemData>)serializer.Deserialize(reader);
            }
            return list;
        }

        static void Write(
            string filePath, 
            List<LearnMoreItemData> list)
        {
            var serializer = new XmlSerializer(typeof(List<LearnMoreItemData>));
            var writer = new StreamWriter(@"C:\Temp\products.xml");
            var productsList = list;
            serializer.Serialize(writer, productsList);
            writer.Close();
        }
    }
}
