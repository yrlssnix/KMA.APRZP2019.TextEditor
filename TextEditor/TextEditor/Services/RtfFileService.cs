﻿using KMA.APRZP2019.TextEditorProject.TextEditor.Models.Exceptions;
using KMA.APRZP2019.TextEditorProject.TextEditor.Properties;
using KMA.APRZP2019.TextEditorProject.TextEditor.Services.interfaces;
using KMA.APRZP2019.TextEditorProject.Tools;
using System;
using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace KMA.APRZP2019.TextEditorProject.TextEditor.Services
{
    class RtfFileService : IFileService
    {
        public void Load(string filename, TextPointer start, TextPointer end)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filename, FileMode.Open))
                {
                    TextRange range = new TextRange(start, end);
                    range.Load(fileStream, DataFormats.Rtf);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                throw new LoadFileException(String.Format(Resources.LoadFileException_Msg, filename));
            }
        }

        public void Save(string filename, TextPointer start, TextPointer end)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filename, FileMode.Create))
                {
                    TextRange range = new TextRange(start, end);
                    range.Save(fileStream, DataFormats.Rtf);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                throw new SaveFileException(String.Format(Resources.SaveFileException_Msg, filename));
            }
        }
    }
}
