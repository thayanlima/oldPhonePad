# OldPhonePad Decoder

Simulates text input on old mobile phone keypads (like classic Nokia models), where numeric keys map to multiple letters.

## How It Works

Each numeric key represents a group of letters. Pressing a key multiple times cycles through its letters.

- `2` → A, B, C  
- `3` → D, E, F  
- `4` → G, H, I  
- `5` → J, K, L  
- `6` → M, N, O  
- `7` → P, Q, R, S  
- `8` → T, U, V  
- `9` → W, X, Y, Z  
- `0` → Space  
- `*` → Backspace  
- `#` → Send (ends input)  
- Space (` `) → Pause between letters using the same key

### Examples

| Input                           | Output  |
|--------------------------------|---------|
| `33#`                          | E       |
| `227*#`                        | B       |
| `4433555 555666#`              | HELLO   |
| `8 88777444666*664#`           | TURING  |

---

## How to Run

### Requirements

- [.NET SDK](https://dotnet.microsoft.com/)
- Visual Studio Code with the "C#" extension installed

### Run the console app:

bash
dotnet run --project ProgramRunner

dotnet test
