using GalaSoft.MvvmLight;
using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace TrainingApp.UI.ViewModel
{
    public class ScheduleViewModel : ViewModelBase, IDropTarget
    {
        //public ICollectionView Schools1 { get; private set; }
        //public ICollectionView Schools2 { get; private set; }
        //public ScheduleViewModel()
        //{
        //    ObservableCollection<SchoolViewModel> schools = new ObservableCollection<SchoolViewModel>();

        //    schools.Add(new SchoolViewModel
        //    {
        //        Name = "Bloomfield School",
        //        Pupils = new ObservableCollection<PupilViewModel>
        //        {
        //            new PupilViewModel { FullName = "Adam James" },
        //            new PupilViewModel { FullName = "Sophie Johnston" },
        //            new PupilViewModel { FullName = "Kevin Sandler" },
        //            new PupilViewModel { FullName = "Oscar Peterson" }
        //        }
        //    });


        //    Schools1 = CollectionViewSource.GetDefaultView(schools);

        //    ObservableCollection<SchoolViewModel> schools2 = new ObservableCollection<SchoolViewModel>();

        //    schools2.Add(new SchoolViewModel
        //    {
        //        Name = "Redacre School",
        //        Pupils = new ObservableCollection<PupilViewModel>
        //        {
        //            new PupilViewModel { FullName = "Tom Jefferson" },
        //            new PupilViewModel { FullName = "Tony Potts" }
        //        }
        //    });

        //    schools2.Add(new SchoolViewModel
        //    {
        //        Name = "Top Valley School",
        //        Pupils = new ObservableCollection<PupilViewModel>
        //        {
        //            new PupilViewModel { FullName = "Alex Thompson" },
        //            new PupilViewModel { FullName = "Tabitha Smith" },
        //            new PupilViewModel { FullName = "Carl Pederson" },
        //            new PupilViewModel { FullName = "Sarah Jones" },
        //            new PupilViewModel { FullName = "Paul Lowcroft" }
        //        }
        //    });

        //    Schools2 = CollectionViewSource.GetDefaultView(schools2);
        public void DragOver(IDropInfo dropInfo)
        {
            //    if (dropInfo.Data is PupilViewModel && dropInfo.TargetItem is SchoolViewModel)
            //    {
            //        dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
            //        dropInfo.Effects = DragDropEffects.Move;
            //    }
            throw new NotImplementedException();
        }

        public void Drop(IDropInfo dropInfo)
        {
            //SchoolViewModel school = (SchoolViewModel)dropInfo.TargetItem;
            //PupilViewModel pupil = (PupilViewModel)dropInfo.Data;
            //school.Pupils.Add(pupil);
            //((IList)dropInfo.DragInfo.SourceCollection).Remove(pupil);
            throw new NotImplementedException();
        }
    }


}

