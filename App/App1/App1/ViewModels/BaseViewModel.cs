using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.ViewModels
{
    //class BaseViewModel, base abstrata que nao pode ser estanciada, usada como herança
    public abstract class BaseViewModel : BindableObject //Listening
    {
        private bool isBusy;
        //dica: prof
        public bool IsBusy
        {
            //get { return isBusy; }
            get => isBusy;
            //set { isBusy = value; }
            set { isBusy = value; OnPropertyChanged(); } //Notifica a propriedade que o contexto foi alterado
        }

        public bool isNotBusy => !IsBusy; //Exemplo: Desabilita o botão enquanto processamento está sendo feito


        //Assíncrona
        public async Task ExecuteBusyAction(Func<Task> theBuysAction)
        {
            if (IsBusy)
            {
                return;
            }

            try
            {
                IsBusy = true;

                await theBuysAction();
            }
            catch (Exception ex)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex);
#endif
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }

        //Virtual: Faz com que o método possa ser reescrito:
        public virtual Task Initialize()
            => Task.CompletedTask; //Forma de utilizar o return;
            
       

    }
}
