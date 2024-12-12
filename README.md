## **Unicode Character Picker**

A simple Windows Forms application that allows users to search for Unicode characters by name and copy them to the clipboard for easy use in other applications.

---

### **Features**

- Search for Unicode characters by their **official names** (e.g., "GREEK SMALL LETTER PI").
- Select a character from a list and **copy it to the clipboard**.
- Unicode data is loaded from an easily editable `.ini` file.
- Works with **UTF-32 Unicode values** (valid range: `U+0000` to `U+10FFFF`).


---

### **How to Use**

1. Run the application.
2. Type part of the Unicode character name (e.g., "HEART" or "MINUS") into the **search bar**.
3. Select a character from the filtered list.
4. Click the **"Insert Character"** button to copy the character to the clipboard.
5. Paste the character wherever you need it (e.g., Notepad, Word, or code editors).

---

### **Requirements**

- Windows OS (tested on Windows 10 and above)
- .NET Framework or .NET 6+

---

### **Installation**

1. **Download** the executable:
   - Go to the [Releases](https://github.com/dspetla/unicode_picker_csharp/releases) page.
   - Download the latest version of the `UnicodePicker.exe` file.
2. Place `unicode_names.ini` in the same directory as the executable.
3. Run the application.

---

### **File Format for `unicode_names.ini`**

The Unicode character data is stored in an INI file with this format:

```
2212=MINUS SIGN
03C0=GREEK SMALL LETTER PI
00A9=COPYRIGHT SIGN
2665=BLACK HEART SUIT
```

- The first part (`2212`) is the **hexadecimal Unicode code point**.
- The second part (`MINUS SIGN`) is the **official Unicode name**.

You can add or edit entries as needed.

---

### **Building from Source**

1. Clone the repository:
   ```bash
   git clone https://github.com/dspetla/unicode_picker_csharp.git
   ```
2. Open the solution (`.sln`) in **Visual Studio**.
3. Build the project to generate the executable.

---

### **License**

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, and share it.

---

### **Contributing**

Contributions are welcome! Here’s how you can help:
- Add more Unicode characters to `unicode_names.ini`.
- Fix bugs or improve the code.
- Suggest new features (e.g., inserting characters directly at the cursor).
