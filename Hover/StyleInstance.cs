using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using libSnarlStyles;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using BeezleTester;
using System.Text.RegularExpressions;

namespace hover
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]

    public class StyleInstance : IStyleInstance
    {
        private BeezleDisplay myDisplay = new BeezleDisplay();

        public StyleInstance()
        {
            MessageBox.Show("Init");
        }

         

        #region IStyleInstance Members

        [ComVisible(true)]
        void IStyleInstance.AdjustPosition(ref int x, ref int y, ref short Alpha, ref bool Done)
        {
            return;
        }

        [ComVisible(true)]
        melon.MImage IStyleInstance.GetContent()
        {
            return null;
            throw new NotImplementedException();
        }

        [ComVisible(true)]
        bool IStyleInstance.Pulse()
        {
            return false;
            throw new NotImplementedException();
        }

        [ComVisible(true)]
        void IStyleInstance.Show(bool Visible)
        {
            MessageBox.Show(".Show: " + Visible.ToString());
            if (Visible)
            {
                myDisplay.Show();
            }
            else
            {
                myDisplay.closeNotification();
            }
            return;
        }

        [ComVisible(true)]
        void IStyleInstance.UpdateContent(ref notification_info NotificationInfo)
        {
            myDisplay.setNewIconPath(NotificationInfo.Icon);

            switch (NotificationInfo.Scheme) {
                case "icon only":
                    myDisplay.showIconOnly();
                    break;

                case "title":
                    myDisplay.showText(NotificationInfo.Title);
                    break;

                case "text":
                    myDisplay.showText(NotificationInfo.Text);
                    break;

                case "meter":
                    myDisplay.showProgressBar(parseTextForPercentage(NotificationInfo.Text));
                    break;

                default:
                    myDisplay.showIconOnly();
                    break;
            }
            myDisplay.Show();
        }


        private int parseTextForPercentage(string text)
        {
            Regex onlyDigits = new Regex("^[0-9]{1,3}$");
            if (onlyDigits.IsMatch(text))
            {
                return Convert.ToInt32(text);
            }

            Regex withPercentageSymbol = new Regex(@"(?<percentage>[0-9]{1,3}) {0,1}%");
            if (withPercentageSymbol.IsMatch(text))
            {
                Match myMatch = withPercentageSymbol.Match(text);
                return Convert.ToInt32(myMatch.Groups["percentage"].ToString());
            }

            Regex withPercentageText = new Regex(@"(?<percentage>[0-9]{1,3}) {0,1}Percent", RegexOptions.IgnoreCase);
            if (withPercentageText.IsMatch(text))
            {
                Match myMatch = withPercentageText.Match(text);
                return Convert.ToInt32(myMatch.Groups["percentage"].ToString());
            }

            Regex withPercentageMath = new Regex(@"(?<percentage>[0-9]{1,3}) {0,1}\/ {0,1}100", RegexOptions.IgnoreCase);
            if (withPercentageMath.IsMatch(text))
            {
                Match myMatch = withPercentageMath.Match(text);
                return Convert.ToInt32(myMatch.Groups["percentage"].ToString());
            }

            return 0;
        }

        #endregion


    }
}