using System.Data.SqlTypes;

namespace FileBrowser;

public partial class FileBrowserForm : Form
{
    private FilePreviewer _filePreviewer;

    public FileBrowserForm()
    {
        InitializeComponent();
        nextButton.Enabled = false;
        closeButton.Enabled = false;
        previousButton.Enabled = false;
    }

    private void openButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _filePreviewer = new FilePreviewer(openFileDialog.FileName);
            resultTextBox.Text = _filePreviewer.GetNextLine();
            openButton.Enabled = false;
            nextButton.Enabled = true;
            closeButton.Enabled = true;
        }
    }

    private void nextButton_Click(object sender, EventArgs e)
    {
        resultTextBox.Text = _filePreviewer.GetNextLine();
        previousButton.Enabled = true;
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        _filePreviewer.Dispose();
        nextButton.Enabled = false;
        closeButton.Enabled = false;
        resultTextBox.Clear();
    }

    private void previousButton_Click(object sender, EventArgs e)
    {
        resultTextBox.Text = _filePreviewer.GetPreviousLine();
    }
}

public class FilePreviewer : IDisposable
{
    private readonly StreamReader _reader;
    private readonly CyclicStack<string> _history = new(5);

    private string _currentLine;

    public FilePreviewer(string path) => _reader = new StreamReader(path);

    public void Dispose() => _reader.Dispose();

    public string GetNextLine()
    {
        if (_reader.EndOfStream)
        {
            return "-- END OF FILE --";
        }
        _history.Push(_currentLine);
        _currentLine = _reader.ReadLine();
        return _currentLine;
    }

    public string GetPreviousLine()
    {
        if (_history.Count == 0) return _currentLine;
        _currentLine = _history.Pop() ?? _currentLine;
        return _currentLine;
    }

}

public class CyclicStack<T>
{
    private T[] stack;
    private int capacity;
    private int curIndex = 0;

    public int Count { get; private set; }
    public CyclicStack(int capacity)
    {
        this.capacity = capacity;
        stack = new T[capacity];
        this.Count = 0;
    }
    public T this[int index]
    {
        get
        {
            if (index >= capacity)
                throw new Exception("Index is out of bounds");
            return this.stack[(curIndex + index) % capacity];
        }
    }
    public void Push(T item)
    {
        curIndex = (curIndex + capacity - 1) % capacity;
        stack[curIndex] = item;
        this.Count++;
    }
    public T Pop()
    {
        if (this.Count == 0)
            throw new Exception("Collection is empty");
        int oldIndex = curIndex;
        curIndex = (curIndex + capacity + 1) % capacity;
        this.Count--;
        return stack[oldIndex];
    }
}