using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPSample.Infrastructure;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using PrismMVVMPSample.Infrastructure.Model;

namespace PrismMVVMPSample.KeypadModule.Keypad
{
    class KeypadPresenter: PresenterBase<IKeypadView, KeypadViewModel>
    {
        int firstNumber;
        int secondNumber;
        Operator? @operator;
        IEventAggregator eventAggregator;

        public KeypadPresenter(IKeypadView view, IEventAggregator eventAggregator): base(view)
        {
            this.eventAggregator = eventAggregator;
            ViewModel.KeyPressedCommand = new DelegateCommand<object>(KeyPressedCommand_Execute);
            ViewModel.OperatorCommand = new DelegateCommand<Operator?>(OperatorCommand_Execute);
        }

        void KeyPressedCommand_Execute(object key)
        {
            int result;
            int digit = Convert.ToInt32(key);
            if (@operator.HasValue)
                result = secondNumber = (secondNumber * 10) + digit;
            else
                result = firstNumber = (firstNumber * 10) + digit;

            UpdateResult(result);
        }

        void OperatorCommand_Execute(Operator? op)
        {
            if (@operator.HasValue)
            {
                firstNumber = EvalulateOperator();
                secondNumber = 0;
                UpdateResult(firstNumber);
            }
            if (op != Operator.Equals)
                @operator = op;
        }

        void UpdateResult(int result)
        {
            eventAggregator.GetEvent<ResultChangedEvent>().Publish(result);
        }

        int EvalulateOperator()
        {
            switch (@operator.Value)
            {
                case Operator.Plus: return firstNumber + secondNumber;
                case Operator.Minus: return firstNumber - secondNumber;
                case Operator.Multiply: return firstNumber * secondNumber;
                case Operator.Divide: return firstNumber / secondNumber;
            }
            return 0;
        }
    }
}
