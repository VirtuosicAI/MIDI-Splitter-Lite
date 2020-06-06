# MIDI Splitter Lite

![Program Screenshot](program_screenshot.png)

Overview
------------

MIDI Splitter Lite is a simple, lightweight program that splits tracks from a single MIDI file into their own seperate MIDI files.

Usage
------------

1. Click the "Browse" button next to the box labeled "MIDI File:" to open a MIDI file for splitting, or simply drag and drop a single MIDI file to open it for splitting as well.

2. Click the "Export" button next to the box labeled "Output Path:" and select the desired folder the MIDI tracks will be extracted to.

3. **Optional:** In the options menu, you can choose whether or not to copy the first track of the MIDI file to the selected tracks that are being exported. This may be useful if the first track is a setup track containing tempo and may wish to copy this information over. You can also choose whether or not to read the names of every track in the MIDI file (this should not have a considerable effect on load time).
	- **Note:** Be sure to re-open the MIDI file afterwards when changing the "Read track names" option for it to take effect.

4. Once the list is populated with tracks, select the track(s) you wish to be exported. To select multiple tracks, simply hold the CTRL key on your keyboard and left-click each track name in the list. You can also select all tracks in the list by pressing CTRL + A on your keyboard.

5. When finished selecting the desired track(s) to be exported, select the "Split track(s)" item under the File Menu to begin splitting the track(s) into their own seperate MIDI file.

Limitations
------------

- Only MIDIs created under the MIDI 1.0 specification are supported
- Only Format 1 MIDI files are supported

References
------------

To learn more about the MIDI 1.0 specification, visit the links below:
- MIDI File Format Specifications: https://github.com/colxi/midi-parser-js/wiki/MIDI-File-Format-Specifications
- The MIDI File Format: http://www.personal.kent.edu/~sbirch/Music_Production/MP-II/MIDI/midi_file_format.htm

MIDI Splitter Lite utilizes the Knuth–Morris–Pratt search algorithm to read the names of the tracks in a MIDI file. More information about the KMP search algorithm is available in the links below:
- C# implementation of KMP algorithm: https://gist.github.com/Nabid/fde41e7c2b0b681ac674ccc93c1daeb1
- Searching for Patterns | Set 2 (KMP Algorithm): https://www.geeksforgeeks.org/searching-for-patterns-set-2-kmp-algorithm/

