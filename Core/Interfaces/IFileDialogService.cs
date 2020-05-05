namespace Core
{
    public interface IFileDialogService
    {
        /// <summary>
        /// Open File Dialog and get the name of the file that selected. (return only one file)
        /// </summary>
        /// <returns></returns>
        string OpenFileDialog(string defaultExt);

        /// <summary>
        /// Open File Dialog and get the names of the file that selected. (return multiple files)
        /// </summary>
        /// <returns></returns>
        string[] OpenFilesDialog(string defaultExt);
    }
}
