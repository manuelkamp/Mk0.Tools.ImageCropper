using System;
using System.Drawing;

namespace Mk0.Tools.ImageCropper
{
    /// <summary>
    /// Passes the cropping rectangle and current cursor position to the host object
    /// </summary>
    public class StatusEventArg : EventArgs
    {
        public readonly Rectangle CroppingRect;
        public readonly Point CursorPos;

        public StatusEventArg(Point pos, Rectangle crop)
        {
            CursorPos = pos;
            CroppingRect = crop;
        }
    }
}
