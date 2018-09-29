﻿
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Zbw.Testing.Dms.Client.UnitTests")]
namespace ZbW.Testing.Dms.Client.ViewModels
{
    using System.Windows.Controls;

    using Prism.Commands;
    using Prism.Mvvm;

    using ZbW.Testing.Dms.Client.Views;

    internal class MainViewModel : BindableBase
    {
        private string _benutzer;

        private UserControl _content;
        private bool _searchViewActive;
        private bool _documentDetailViewActive;

        public MainViewModel(string benutzername)
        {
            Benutzer = benutzername;
            CmdNavigateToSearch = new DelegateCommand(OnCmdNavigateToSearch);
            CmdNavigateToDocumentDetail = new DelegateCommand(OnCmdNavigateToDocumentDetail);
        }

        public string Benutzer
        {
            get
            {
                return _benutzer;
            }

            set
            {
                SetProperty(ref _benutzer, value);
            }
        }

        public UserControl Content
        {
            get
            {
                return _content;
            }

            set
            {
                SetProperty(ref _content, value);
            }
        }

        public bool SearchViewActive {
            get {
                return _searchViewActive;
            }

            set {
                SetProperty(ref _searchViewActive, value);
            }
        }

        public bool DocumentDetailViewActive {
            get {
                return _documentDetailViewActive;
            }

            set {
                SetProperty(ref _documentDetailViewActive, value);
            }
        }

        public DelegateCommand CmdNavigateToSearch { get; }

        public DelegateCommand CmdNavigateToDocumentDetail { get; }

        private void OnCmdNavigateToSearch()
        {
            NavigateToSearch();
        }

        private void OnCmdNavigateToDocumentDetail()
        {
            Content = new DocumentDetailView(Benutzer, NavigateToSearch);
            this.DocumentDetailViewActive = true;
            this.SearchViewActive = false;
        }

        private void NavigateToSearch()
        {
            Content = new SearchView();
            this.SearchViewActive = true;
            this.DocumentDetailViewActive = false;
        }
    }
}