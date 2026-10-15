# Baobab Ridge Wildlife Rehabilitation Records System

PRG272 group project, group **VI_PM 10**, Belgium Campus iTversity.

A Windows Forms app that keeps rehabilitation records for the animals at Baobab Ridge.
Staff can add, view, update and delete animals, and generate a summary report.
Each animal's **status** and **housing unit** are calculated automatically from its recovery score.
All data is stored in plain text files. There is no database.

## Team

| Name | Student number | Feature(s) |
|---|---|---|
| Saiesha Ruanne Naidoo | 604096 | View animals (load, grid, skip malformed lines) |
| Lee Dikgale | 604808 | Add animal, validation, file helpers (append/rewrite), error handling, starter data |
| Lander Le Roux | 604134 | Update/edit animals, search function with highlight, saving the updated data |
| Mikael Quinlee Ruiters | 603543 | Delete animal, summary report |
| _Angel youssef_ | _602990_ | Summary calculations , form labels, summary.txt, presentation slides |

## Built with

- C# and Windows Forms (Visual Studio 2022)
- Plain text files (`System.IO`)
- Git and GitHub (feature branches + pull requests)

## How to build and run

1. Clone the repo:
   ```
   git clone https://github.com/SaieshaRuanneNaidoo/PRG272_Project_VI-PM10.git
   ```
2. Open `Project_PRG272.slnx` in Visual Studio 2022.
3. Press **F5** (or **Build > Build Solution**, then **Debug > Start Debugging**).
4. The starter `animals.txt` is copied next to the `.exe` (`bin\Debug\...`) on build ("Copy if newer"), so the grid shows sample data on the first run.

No extra packages or database setup are needed. The app only uses files in the same folder as the `.exe`, so it runs from any clone location.

## Features

- **View:** loads `animals.txt` on startup into a read-only grid (Animal ID, Name, Species, Age, Recovery Score, Status, Housing Unit). If the file is missing, an empty one is created. Malformed lines are skipped, and the user is told once how many were skipped.
- **Add:** validates every field, shows a message naming the field that is wrong and puts the cursor back in it. A valid animal is appended as one new line, and the calculated status and housing unit are shown.
- **Update:** load an animal by clicking a row or searching by ID, edit it, and save. The status and housing are always recalculated, and only that record changes in the file.
- **Delete:** removes the selected animal after a Yes/No confirmation.
- **Summary report:** shows totals, averages and a count per status on the form, and writes `summary.txt`.
- **Error handling:** every file operation is in a try/catch. A missing file or folder, a file open in another program (`IOException`) and a read-only file (`UnauthorizedAccessException`) all show a friendly message, and the app keeps running.

### Validation rules (Add and Update use the same method)

| Field | Rule |
|---|---|
| Animal ID | Required. `WR-` + exactly 4 digits. Converted to upper case (`wr-0007` → `WR-0007`). Must be unique when adding. Cannot change after saving |
| Name, Species | Required, 1–30 characters, cannot contain `\|` |
| Age, Recovery Score | Required whole numbers from 0 to 100 (no decimals or letters) |

All input is trimmed before it is checked.

### Status and housing unit

| Recovery score | Status | Housing unit |
|---|---|---|
| 0–19 | Critical | Intensive Care Unit |
| 20–39 | Serious | High-Dependency Ward |
| 40–59 | Stable | Recovery Ward |
| 60–79 | Recovering | Outdoor Enclosure |
| 80–100 | Release-Ready | Pre-Release Camp |

## File formats

### animals.txt (data file)

- Stored beside the `.exe`, UTF-8, no header, no blank lines, one animal per line.
- Seven fields separated by a pipe `|`:

```
ID|Name|Species|Age|Score|Status|Housing
WR-0007|Naledi|Leopard|7|60|Recovering|Outdoor Enclosure
```

- A line is skipped (malformed) if it doesn't have exactly 7 fields, the ID is invalid, the age or score isn't a whole number from 0 to 100, or the ID is a duplicate of an earlier line.
- Add appends one line. Update and Delete rewrite the file, changing only the selected record. Every other line, including skipped ones, is kept exactly as it was.

### summary.txt (report file)

- Written beside the `.exe` when **Generate Summary** is clicked, and overwritten each time.
- Contains the timestamp (`yyyy-MM-dd HH:mm`), total animals, average age, average recovery score (2 decimals with a full stop, or `N/A` if there are no animals) and a count for each of the 5 statuses.
- _Paste the exact layout here once the summary feature is merged._
- Not committed to Git (listed in `.gitignore`).

## Known limitations

- Only one person should use the app on a file at a time. Two copies of the app editing the same `animals.txt` can overwrite each other's changes.
- Changes made to `animals.txt` outside the app are only picked up the next time the grid refreshes.
- Name and Species can't contain `|`, because it is the field separator.
- _Add any others found during testing._
