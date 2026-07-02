#if SUNRISE_PRIVATE
using Content.Client._SunrisePrivate.JoinQueue;
<<<<<<< HEAD
=======
using Content.Client._SunrisePrivate.MakuraAuth;
>>>>>>> sunrise/master
using Content.Client._SunrisePrivate.Sponsors;
using Content.Sunrise.Interfaces.Client;
using Content.Sunrise.Interfaces.Shared;
#endif

namespace Content.Client._Sunrise.IoC;

internal static class SunriseClientContentIoC
{
    public static void Register()
    {
#if SUNRISE_PRIVATE
        var collection = IoCManager.Instance!;
        collection.Register<ISharedAccountBindingsManager, ClientAccountBindingsManager>();
        collection.Register<ISharedSponsorsManager, ClientSponsorsManager>();
        collection.Register<IClientJoinQueueManager, JoinQueueManager>();
#endif
    }
}
