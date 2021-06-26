using Data;
using Detail;
using Domain;
using Presenter;
using Repository;
using Repository.Interface;
using UnityEngine;
using Zenject;

public class MainInstaller : MonoInstaller
{
    [SerializeField] private UIView _uiView;
    [SerializeField] private GameView _gameView;
    
    public override void InstallBindings()
    {
        Debug.Log("do inject");
        
        Container
            .Bind<IInputPresenter>()
            .To<InputPresenter>()
            .AsCached();
        Container
            .Bind<IIOButtonPresenter>()
            .To<IOButtonPresenter>()
            .AsCached();
        Container
            .Bind<ISaveDataRepository>()
            .To<SaveDataRepository>()
            .AsCached();

        Container
            .Bind<ISaveDataStore>()
            .To<JsonDataStore>()
            .AsCached();

        Container
            .Bind<IUIView>()
            .FromInstance(_uiView);
        Container
            .Bind<IGameView>()
            .FromInstance(_gameView);
    }
}