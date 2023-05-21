using HephaestusMobile.LocalData;
using Zenject;

public class HephaestusLocalDataManagerInstaller : Installer<HephaestusLocalDataManagerInstaller>
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<LocalDataManager>().AsSingle();
    }
}
