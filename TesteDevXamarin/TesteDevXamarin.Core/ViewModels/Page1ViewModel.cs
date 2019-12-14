using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteDevXamarin.Core.Models.Data.JSONMapping;
using TesteDevXamarin.Core.Models.Domain;
using System.Linq;

namespace TesteDevXamarin.Core.ViewModels
{
    public class Page1ViewModel : MvxViewModel
    {
        public List<State> States { get; set; }
        public ImportStates importedStates = new ImportStates();
        public async Task GetStates()
        {
            await importedStates.GetRecords();

            foreach (var record in importedStates.root.records)
            {
                this.States.Add(new State
                {
                    Id = record.id,
                    Name = record.fields.Estado,
                    Sigla = record.fields.Sigla,
                    Capital = record.fields.Capital,
                    FlagUrl = record.fields.Attachments.FirstOrDefault().thumbnails.small.url,
                    Region = new Region { Name = record.fields.Regiao }
                });
            }
        }
    }
}
