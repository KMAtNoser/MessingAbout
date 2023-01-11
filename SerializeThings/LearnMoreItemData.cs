using System;

namespace E_App.Dtos
{
    public interface ILearnMoreItemData
    {
        string ProductImage { get; }
        string BlueText { get; }
        string HyperlinkURL { get; }
        string HyperLinkPageName { get; }

        string ProductDesc { get; }
        
        string ProductInfoPageBtnText { get; }
        string ProductInfoPageIcon { get; }
    }

    [Serializable]
    public class LearnMoreItemData :
        ILearnMoreItemData
    {
        public string ProductImage { get; set; }
        public string BlueText { get; set; }
        public string HyperlinkURL { get; set; }
        public string HyperLinkPageName { get; set; }

        public string ProductDesc { get; set; }

        public string ProductInfoPageBtnText { get; set; }
        public string ProductInfoPageIcon { get; set; }
    }
}
