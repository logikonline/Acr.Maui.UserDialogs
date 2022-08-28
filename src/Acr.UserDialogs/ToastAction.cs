using System;
using System.Drawing;
using Color = Microsoft.Maui.Graphics.Color;

namespace Acr.UserDialogs
{
    public class ToastAction
    {
        public string Text { get; set; }
        public Color? TextColor { get; set; }
        public Action Action { get; set; }


        public ToastAction SetText(string text)
        {
            this.Text = text;
            return this;
        }


        public ToastAction SetTextColor(Color color)
        {
            this.TextColor = color;
            return this;
        }


        public ToastAction SetAction(Action action)
        {
            this.Action = action;
            return this;
        }
    }
}
