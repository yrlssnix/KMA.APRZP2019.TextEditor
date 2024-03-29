﻿using System.Collections.ObjectModel;

namespace KMA.APRZP2019.TextEditorProject.TextEditor
{
    class FontSizesList : ObservableCollection<string>
    {
        /// <summary>
        /// List of available font sizes
        /// </summary>
        public FontSizesList()
        {
            this.Add("8");
            this.Add("9");
            this.Add("10");
            this.Add("11");
            this.Add("12");
            this.Add("14");
            this.Add("16");
            this.Add("18");
            this.Add("20");
            this.Add("22");
            this.Add("24");
            this.Add("26");
            this.Add("28");
            this.Add("36");
            this.Add("48");
            this.Add("72");
        }
    }
}
