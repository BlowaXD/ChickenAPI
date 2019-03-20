using System;
using System.Threading.Tasks;

namespace ChickenAPI.Core.Utils
{
    public delegate void TypedSenderEventHandler<in TSender, in TEventArgs>(TSender sender, TEventArgs e)
    where TSender : class
    where TEventArgs : EventArgs;

    public delegate Task AsyncTypedSenderEventHandler<in TSender, in TEventArgs>(TSender sender, TEventArgs e)
    where TSender : class
    where TEventArgs : EventArgs;
}