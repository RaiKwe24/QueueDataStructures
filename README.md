# QueueDataStructures

A Windows desktop application that demonstrates FIFO queue operations with priority-based delivery management.

QueueDataStructures lets users add customer or order names to four delivery queues: **Express**, **Premium**, **Standard**, and **Same-Day delivery**. Entries are served in priority order, so Express orders are handled before lower-priority deliveries.

## Features

- Add customer or order entries to four delivery-service queues
- Serve entries using the priority order: **Express → Premium → Standard → Same-Day**
- Preserve first-in, first-out (FIFO) ordering within each priority
- Display the queued entries and queue counts
- Clear all delivery queues in one action
- Automatically timestamp each added entry

## Built With

- C#
- [.NET 10](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Windows Forms](https://learn.microsoft.com/dotnet/desktop/winforms/)
- `System.Collections.Generic.Queue<T>`

## How It Works

The application maintains a separate `Queue<string>` for each delivery type in [`Form1.cs`](QueueDataStructures/Form1.cs):

```csharp
private readonly Queue<string> expressQueue = new Queue<string>();
private readonly Queue<string> premiumQueue = new Queue<string>();
private readonly Queue<string> standardQueue = new Queue<string>();
private readonly Queue<string> sameDayQueue = new Queue<string>();
```

When an entry is added, `Enqueue` places it at the end of the selected service queue. When **Serve Next** is selected, the application checks each queue in priority order and uses `Dequeue` to remove and serve the first entry from the highest-priority nonempty queue.

The application entry point is [`Program.cs`](QueueDataStructures/Program.cs), and the WinForms interface is defined in [`Form1.Designer.cs`](QueueDataStructures/Form1.Designer.cs).

## Requirements

- Windows 10 or later
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later
- Visual Studio 2026 or Visual Studio Code with C# support

## Installation

### Option 1: Run with Visual Studio

1. Clone the repository:

   ```bash
   git clone https://github.com/RaiKwe24/QueueDataStructures.git
   ```

2. Open `QueueDataStructures.slnx` in Visual Studio.
3. Restore dependencies if prompted.
4. Select `QueueDataStructures` as the startup project if necessary.
5. Press **Start** or **F5** to run the application.

### Option 2: Run with the .NET CLI

Clone the repository and enter the project directory:

```bash
git clone https://github.com/RaiKwe24/QueueDataStructures.git
cd QueueDataStructures
```

Run the application:

```bash
dotnet run --project QueueDataStructures/QueueDataStructures.csproj
```

Build the application without starting it:

```bash
dotnet build QueueDataStructures/QueueDataStructures.csproj
```

## Usage

1. Choose a delivery service:
   - Express
   - Premium
   - Standard
   - Same day delivery
2. Enter a customer or order name.
3. Select **Add to Queue**.
4. Repeat to add more entries.
5. Select **Serve Next** to serve the first entry in the highest-priority queue.
6. Select **Clear All** to remove every entry.

### Example

An Express order and a Standard order can be entered in either order. Because Express has the highest priority, selecting **Serve Next** will serve the Express entry first.

A blank customer field is stored as `(no name)`, and each entry includes the time it was added, for example:

```text
Alex Johnson - 14:32:18
```

## Project Structure

```text
QueueDataStructures/
├── QueueDataStructures/
│   ├── Form1.cs                    # Queue behavior and application events
│   ├── Form1.Designer.cs           # Windows Forms controls and layout
│   ├── Form1.resx                  # Form resources
│   ├── Program.cs                  # Application entry point
│   └── QueueDataStructures.csproj  # Project configuration
├── QueueDataStructures.slnx        # Visual Studio solution
├── LICENSE.txt                     # MIT license
└── README.md
```

## Contributing

Contributions are welcome.

1. Fork this repository.
2. Create a feature branch:

   ```bash
   git checkout -b feature/your-feature-name
   ```

3. Make your changes and build the project:

   ```bash
   dotnet build QueueDataStructures/QueueDataStructures.csproj
   ```

4. Commit your work:

   ```bash
   git commit -m "Add your descriptive message"
   ```

5. Push the branch and open a pull request.

Please keep changes focused, use clear names, and preserve the existing priority order unless a change is intentionally designed and documented.

## Getting Help

- Review the existing [issues](https://github.com/RaiKwe24/QueueDataStructures/issues).
- Open a [new issue](https://github.com/RaiKwe24/QueueDataStructures/issues/new) with:
  - A clear problem description
  - Steps to reproduce the issue
  - Expected and actual behavior
  - Your Windows and .NET versions

## License

This project is available under the [MIT License](LICENSE.txt).

Copyright © 2026 Raisibe