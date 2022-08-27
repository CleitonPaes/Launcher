using System;
using System.IO;

namespace Launcher
{
    internal class Common
    {
        public static void ChangeStatus(string Key, params string[] Arguments)
        {
            Globals.pForm.Status.Text = Texts.GetText(Key, Arguments);
        }

        public static void UpdateCompleteProgress(long Value)
        {
            if (Value < 0 || Value > 100)
            {
                return;
            }

            Globals.pForm.completeProgress.Value = Convert.ToInt32(Value);
            Globals.pForm.completeProgressText.Text = Texts.GetText("COMPLETEPROGRESS", Value);

        }

        public static void UpdateCurrentProgress(long Value, double Speed)
        {
            if (Value < 0 || Value > 100)
            {
                return;
            }

            Globals.pForm.currentProgress.Value = Convert.ToInt32(Value);
            Globals.pForm.currentProgressText.Text = Texts.GetText("CURRENTPROGRESS", Value, Speed.ToString("0.00"));

        }

        public static string GetHash(string Name)
        {
            if (Name == string.Empty)
            {
                return string.Empty;
            }

            Crc32 crc = new Crc32();

            string Hash = string.Empty;


            //using (FileStream fileStream = File.Open(Name, FileMode.Open)) // codigo original
            //{
            //foreach (byte b in crc.ComputeHash(fileStream))
            // {
            //  Hash += b.ToString("x2").ToLower();
            //}
            //}

            // (codigo abaixo) assim contem o erro mas o arquivo ignorado vai fazer com que o patch apresente 99%~

            try
            {
                using (FileStream fileStream = File.Open(Name, FileMode.Open))
                {
                    foreach (byte b in crc.ComputeHash(fileStream))
                    {
                        Hash += b.ToString("x2").ToLower();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Hash;
            }
            return Hash;
        }
    }
}
