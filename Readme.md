**Project Description**

This project contains a sample application demonstrating the Model View ViewModel Presenter (MVVMP) Pattern using Unity, MEF and Prism

It also contains a stub that can be used to rapidly build an MVVMP based application using Prism.

{{
class LEDPresenter: PresenterBase<ILEDView, LEDViewModel>
{
        public LEDPresenter(ILEDView view, IEventAggregator eventAggregator): base(view)
        {
            eventAggregator.GetEvent<ResultChangedEvent>().Subscribe(OnResultChanged);
        }

        void OnResultChanged(int result)
        {
            ViewModel.Result = result;
        }
}
}}

Read the following for explanation:
* [How to implement MVVMP Pattern?](http://www.overroot.com/blog/?p=285)
* [Model-View-ViewModel Presenter pattern in WPF and Prism](http://www.overroot.com/blog/?p=188)
* [Model View ViewModel Presenter pattern in the Kitchen](http://www.overroot.com/blog/?p=277)