using HephaestusMobile.LocalData;
using Zenject;

public class HephaestusLocalDataManagerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<ILocalDataManager>()
            .To<LocalDataManager>()
            .FromNewComponentOnNewGameObject()
            .WithGameObjectName("LocalDataManager")
            .AsSingle();
    }
}
