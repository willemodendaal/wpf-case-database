using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace CaseDatabase
{
    /// <summary>
    /// Used to add Async functionality to storyboards.
    /// 
    /// Adapted from: http://stackoverflow.com/questions/14690960/wpf-what-is-the-correct-way-to-wait-for-a-storyboard-animation-to-complete-befo
    /// </summary>
    public static class StoryboardExtensions
    {

        /// <summary>
        /// Begin animation async. Completes when the animation completes.
        /// </summary>
        public static Task BeginAsync(this Storyboard storyboard, FrameworkElement elm)
        {
            System.Threading.Tasks.TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            if (storyboard == null)
                tcs.SetException(new ArgumentNullException());
            else
            {
                EventHandler onComplete = null;
                onComplete = (s, e) => {
                    storyboard.Completed -= onComplete;
                    tcs.SetResult(true);
                };
                storyboard.Completed += onComplete;
                storyboard.Begin(elm);
            }
            return tcs.Task;
        }
    }
}
