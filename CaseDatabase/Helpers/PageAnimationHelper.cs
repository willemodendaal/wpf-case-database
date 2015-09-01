using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace CaseDatabase
{
    internal static class PageAnimationHelper
    {
        internal static void SlideFromRight(Window parent, UserControl target)
        {
            var sb = parent.FindResource("SlideFromRightAnimation") as Storyboard;
            Storyboard.SetTarget(sb, target);
            sb.Begin();
        }

        internal static void SlideToRight(Window parent, UserControl target)
        {
            var sb = parent.FindResource("SlideToRightAnimation") as Storyboard;
            Storyboard.SetTarget(sb, target);
            sb.Begin();
        }

        internal static void SlideFromLeft(Window parent, UserControl target)
        {
            var sb = parent.FindResource("SlideFromLeftAnimation") as Storyboard;
            Storyboard.SetTarget(sb, target);
            sb.Begin();
        }

        internal static void SlideToLeft(Window parent, UserControl target)
        {
            var sb = parent.FindResource("SlideToLeftAnimation") as Storyboard;
            Storyboard.SetTarget(sb, target);
            sb.Begin();
        }

    }
}
