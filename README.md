# TodoList

A simple WPF todo list application built as an MVVM refresher project.

## Architecture
- MVVM pattern with a `ViewModelBase` for `INotifyPropertyChanged`
- Per-item `TaskItemViewModel` wrappers to keep models free of UI concerns
- `ContentControl` navigation with `DataTemplates` for view switching
- Callback pattern for cross-ViewModel communication

## Tech
- C# / WPF
- .NET 8
