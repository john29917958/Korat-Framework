using System.Windows.Forms;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers.Ie
{
    public class Edge : IeBehaviors
    {
        public override string Version => "edge";

        public Edge(Korat korat) : base(korat)
        {

        }

        public override void FocusUrlBar()
        {
            Korat.SendKey(Keys.F6);
        }
    }
}
